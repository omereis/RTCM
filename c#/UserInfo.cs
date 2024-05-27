/*****************************************************************************\
|                                UserInfo.cs                                  |
\*****************************************************************************/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------
using System.Collections;
//-----------------------------------------------------------------------------
using Mysqlx.Crud;
//-----------------------------------------------------------------------------
namespace RTCM {
	public class TUserInfo {
		private int m_id;
		private string m_strFirst;
		private string m_strLast;
		private string m_strUsername;
		private string m_strPassword;
		private string m_strLevel;
		private bool   m_fIsActive;
		public int ID {get{return(m_id);}set{m_id=value;}}
		public string First {get{return(m_strFirst);}set{m_strFirst=value;}}
		public string Last  {get{return(m_strLast);}set{m_strLast=value;}}
		public string Username {get{return(m_strUsername);}set{m_strUsername=value;}}
		public string Password {get{return(m_strPassword);}set{m_strPassword=value;}}
		public string Level {get{return(m_strLevel);}set{m_strLevel=value;}}
		public bool IsActive {get{return(m_fIsActive);}set{m_fIsActive=value;}}
//-----------------------------------------------------------------------------
		public TUserInfo () {
			Clear ();
		}
//-----------------------------------------------------------------------------
		public TUserInfo (TUserInfo other) {
			AssignAll (other);
		}
//-----------------------------------------------------------------------------
		public void Clear () {
			ID       = 0;
			First    = "";
			Last     = ""; 
			Username = "";
			Password = "";
			Level    = "";
			IsActive = false;
		}
//-----------------------------------------------------------------------------
		public void AssignAll (TUserInfo other) {
			ID       = other.ID;
			First    = other.First;
			Last     = other.Last; 
			Username = other.Username;
			Password = other.Password;
			Level    = other.Level;
			IsActive = other.IsActive;
		}
//-----------------------------------------------------------------------------
		public static bool LoadUsers (MySqlCommand cmd, ArrayList aUsers, ref string strErr) {
			return (TUserInfoDB.LoadUsers(cmd, aUsers, ref strErr));
/*
			string strSql = "select * from vUsers;";
			bool fRead=false;
			TUserInfo user = new TUserInfo ();
			cmd.CommandText = strSql;
			//Parameters.Add(strSql);
			MySqlDataReader reader = null;
			try {
				reader = cmd.ExecuteReader ();
				while ((fRead = reader.Read ()) == true) {
					if (user.LoadFromReader (reader, ref strErr))
						aUsers.Add (new TUserInfo (user));
				}
			}
			catch (Exception e) {
				strErr = e.Message;
				fRead = false;
			}
			finally {
				if (reader != null)
					reader.Close ();
			}
			return (fRead);
*/
		}
//-----------------------------------------------------------------------------
		public string GetFullName () {
			return (First + " " + Last);
		}
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	public class TUserInfoDB : TUserInfo {
		private static readonly string View = "vUsers";
		private static readonly string FldUserID = "user_id";
		private static readonly string FldFirst = "first";
		private static readonly string FldLast = "last";
		private static readonly string FldUsername = "username";
		private static readonly string FldPasswd = "passwd";
		private static readonly string FldLevel = "level_name";
		private static readonly string FldIsActive = "is_active";
//-----------------------------------------------------------------------------
		public TUserInfoDB () : base(){
		}
//-----------------------------------------------------------------------------
		public TUserInfoDB (TUserInfo other) : base(other) {
		}
//-----------------------------------------------------------------------------
		public static new bool LoadUsers (MySqlCommand cmd, ArrayList aUsers, ref string strErr) {
			string strSql = String.Format ("select * from {0};", View);
			bool fRead=false;
			TUserInfoDB user = new TUserInfoDB ();
			cmd.CommandText = strSql;
			//Parameters.Add(strSql);
			MySqlDataReader reader = null;
			try {
				reader = cmd.ExecuteReader ();
				while ((fRead = reader.Read ()) == true) {
					if (user.LoadFromReader (reader, ref strErr))
						aUsers.Add (new TUserInfo (user));
				}
				fRead = true;
			}
			catch (Exception e) {
				strErr = e.Message;
				fRead = false;
			}
			finally {
				if (reader != null)
					reader.Close ();
			}
			return (fRead);
		}
//-----------------------------------------------------------------------------
		private bool LoadFromReader (MySqlDataReader reader, ref string strErr) {
			bool fRead = false;

			try {
				Clear ();
				ID       = reader.GetInt32(FldUserID);//"user_id");
				First    = reader.GetString(FldFirst);//"first");
				Last     = reader.GetString(FldLast);//"last");
				Username = reader.GetString(FldUsername);//"username");
				Password = reader.GetString(FldPasswd);//"passwd");
				Level    = reader.GetString(FldLevel);//"level_name");
				IsActive = reader.GetInt32(FldIsActive) > 0 ? true : false;//"is_active") > 0 ? true : false;
				fRead = true;
			}
			catch (Exception e) {
				strErr = e.ToString ();
				fRead = false;
			}
			return(fRead);
		}
	}
	}
}
