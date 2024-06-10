/*****************************************************************************\
|
\*****************************************************************************/

using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------
using System.Collections;
//-----------------------------------------------------------------------------
namespace RTCM {
	public class TStringInt {
		private int m_id;
		private string m_str;
		public int IntVal {get{return(m_id);}set{m_id=value;}}
		public string StrVal {get{return(m_str);}set{m_str=value;}}
//-----------------------------------------------------------------------------
		public TStringInt(int id=0, string str="") {
			Clear(id, str);
		}
//-----------------------------------------------------------------------------
		public TStringInt (TStringInt other) {
			AssignAll (other);
		}
//-----------------------------------------------------------------------------
		public void Clear(int id, string str) {
			IntVal = id;
			StrVal = str;
		}
//-----------------------------------------------------------------------------
		public void AssignAll (TStringInt other) {
			Clear (other.IntVal, other.StrVal);
		}
//-----------------------------------------------------------------------------
		public bool LoadFromReader (MySqlDataReader reader, string strFldID, string strFldStr, ref string strErr) {
			bool fLoad = false;

			try {
				fLoad = true;
				IntVal   = TMisc.ReadIntField(reader, strFldID);// reader[ID] as int? ?? 0;
				StrVal   = reader[strFldStr] as string;
			}
			catch (Exception ex) {
				strErr = ex.Message;
				fLoad = false;
			}
			return (fLoad);
		}
//-----------------------------------------------------------------------------
		public override string ToString () {
			return (StrVal);
		}
	}
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	public class TStrnigsInts {
		private TStringInt[] m_aValues;
		private string m_strTable="";
		private string m_strFldID="";
		private string m_strFldStr="";
		private string m_strErr;
		public string Table {get{return(m_strTable);}}
		public string FieldID {get{return(m_strFldID);}}
		public string FieldStr {get{return(m_strFldStr);}}
		public string ErrorString {get{return(m_strErr);}}
		public TStringInt[] Values {get{return(m_aValues);}set{m_aValues=value;}}
//-----------------------------------------------------------------------------
		public TStrnigsInts (string strTable, string strID, string strStr) {
			Values = null;
			m_strTable = strTable;
			m_strFldID = strID;
			m_strFldStr = strStr;
		}
//-----------------------------------------------------------------------------
		public bool LoadAll (MySqlCommand cmd, ref string strErr) {
			bool fLoad;
			MySqlDataReader reader=null;
			ArrayList al = new ArrayList();
			TStringInt si = new TStringInt();

			try {
				//string strSql = String.Format ("select {0},{1} from {2};", m_strFldID, m_strFldStr, m_strTable);
				cmd.CommandText = String.Format ("select {0},{1} from {2};", m_strFldID, m_strFldStr, m_strTable);
				reader = cmd.ExecuteReader ();
				while (reader.Read ()) {
					if (si.LoadFromReader (reader, m_strFldID, m_strFldStr, ref strErr))
						al.Add (new TStringInt (si));
				}
				Values = ArrayListToArray (al);//(TStringInt[]) al.ToArray ();
				fLoad = true;
			}
			catch (Exception e) {
				strErr = e.Message;
				fLoad = false;
			}
			finally {
				if (reader != null)
					reader.Close();
			}
			return (fLoad);
		}
//-----------------------------------------------------------------------------
		private TStringInt[] ArrayListToArray (ArrayList al) {
			TStringInt[] arr = null;
			if (al != null) {
				if (al.Count > 0) {
					arr = new TStringInt[al.Count];
					for (int n=0 ; n < al.Count ; n++)
						arr[n] = new TStringInt ((TStringInt) al[n]);
				}
			}
			return (arr);
		}

//-----------------------------------------------------------------------------
	}
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	public class TLevels : TStrnigsInts {
		public TLevels () : base ("user_level", "level_id", "level_name") {}
	}
}
