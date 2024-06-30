/*****************************************************************************\
|                              DlgDeviceProp.cs                               |
\*****************************************************************************/

using RTCM;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTCM {
	public partial class DlgDeviceProp : Form {
//------------------------------------------------------------------------------
		public DlgDeviceProp() {
			InitializeComponent();
		}
//------------------------------------------------------------------------------
		public bool Execute () {
			Download ();
			bool f = ShowDialog() == DialogResult.OK;
			if (f)
				Upload();
			return (f);
		}
//------------------------------------------------------------------------------
		private void Download () {
		}
//------------------------------------------------------------------------------
		private void Upload() {
		}
//------------------------------------------------------------------------------
	}
}
