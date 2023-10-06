using System;
using MyCodeLibrary;

//3 add the using of the namespace(MyCodeLibrary)

namespace AppInheritancePoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cacli();

            //SimpleExampleInheritance();
            ElectronicProducts ep = new ElectronicProducts();
            Console.WriteLine( "Enter Productid ");
            ep.ProductID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Entr price");
            ep.Price=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter qty");
            ep.Quantity=Convert.ToSingle(Console.ReadLine());
            Customer c=new Customer();
            Console.WriteLine(  "enter custid");
            c.CustID = Convert.ToInt32(Console.ReadLine());

            Orders o=new Orders();
            Console.WriteLine("Enter date ");
            o.OrderDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(  "Payment mode");
            o.GetPaymentMode =(PaymentMode) Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You selected the payment mode= {o.GetPaymentMode}");
            
            o.BookOrder(c.CustID, o.OrderDate, o.GetPaymentMode, ep.Quantity, ep.Price);
                      
            Console.ReadLine();


















        }

        private static void SimpleExampleInheritance()
        {
            ElectronicProducts p = new ElectronicProducts();
            Console.WriteLine("Enter product id");
            p.ProductID = Convert.ToInt32(Console.ReadLine());
            //int prodid = Convert.ToInt32(Console.ReadLine());
            //p.ProductID = prodid;

            Console.WriteLine("Enter product name");
            p.ProductName = Console.ReadLine();


            Console.WriteLine("Enter Unit Of Measurement");
            p.UnitOfMeasurement = Console.ReadLine();

            Console.WriteLine("Entr Price");
            p.Price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Qty");
            p.Quantity = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Watt");
            p.Watt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Manufacturing date");
            p.ManufactureDate = Convert.ToDateTime(Console.ReadLine());


            decimal amt = p.CalculateTotalPurchase(p.Quantity,p.Price);
            Console.WriteLine($"The total amt for {p.Quantity} at a price of {p.Price} = Rs. {amt} ");

            Console.WriteLine("-----------------------------");
            decimal orderValue = p.CalculateDiscount();
            Console.WriteLine($"The order value after discount= Rs. {orderValue}");
        }

        private static void Cacli()
        {
            //switch case
            Maths m = new Maths();
            Console.WriteLine("Enter the value for number 1");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for number 2");
            int no2 = Convert.ToInt32(Console.ReadLine());

            int additionAns = m.Addition(no1, no2);//no1,no2---Actual Parameters

            Console.WriteLine(additionAns);

            int subAns = m.subtraction(no1, no2);
            Console.WriteLine(subAns);

            int multans = m.multiply(no1, no2);
            Console.WriteLine(multans);

            double sqrtAns = m.SquareRootOfNumber(no1);
            Console.WriteLine(sqrtAns);
        }
    }
}
