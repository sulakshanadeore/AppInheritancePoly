using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Products
    {
		private int _prodid;

		public int ProductID
		{
			get { return _prodid; }
			set { _prodid = value; }
		}


		private string _prodname;

		public string ProductName
		{
			get { return _prodname; }
			set { _prodname = value; }
		}

		private decimal _price;

		public decimal Price
		{
			get { return _price; }
			set { _price = value; }
		}

		private string _uom;

		public string UnitOfMeasurement
		{
			get { return _uom; }
			set { _uom = value; }
		}

		private float _qty;

		public float Quantity
		{
			get { return _qty; }
			set { _qty = value; }
		}

		public decimal CalculateTotalPurchase()
		{
			decimal total = Price *Convert.ToDecimal(Quantity);
			return total;
		
		}


	}
}
