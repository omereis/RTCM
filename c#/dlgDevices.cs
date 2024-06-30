/*****************************************************************************\
|                                dlgDevices.cs                                |
\*****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------------------------------------------------------------------------------
using MySql.Data.MySqlClient;
//------------------------------------------------------------------------------
namespace RTCM {
	public partial class dlgDevices : Form {
		private MySqlCommand m_cmd;
//------------------------------------------------------------------------------
		public dlgDevices() {
			InitializeComponent();
		}
//------------------------------------------------------------------------------
		public bool Execute(MySqlConnection database) {
			bool fEdit;

			Download(database);
			fEdit = ShowDialog() == DialogResult.OK;
			if (fEdit)
				Upload();
			return (fEdit);
		}
//------------------------------------------------------------------------------
		private void Download(MySqlConnection database) {
			m_cmd = new MySqlCommand();
			m_cmd.Connection = database;
		}
//------------------------------------------------------------------------------
		private void Upload() {
		}
//------------------------------------------------------------------------------
		private void btnOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
//------------------------------------------------------------------------------
		private void btnAdd_Click(object sender, EventArgs e) {
			DlgDeviceType dlg = new DlgDeviceType();
			dlg.Execute();
		}
	}
}
