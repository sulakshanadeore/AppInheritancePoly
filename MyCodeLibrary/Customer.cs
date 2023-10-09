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


		//Dr/Mr/Mrs/Ar/Vd
		private string _title;

		protected internal string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private static int _bankAcno;

		static internal  int Acno
		{
			get { return _bankAcno; }
			set { _bankAcno = value; }
		}






	}
}
