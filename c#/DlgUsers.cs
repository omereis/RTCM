/*****************************************************************************\
|                                DlgUsers.cs                                  |
\*****************************************************************************/
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------------------------------------------------------
using System.Collections;

using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;
//-----------------------------------------------------------------------------
namespace RTCM {
	public partial class DlgUsers : Form {
		private MySqlConnection m_database;
		private MySqlCommand m_cmd;
		private string m_strErr;
		//-----------------------------------------------------------------------------
		public DlgUsers() {
			InitializeComponent();
		}
		//-----------------------------------------------------------------------------
		public bool Execute(MySqlConnection database) {
			Download(database);
			return (ShowDialog() == DialogResult.OK);
			//return (true);
		}
		//-----------------------------------------------------------------------------
		private void btnOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
		//-----------------------------------------------------------------------------
		private void Download(MySqlConnection database) {
			ArrayList aUsers = new ArrayList();
			m_database = database;
			m_cmd = new MySqlCommand();
			m_cmd.Connection = m_database;
			//DownloadLevels (m_cmd);
			if (TUserInfo.LoadUsers(m_cmd, aUsers, ref m_strErr))
				DownloadUsers(aUsers);
		}
		//-----------------------------------------------------------------------------
		private void DownloadUsers(ArrayList aUsers) {
			gridUsers.RowCount = aUsers.Count;
			for (int n = 0; n < aUsers.Count; n++)
				DownloadUserRow(n, (TUserInfo)aUsers[n]);
		}
		//-----------------------------------------------------------------------------
		private void DownloadUserRow(int row, TUserInfo user) {
			gridUsers.Rows[row].Cells[0].Tag = user.ID;
			gridUsers.Rows[row].Cells[0].Value = user.GetFullName();
			gridUsers.Rows[row].Cells[1].Value = user.Username;
			gridUsers.Rows[row].Cells[2].Value = user.Level;
			gridUsers.Rows[row].Cells[3].Value = user.IsActive ? "Active" : "Not Active";
		}
		//-----------------------------------------------------------------------------
		private void btnAdd_Click(object sender, EventArgs e) {
			TUserInfo user = new TUserInfo();
			m_strErr = "";
			if (user.InsertyAsNew(m_cmd, ref m_strErr))
				if (EditUser(user)) {
					if (user.UpdateInDB(m_cmd, ref m_strErr))
						AddRow(user);
				} else
					user.DeleteFromDB(m_cmd, ref m_strErr);
			if (m_strErr.Length > 0)
				MessageBox.Show(m_strErr);
		}
		//-----------------------------------------------------------------------------
		private bool EditUser(TUserInfo user) {
			dlgEditUser dlg = new dlgEditUser();
			return (dlg.Execute(user, m_cmd));
		}
		//-----------------------------------------------------------------------------
		private void AddRow(TUserInfo user) {
			gridUsers.RowCount += 1;
			DownloadUserRow(gridUsers.RowCount - 1, user);
		}
		//-----------------------------------------------------------------------------
		private void btnEdit_Click(object sender, EventArgs e) {
			EditGridRow();
		}
//-----------------------------------------------------------------------------
		private void EditGridRow() {
			TUserInfo user = new TUserInfo();
			if (gridUsers.CurrentRow != null) {
				int row = gridUsers.CurrentRow.Index;
				if (UploadUserFromRow (user, row)) {
				//user.ID = (int)gridUsers.Rows[row].Cells[0].Tag;
				//if (user.LoadFromDBByID(m_cmd, ref m_strErr)) {
					if (EditUser(user)) {
						if (user.UpdateInDB(m_cmd, ref m_strErr))
							DownloadUserRow(row, user);
					}
				}
			}
		}
//-----------------------------------------------------------------------------
		private bool UploadUserFromRow (TUserInfo user, int row) {
			bool fLoad;
			user.ID = (int) gridUsers.Rows[row].Cells[0].Tag;
			fLoad = user.LoadFromDBByID(m_cmd, ref m_strErr);
			return (fLoad);
		}
//-----------------------------------------------------------------------------
		private void gridUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			EditGridRow();
		}
//-----------------------------------------------------------------------------
		private void btnDel_Click(object sender, EventArgs e) {
			if (gridUsers.CurrentRow != null) {
				TUserInfo user = new TUserInfo ();
				int row = gridUsers.CurrentRow.Index;
				if (UploadUserFromRow (user, row)) {
					string strMsg = String.Format ("Delete user {0}?", user.GetFullName());
					if (MessageBox.Show (strMsg, "Delete User",
							MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
						if (user.DeleteFromDB (m_cmd, ref m_strErr))
							gridUsers.Rows.RemoveAt (row);
					}
				}
			}
		}
//-----------------------------------------------------------------------------
	}
}
