/*****************************************************************************\
|                                 Device.cs                                   |
\*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCM {
	internal class TDeviceType {
		private int m_id;
		private string m_strName;
		private TDeviceProp[] m_aProps;
		public int ID {get{return(m_id);}set{m_id=value;}}
		public string Name {get{return(m_strName);}set{m_strName=value;}}
		public TDeviceProp[] Properties {get{return(m_aProps);}set{m_aProps=value;}}
//------------------------------------------------------------------------------
		public TDeviceType() {
			Clear ();
		}
//------------------------------------------------------------------------------
		public TDeviceType (TDeviceType other) {
			AssignAll (other);
		}
//------------------------------------------------------------------------------
		public void Clear () {
			ID   = 0;
			Name = "";
			m_aProps = null;
		}
//------------------------------------------------------------------------------
		public void AssignAll (TDeviceType other) {
			ID   = other.ID;
			Name = other.Name;
			if (other.Properties != null)
				Properties = (TDeviceProp[]) other.Properties.Clone();
			else
				Properties = null;
		}
//------------------------------------------------------------------------------
	}
}
