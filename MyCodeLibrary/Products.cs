using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Validating the data (in the properties), transfer the data(using properties) from one app to another app
//Business Logic Layer--->
namespace MyCodeLibrary
{
    public class Products
    {
		private int _prodid;

		//business rule
		public int ProductID
		{
			get { return _prodid; }
			set 
			{
				if (value > 0)
				{
					_prodid = value;
				}
				else
				{
                    Console.WriteLine(	"Product id not valid");
                }
			}
		}


		private string _prodname;

		public string ProductName
		{
			get { return _prodname; }
			set
			{
				if (value.Length > 0 && value.Length < 20)
				{
					_prodname = value;
				}
                else
                {
                    Console.WriteLine("Product name too long or too small.. Not valid");
                }

            }
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

		public decimal CalculateTotalPurchase(float qty,decimal price)
		{
			decimal total = price *Convert.ToDecimal(qty);
			return total;
		
		}


	}
}
