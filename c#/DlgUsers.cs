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
			Download (database);
			ShowDialog();
			return (true);
		}
//-----------------------------------------------------------------------------
		private void btnOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
//-----------------------------------------------------------------------------
		private void Download (MySqlConnection database) {
			ArrayList aUsers = new ArrayList();
			m_database = database;
			m_cmd = new MySqlCommand();
			m_cmd.Connection = m_database;
			if (TUserInfo.LoadUsers(m_cmd, aUsers, ref m_strErr))
				DownloadUsers (aUsers);
		}
//-----------------------------------------------------------------------------
		private void DownloadUsers (ArrayList aUsers) {
			gridUsers.RowCount = aUsers.Count;
			for (int n=0 ; n < aUsers.Count; n++)
				DownloadUserRow (n, (TUserInfo) aUsers[n]);
		}
//-----------------------------------------------------------------------------
		private void DownloadUserRow (int row, TUserInfo user) {
			gridUsers.Rows[row].Cells[0].Value = user.GetFullName();
			gridUsers.Rows[row].Cells[1].Value = user.Username;
			gridUsers.Rows[row].Cells[2].Value = user.Level;
			gridUsers.Rows[row].Cells[3].Value = user.IsActive ? "Active" : "Not Active";
		}
//-----------------------------------------------------------------------------
	}
}
