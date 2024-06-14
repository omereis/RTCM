/*****************************************************************************\
|                               dlgEditUser.cs                                |
\*****************************************************************************/
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTCM {
	public partial class dlgEditUser : Form {
		//-----------------------------------------------------------------------------
		private MySqlCommand m_cmd;
		private string m_strErr = "";
		private char m_cPasswd;
		public dlgEditUser() {
			InitializeComponent();
			m_strErr = "";
			m_cPasswd = txtbxPassword.PasswordChar;
		}
		//-----------------------------------------------------------------------------
		public bool Execute(TUserInfo user, MySqlCommand cmd) {
			Download(user, cmd);
			ShowDialog();
			bool fEdit = DialogResult == DialogResult.OK;
			if (fEdit)
				Upload(user);
			return (fEdit);
		}
		//-----------------------------------------------------------------------------
		private void Download(TUserInfo user, MySqlCommand cmd) {
			bool fDebug = false;
#if DEBUG
			fDebug = true;
#endif
			m_cmd = cmd;
			DownloadLevels(cmd);
			txtbxID.Visible = fDebug;
			txtbxID.Text = user.ID.ToString();
			txtbxFirst.Text = user.First;
			txtbxLast.Text = user.Last;
			txtbxUsername.Text = user.Username;
			txtbxPassword.Text = user.Password;
			cboxActive.Checked = user.IsActive;
			DownloadUserLevel(user.Level);
		}
		//-----------------------------------------------------------------------------
		private void Upload(TUserInfo user) {
			user.ID = TMisc.ToIntDef(txtbxID.Text);
			user.First = txtbxFirst.Text;
			user.Last = txtbxLast.Text;
			user.Username = txtbxUsername.Text;
			user.Password = txtbxPassword.Text;
			user.IsActive = cboxActive.Checked;
			UploadUserLevel(user);
		}
		//-----------------------------------------------------------------------------
		private TUserInfo Upload() {
			TUserInfo user = new TUserInfo();
			user.ID = TMisc.ToIntDef(txtbxID.Text);
			user.First = txtbxFirst.Text;
			user.Last = txtbxLast.Text;
			user.Username = txtbxUsername.Text;
			user.Password = txtbxPassword.Text;
			user.IsActive = cboxActive.Checked;
			UploadUserLevel(user);
			return (user);
		}
		//-----------------------------------------------------------------------------
		private void DownloadLevels(MySqlCommand cmd) {
			TLevels levels = new TLevels();
			if (levels.LoadAll(cmd, ref m_strErr)) {
				comboLevels.Items.Clear();
				for (int n = 0; n < levels.Values.Length; n++)
					comboLevels.Items.Add(levels.Values[n]);
				comboLevels.Items.Add(new TStringInt());
			} else
				MessageBox.Show(m_strErr);
		}
		//-----------------------------------------------------------------------------
		private void DownloadUserLevel(string strLevel) {
			int idx = FindLevel(strLevel);
			if (idx >= 0)
				comboLevels.SelectedIndex = idx;
		}
		//-----------------------------------------------------------------------------
		private int FindLevel(string strLevel) {
			int n, nFound = -1;

			for (n = 0; (n < comboLevels.Items.Count) && (nFound < 0); n++)
				if (comboLevels.Items[n].ToString() == strLevel)
					nFound = n;
			return (nFound);
		}
		//-----------------------------------------------------------------------------
		private void UploadUserLevel(TUserInfo user) {
			if (comboLevels.SelectedIndex >= 0) {
				TStringInt si = (TStringInt)comboLevels.Items[comboLevels.SelectedIndex];
				user.Level = si.StrVal;
				user.LevelID = si.IntVal;
			}
		}
		//-----------------------------------------------------------------------------
		private void btnOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
		//-----------------------------------------------------------------------------
		private void btnShow_Click(object sender, EventArgs e) {
			txtbxPassword.PasswordChar = '\0';
			timerShow.Enabled = true;
		}
		//-----------------------------------------------------------------------------
		private void timerShow_Tick(object sender, EventArgs e) {
			txtbxPassword.PasswordChar = '\0';
			timerShow.Enabled = false;
		}
		//-----------------------------------------------------------------------------
		private void btnCheckUser_Click(object sender, EventArgs e) {
			CheckUsername();
		}
		//-----------------------------------------------------------------------------
		private bool CheckUsername() {
			TUserInfo user = new TUserInfo();
			bool fNameOK = false;
			Upload(user);
			if (user.IsValidUsername(m_cmd, ref fNameOK, ref m_strErr)) {
				if (fNameOK)
					MessageBox.Show(String.Format("Username '{0}' valid", user.Username));
				else
					MessageBox.Show(String.Format("Username '{0}' NOT VALID", user.Username), "Check Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else
				MessageBox.Show(m_strErr);
			return (fNameOK);
		}
		//-----------------------------------------------------------------------------
		private void btnSuggestUser_Click(object sender, EventArgs e) {
			TUserInfo user = Upload();
			int n = user.ID;
			bool fValid = false, fNameOK = false;
			string strUsername = "";

			while (!fValid) {
				strUsername = String.Format("user{0}", n);
				if (user.IsValidUsername(m_cmd, strUsername, ref fNameOK, ref m_strErr))
					if (!fNameOK)
						n++;
					else
						fValid = true;
			}
			if (fValid) {
				txtbxUsername.Text = strUsername;
				txtbxUsername.BackColor = Color.Yellow;
				timerSuggest.Enabled = true;
			}
		}
//-----------------------------------------------------------------------------
		private void timerSuggest_Tick(object sender, EventArgs e) {
			txtbxUsername.BackColor = Color.White;
			timerSuggest.Enabled = false;
		}
//-----------------------------------------------------------------------------
	}
}
