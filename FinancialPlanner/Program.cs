using System;
using System.Collections.Generic;
using System.Linq;

namespace FinancialPlanner
{
    class Program
    {

            // This is my financial calculator. This program is designed to take in all of your income and expenditures and
            // then work out how much money you have left for the month/week. 
        static void Main(string[] args)
        {

            // Here i have created 2 lists to store the values of 1) bill names and 2) the price of those bills
            
            List<string>  billNames = new List<string>();
            List<double>  billCosts = new List<double>();
            
            // This is the introduction to the program 

            Console.WriteLine("Hello welcome to the financial calculator. please press any key to continue..");
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();

            Console.Write("Please enter your monthly pay: £");
            var monthlyPay = Convert.ToDouble(Console.ReadLine());
            Console.Clear();


            Console.Write("Please name a Bill: ");
            billNames.Add(Console.ReadLine());
            Console.Clear();

            Console.Write("And now how much is that Bill? £");
            billCosts.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Clear();

            // This while loop is the main interaction of the program for the user. It takes in all of the information
            // that they are inputting and stores it in the lists. 

            while (true)
            {


                Console.Write("Would you like to name another bill? (y/n) ");

                string anotherTransaction = Console.ReadLine();
                Console.Clear();


                if (anotherTransaction == "y")
                {
                    Console.Write("Please enter another transaction: "); // i need to validate that the input is a name of a bill and not a number
                    billNames.Add(Console.ReadLine());
                    Console.Clear();
                    Console.Write("And now how much is that transaction? £");   // I need to validate that the input is numerical 
                    billCosts.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.Clear();


                }
                else if(anotherTransaction == "n")
                {
                    Console.WriteLine("All Bills: ");
                    break;
                    
                }
                else
                {
                    continue;
                }
                


            }
                for (int i = 0; i < billNames.Count; i++)
                {

                     Console.WriteLine(i + 1 + ". " + billNames[i] + " " + billCosts[i]);

                }

            // This here is adding up all of the cost of the bills. 

            double sumOfBills = billCosts.AsQueryable().Sum();
            Console.WriteLine("Total Cost of bills: " + sumOfBills);
            double monthlybudget = monthlyPay - sumOfBills;
            Console.WriteLine("Monthly budget is: " + monthlybudget);
            double weeklyBudget = (monthlybudget * 12) / 52;
            Console.WriteLine("Weekly budget: " + weeklyBudget);


            Console.ReadKey();
        }
        
        
    }
}
