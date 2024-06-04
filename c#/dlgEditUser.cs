/*****************************************************************************\
|                               dlgEditUser.cs                                |
\*****************************************************************************/
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTCM {
	public partial class dlgEditUser : Form {
//-----------------------------------------------------------------------------
		public dlgEditUser() {
			InitializeComponent();
		}
//-----------------------------------------------------------------------------
		public bool Execute (TUserInfo user) {
			Download (user);
			ShowDialog ();
			bool fEdit = DialogResult == DialogResult.OK;
			if (fEdit)
				Upload (user);
			return (fEdit);
		}
//-----------------------------------------------------------------------------
		private void Download (TUserInfo user) {
			bool fDebug=false;
#if DEBUG
			fDebug = true;
#endif
			txtbxID.Visible = fDebug;
			txtbxID.Text = user.ID.ToString();
			txtbxFirst.Text = user.First;
			txtbxLast.Text = user.Last;
			txtbxUsername.Text = user.Username;
			txtbxPassword.Text = user.Password;
			cboxActive.Checked = user.IsActive;
		}
//-----------------------------------------------------------------------------
		private void Upload (TUserInfo user) {
			user.ID = TMisc.ToIntDef (txtbxID.Text);
			user.First = txtbxFirst.Text;
			user.Last = txtbxLast.Text;
			user.Username = txtbxUsername.Text;
			user.Password = txtbxPassword.Text;
			user.IsActive = cboxActive.Checked;
		}
//-----------------------------------------------------------------------------
	}
}
