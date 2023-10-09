using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    internal interface IBankAccount
    {
        //declarations are only accepted
        //variables and any type implementation is not allowed
       //  int IFSC { get; set; }//Auto Implemented Property
        void Deposit(int acno, decimal amt);
        void Withdraw(int acno, decimal amt);

        void Transfer(int ToAcno,int FromAcno,decimal amt);

        void CheckBalance();
            }

    public class Account
    {
        //auto implemneted properties---AIP
        public int Acno { get; set; }
        public decimal Bal { get; set; }


    }


    class SavingAccount :Account, IBankAccount
    {
        public void CheckBalance()
        {
            //throw new NotImplementedException();
            Console.WriteLine(base.Bal);
        }

        public void Deposit(int acno, decimal amt)
        {
            //throw new NotImplementedException();
            base.Bal=base.Bal + amt;
            Console.WriteLine("Total balanace= " + base.Bal);
        }

        public void Transfer(int ToAcno, int FromAcno, decimal amt)
        {
            //throw new NotImplementedException();
            Console.WriteLine(  "Facility not available....");
        }

        public void Withdraw(int acno, decimal amt)
        {
            //   throw new NotImplementedException();
            base.Bal = base.Bal - amt;
            Console.WriteLine("Total balanace= " + base.Bal);
        }
    }

    class CurrentAccount : Account, IBankAccount
    {
        public void CheckBalance()
        {
            //throw new NotImplementedException();
            Console.WriteLine(base.Bal);
        }

        public void Deposit(int acno, decimal amt)
        {
            //throw new NotImplementedException();
            base.Bal = base.Bal + amt;
            Console.WriteLine("Total balanace= " + base.Bal);
        }

        public void Transfer(int ToAcno, int FromAcno, decimal amt)
        {
            //        throw new NotImplementedException();
            Account sender = new Account();
            Account receiver = new Account();
            sender.Acno=FromAcno;
            receiver.Acno = ToAcno;
            sender.Bal = sender.Bal - amt;
            receiver.Bal = receiver.Bal + amt;
            Console.WriteLine("After transfer sender has " + sender.Bal);

            Console.WriteLine("After transfer receiver has " + receiver.Bal);



        }

        public void Withdraw(int acno, decimal amt)
        {
            //throw new NotImplementedException();
            base.Bal = base.Bal - amt;
            Console.WriteLine("Total balanace= " + base.Bal);
        }
    }


}
