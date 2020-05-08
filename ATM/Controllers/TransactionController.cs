using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATM.Models;

namespace ATM.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            var transaction = new Transaction
            {
                Amount = 100
            };

            return View(transaction);
        }

        static void QuickCash(ref int CheckingAccountId, decimal Amount)
        {
            if ( ref decimal Balance > = 100 )
            {
                Amount = Amount - 100;
                Console.WriteLine(Amount);
            } 
            else
            {
                Console.WriteLine("Your Balance is less than $100");
            }
        }



        public double Deposit()
        {
            ref decimal Balance += Amount;
            return Balance;
        }
    }
}