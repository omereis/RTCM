/*****************************************************************************\
|                               DlgDeviceType.cs                              |
\*****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------------------------------------------------------------------------------
namespace RTCM {
	public partial class DlgDeviceType : Form {
		public DlgDeviceType() {
			InitializeComponent();
		}
		//------------------------------------------------------------------------------
		public bool Execute() {
			bool fEdit;

			Download();
			fEdit = ShowDialog() == DialogResult.OK;
			if (fEdit)
				Upload();
			return (fEdit);
		}
		//------------------------------------------------------------------------------
		private void Download() {
		}
		//------------------------------------------------------------------------------
		private void Upload() {
		}
		//------------------------------------------------------------------------------
		private void btnOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
		//------------------------------------------------------------------------------
		private void btnPicClear_Click(object sender, EventArgs e) {
			picbx.Image = null;
		}
		//------------------------------------------------------------------------------
		private void btnPicLoad_Click(object sender, EventArgs e) {
			if (dlgOpenPic.ShowDialog() == DialogResult.OK) {
				try {
					picbx.Image = Image.FromFile(dlgOpenPic.FileName);
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}
//------------------------------------------------------------------------------
		private void btnPropAdd_Click(object sender, EventArgs e) {
			DlgDeviceProp dlg = new DlgDeviceProp();
			dlg.Execute();
		}
//------------------------------------------------------------------------------
	}
}
