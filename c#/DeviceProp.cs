/*****************************************************************************\
|                                DeviceProp.cs                                |
\*****************************************************************************/
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCM {
	internal class TDeviceProp {
		private int m_id;
		private string m_strName;
//------------------------------------------------------------------------------
		public int ID {get{return(m_id);}set{m_id=value;}}
		public string Name {get{return(m_strName);}set{m_strName=value;}}
//------------------------------------------------------------------------------
		public TDeviceProp () {
			Clear ();
		}
//------------------------------------------------------------------------------
		public TDeviceProp (TDeviceProp other) {
			AssignAll (other);
		}
//------------------------------------------------------------------------------
		public TDeviceProp (int id, string strName) {
			ID = id;
			Name = strName;
		}
//------------------------------------------------------------------------------
		public void Clear () {
			ID   = 0;
			Name = "";
		}
//------------------------------------------------------------------------------
		public void AssignAll (TDeviceProp other) {
			ID   = other.ID;
			Name = other.Name;
		}
//------------------------------------------------------------------------------
	}
}
