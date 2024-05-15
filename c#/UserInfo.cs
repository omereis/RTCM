/*****************************************************************************\
|                                UserInfo.cs                                  |
\*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCM {
	public class TUserInfo {
		private int m_id;
		private string m_strFirst;
		private string m_strLast;
		private string m_strUsername;
		private string m_strPassword;
		private string m_strLevel;
		public int ID {get{return(m_id);}set{m_id=value;}}
		public string First {get{return(m_strFirst);}set{m_strFirst=value;}}
		public string Last  {get{return(m_strLast);}set{m_strLast=value;}}
		public string Username {get{return(m_strUsername);}set{m_strUsername=value;}}
		public string Password {get{return(m_strPassword);}set{m_strPassword=value;}}
		public string Level {get{return(m_strLevel);}set{m_strLevel=value;}}
		public TUserInfo () {
			Clear ();
		}
		public TUserInfo (TUserInfo other) {
			AssignAll (other);
		}
		public void Clear () {
			ID       = 0;
			First    = "";
			Last     = ""; 
			Username = "";
			Password = "";
			Level    = "";
		}
		public void AssignAll (TUserInfo other) {
			ID       = other.ID;
			First    = other.First;
			Last     = other.Last; 
			Username = other.Username;
			Password = other.Password;
			Level    = other.Level;
		}
	}
}
