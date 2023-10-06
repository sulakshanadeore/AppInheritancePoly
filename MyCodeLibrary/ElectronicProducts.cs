using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
	//Single level
    public class ElectronicProducts:Products
    {


		private int _pid;

		public int prodid
		{
			get { return base.ProductID; }
			set { 
				_pid = value; 
				base.ProductID = _pid;	
			}
		}


		private float _q;

		public float Q
		{
			get { return base.Quantity; }
			set { _q = value;
				base.Quantity = _q;
			}
		}

		private decimal _p; 

		public decimal P
		{
			get { return base.Price; }
			set { _p = value;
			base.Price= _p;	
			}
		}





		private DateTime _mfgDate;


		public DateTime ManufactureDate
		{
			get { return _mfgDate; }
			set { _mfgDate = value; }
		}

		private int _watt;

		public int Watt
		{
			get { return _watt; }
			set { _watt = value; }
		}

		//public void CallBaseClass(int proid,float qty,decimal price)
		//{
		//	base.ProductID = proid;
		//	base.Quantity = qty;	
		//	base.Price = price;

		
		//}



		public decimal CalculateDiscount()
		{
			decimal afterDiscountPrice = 0;
			float qty = base.Quantity;
			decimal price = base.Price;
			decimal amt=base.CalculateTotalPurchase(qty,price);
			if (amt > 1000 && amt < 5000)
			{
				decimal discount = amt * Convert.ToDecimal(0.2);
				afterDiscountPrice = amt - discount;
			}
			else if (amt > 5000 && amt < 10000)
			{
				decimal discount = amt * Convert.ToDecimal(0.5);
				afterDiscountPrice = amt - discount;

			}
			else
			{ 
			afterDiscountPrice = amt;
			}
			return afterDiscountPrice;
		}



	}
}
