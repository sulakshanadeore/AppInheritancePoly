using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class ElectronicProducts:Products
    {
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

		public decimal CalculateDiscount()
		{
			decimal afterDiscountPrice = 0;
			decimal amt=base.CalculateTotalPurchase();
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
