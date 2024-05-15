/*****************************************************************************\
|                                  main.cs                                    |
\*****************************************************************************/


/*
 root, Omer!071957 
 RotemRadAdmin, RotemRad2024
*/
using MySql.Data;
using MySql.Data.MySqlClient;


using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RTCM {
	public partial class main : Form {
		private MySqlConnection m_database;
		public main() {
			InitializeComponent();
			m_database = null;
		}

		private void miExit_Click(object sender, EventArgs e) {
			Close();
		}

		private void button1_Click(object sender, EventArgs e) {
			if (m_database == null) {
				string strConn = string.Format("Server='{0}'; database='{1}'; UID='{2}'; password='{3}'", "127.0.0.1", "RTCM", "RotemRadAdmin", "RotemRad2024");
				m_database = new MySqlConnection(strConn);
				try {
					m_database.Open();
					MessageBox.Show("Connected");
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void main_FormClosed(object sender, FormClosedEventArgs e) {
			if (m_database != null) {
				if (m_database.State == System.Data.ConnectionState.Open)
					m_database.Close();
			}
		}
	}
}
