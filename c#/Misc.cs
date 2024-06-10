/*****************************************************************************\
|                                  misc.cs                                    |
\*****************************************************************************/
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCM {
	public class TMisc {
		private string m_strErr;
		public string ErrorString {get{return(m_strErr);}}
//-----------------------------------------------------------------------------
		public static int ToIntDef (string strValue, int nDef=0) {
			int nValue=0;
			try {
				if (strValue != null)
					nValue = Convert.ToInt32(strValue);
			}
			catch (Exception e) {
				//m_strErr = e.Message;
				nValue = nDef;
			}
			return (nValue);
		}
//-----------------------------------------------------------------------------
		public static bool GetFieldMax (MySqlCommand cmd, string table, string field, ref  int nValue, ref string strErr) {
			bool fID;
			MySqlDataReader reader = null;
			try {
				string strSql = String.Format ("select max({0}) from {1}", field, table);
				cmd.CommandText = strSql;
				reader = cmd.ExecuteReader ();
				if (reader.Read()) {
					nValue = reader.GetInt32 (0);
				}
				fID = true;
			}
			catch (Exception ex) {
				fID = false;
				strErr = ex.Message;
				nValue = 0;
			}
			finally {
				if (reader != null)
					reader.Close();
			}
			return (fID);
		}
//-----------------------------------------------------------------------------
		public static string GetDBUpdateValue (string strValue) {
			string strDB;

			if (strValue.Trim().Length > 0)
				strDB = String.Format("'{0}'", strValue);
			else
				strDB = "null";
			return (strDB);
		}
//-----------------------------------------------------------------------------
		public static string GetDBUpdateValue (int nValue) {
			string strDB;

			if (nValue > 0)
				strDB = nValue.ToString();
			else
				strDB = "null";
			return (strDB);
		}
//-----------------------------------------------------------------------------
		public static string GetDBUpdateValue (bool fValue) {
			int nValue = fValue ? 1 : 0;
			string strDB = nValue.ToString();
			return (strDB);
		}
//-----------------------------------------------------------------------------
		public static int ReadIntField (MySqlDataReader reader, string strField, int nDef=0) {
			int nValue = 0;
			try {
				int nCol = reader.GetOrdinal(strField);
				if (!reader.IsDBNull(nCol))
					nValue = reader.GetInt32 (strField);
			}
			catch (Exception ex) {
				nValue = nDef;
			}
			return (nValue);
		}
//-----------------------------------------------------------------------------
	}
}
