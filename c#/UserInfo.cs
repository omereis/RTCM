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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
//-----------------------------------------------------------------------------
namespace RTCM {
	public class TUserInfo {
		private int m_id;
		private string m_strFirst;
		private string m_strLast;
		private string m_strUsername;
		private string m_strPassword;
		private string m_strLevel;
		protected int m_idLevel;
		private bool   m_fIsActive;
		public int ID {get{return(m_id);}set{m_id=value;}}
		public string First {get{return(m_strFirst);}set{m_strFirst=value;}}
		public string Last  {get{return(m_strLast);}set{m_strLast=value;}}
		public string Username {get{return(m_strUsername);}set{m_strUsername=value;}}
		public string Password {get{return(m_strPassword);}set{m_strPassword=value;}}
		public string Level {get{return(m_strLevel);}set{m_strLevel=value;}}
		public int LevelID {get{return(m_idLevel);}set{m_idLevel=value;}}
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
			m_idLevel = 0;
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
			LevelID  = other.LevelID;
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
			string strFullName = (First + " " + Last);
			if (strFullName.Trim().Length == 0 )
				strFullName = Username;
			return (strFullName);
		}
//-----------------------------------------------------------------------------
		public bool InsertyAsNew (MySqlCommand cmd, ref string strErr) {
			TUserInfoDB userDB = new TUserInfoDB();
			bool fInsert = userDB.InsertyAsNew (cmd, ref strErr);
			if (fInsert)
				AssignAll (userDB);
			return (fInsert);
		}
//-----------------------------------------------------------------------------
		public bool UpdateInDB (MySqlCommand cmd, ref string strErr) {
			TUserInfoDB userDB = new TUserInfoDB(this);
			bool fUpdate = userDB.UpdateInDB (cmd, ref strErr);
			return (fUpdate);
		}
//-----------------------------------------------------------------------------
		public bool DeleteFromDB (MySqlCommand cmd, ref string strErr) {
			TUserInfoDB userDB = new TUserInfoDB(this);
			bool fDel = userDB.DeleteFromDB (cmd, ref strErr);
			return (fDel);
		}
//-----------------------------------------------------------------------------
		public bool LoadFromDBByID (MySqlCommand cmd, ref string strErr) {
			TUserInfoDB userDB = new TUserInfoDB(this);
			bool fLoad = userDB.LoadFromDBByID (cmd, ref strErr);
			if (fLoad)
				AssignAll (userDB);
			return (fLoad);
		}
	}

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	public class TUserInfoDB : TUserInfo {
		private static readonly string View = "vUsers";
		private static readonly string Table = "users";
		private static readonly string FldUserID = "user_id";
		private static readonly string FldFirst = "first";
		private static readonly string FldLast = "last";
		private static readonly string FldUsername = "username";
		private static readonly string FldPasswd = "passwd";
		private static readonly string FldLevel = "level_name";
		private static readonly string FldLevelID = "level_id";
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
				ID       = TMisc.ReadIntField(reader, FldUserID);// reader[ID] as int? ?? 0;
				First    = reader[FldFirst] as string;
				Last     = reader[FldLast] as string;
				Username = reader[FldUsername] as string;
				Password = reader[FldPasswd] as string;
				Level    = reader[FldLevel] as string;
				string str = reader[FldLevelID] as string;
				m_idLevel = TMisc.ToIntDef (str, 0);
				int nActive = TMisc.ReadIntField(reader, FldIsActive);
				IsActive = nActive == 1 ? true : false;
				fRead = true;
			}
			catch (Exception e) {
				strErr = e.ToString ();
				fRead = false;
			}
			return(fRead);
		}
//-----------------------------------------------------------------------------
		public new bool InsertyAsNew (MySqlCommand cmd, ref string strErr) {
			int idNew=0;
			bool fInsert=false;

			try {
				if (TMisc.GetFieldMax (cmd, Table, FldUserID, ref idNew, ref strErr)) {
					idNew += 1;
					string strUser = String.Format("user{0}", idNew);
					string strSql = String.Format("insert into {0} ({1},{2}) values ({3}, {4});",
														Table, FldUserID, FldUsername, idNew, TMisc.GetDBUpdateValue(strUser));
					cmd.CommandText = strSql;
					if ((fInsert = cmd.ExecuteNonQuery() > 0) == true) {
						ID = idNew;
						Username = strUser;
					}
				}
			}
			catch (Exception e) {
				strErr = e.ToString ();
				fInsert = false;
			}
			return(fInsert);
		}
//-----------------------------------------------------------------------------
		public new bool UpdateInDB (MySqlCommand cmd, ref string strErr) {
			bool fUpdate =false;

			try { // 7193 - david, 8425 - roy
				string strSql = String.Format("update {0} set " +
														"{1}={2}," + // first
														"{3}={4}," + // last
														"{3}={4}," + // username
														"{5}={6}," + // passwword
														"{7}={8}," + // level
														"{9}={10}," + // Is Active
														"{11}={12}" + // Is Active
											" where {13}={14};",
							Table,
							FldFirst, TMisc.GetDBUpdateValue (First),
							FldLast, TMisc.GetDBUpdateValue (Last),
							FldUsername, TMisc.GetDBUpdateValue (Username),
							FldPasswd, TMisc.GetDBUpdateValue (Password),
							FldLevelID, TMisc.GetDBUpdateValue (m_idLevel),
							FldIsActive, TMisc.GetDBUpdateValue (IsActive),
							FldUserID, ID);
					cmd.CommandText = strSql;
					fUpdate = cmd.ExecuteNonQuery() > 0;
			}
			catch (Exception e) {
				strErr = e.ToString ();
				fUpdate = false;
			}
			return(fUpdate);
		}
//-----------------------------------------------------------------------------
		public new bool DeleteFromDB (MySqlCommand cmd, ref string strErr) {
			bool fDel =false;
			try {
				string strSql = String.Format ("delete from {0} where {1}={2}",
											Table, FldUserID, ID);
				cmd.CommandText = strSql;
				fDel = cmd.ExecuteNonQuery() > 0;
			}
			catch (Exception e) {
				strErr = e.ToString ();
				fDel = false;
			}
			return(fDel);
		}
//-----------------------------------------------------------------------------
		public new bool LoadFromDBByID (MySqlCommand cmd, ref string strErr) {
			bool fLoad =false;
			MySqlDataReader reader = null;
			try {
				string strSql = String.Format ("select * from {0} where {1}={2}",
											View, FldUserID, ID);
				cmd.CommandText = strSql;
				reader = cmd.ExecuteReader ();
				if ((fLoad = reader.Read ()) == true) {
					fLoad = LoadFromReader (reader, ref strErr);
				}
			}
			catch (Exception e) {
				strErr = e.ToString ();
				fLoad = false;
			}
			finally {
				if (reader != null)
					reader.Close();
			}
			return(fLoad);
		}
//-----------------------------------------------------------------------------
	}
}
