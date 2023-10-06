using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public  class Customer:ElectronicProducts
    {
		private int _custid;

		public int CustID
		{
			get { return _custid; }
			set { _custid = value; }
		}
		private string _custname;

		public string Custname
		{
			get { return _custname; }
			set { _custname = value; }
		}


	}
}
