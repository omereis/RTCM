/*****************************************************************************\
|
\*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	public class TStrnigsInts {
		private TStringInt[] m_aValues;
		public TStringInt[] Values {get{return(m_aValues);}set{m_aValues=value;}}
//-----------------------------------------------------------------------------
		public TStrnigsInts () {
			Values = null;
		}
	}
}
