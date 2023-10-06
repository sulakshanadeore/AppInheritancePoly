using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
	//enum is  a named constant
	public enum PaymentMode
	{
        cash, 
		upi,
		debit, 
		credit,
		netbanking
    }

    public class Orders:Customer
    {
		private int _orderid;

		public int OrderID
		{
			get { return _orderid; }
			set { _orderid = value; }
		}
		private DateTime _orderdate;

		public DateTime OrderDate
		{
			get { return _orderdate; }
			set { _orderdate = value; }
		}

		private PaymentMode _paymode;

		public PaymentMode GetPaymentMode
		{
			get { return _paymode; }
			set { _paymode = value; }
		}


		public void BookOrder(int custid,DateTime orderdate,PaymentMode paymode,float qty,decimal price)
		{
			Console.WriteLine("ORder booked successfully......");
            
			decimal amt=base.CalculateTotalPurchase(qty,price);
            Console.WriteLine($"Order booked for customerid=  {custid} on {orderdate} , payment recieved by {paymode} for a qty of {qty} @ theprice of {price} and the total price ={amt}");


        }



    }
}
