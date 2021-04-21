using System;

namespace Water_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerId;
            int consumerUnit;
            double charge, subCharge =0, bill, netAmount;
            string customerName;
            Console.WriteLine("Input Customer ID :");
            customerId= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input the name of the customer :");
             customerName= Console.ReadLine().ToLower();
             Console.WriteLine("Input the unit consumed by the customer : ");
             consumerUnit= Convert.ToInt32(Console.ReadLine());
             if (consumerUnit < 200)
             {
                charge = 1.20;
             }
             else if ((consumerUnit >= 200) && (consumerUnit < 400) )
             {
                 charge = 1.50;
             } 
             else if ((consumerUnit >= 400) && (consumerUnit < 600))
             {
                 charge = 1.80;
             }
			else
			{
                charge = 2.00;
            }
            bill = consumerUnit * charge;
            if (bill < 100)
            {
                Console.WriteLine("Bill cannot be less than 100");
            }
           else if (bill > 300)
           {    
            subCharge = bill * 15/100.0;
            netAmount = bill + subCharge;
            Console.WriteLine("Water Bill");
            Console.WriteLine("Customer Identity NO                  :{0}",customerId);
            Console.WriteLine("Customer Name                       :{0}",customerName);
            Console.WriteLine("unit Consumed                       :{0}",consumerUnit);
            Console.WriteLine("Amount Charges @Rs. {0}  per unit :{1}",charge,bill);
            Console.WriteLine("Subcharge Amount                     :{0}",subCharge);
            Console.WriteLine("Net Amount Paid By the Customer     :{0}",netAmount);
           }
            else
            {
            // netAmount = bill;
            Console.WriteLine("Water Bill");
            Console.WriteLine("Customer Identity NO                  :{0}",customerId);
            Console.WriteLine("Customer Name                       :{0}",customerName);
            Console.WriteLine("unit Consumed                       :{0}",consumerUnit);
            Console.WriteLine("Amount Charges @Rs. {0}  per unit :{1}",charge,bill);
            Console.WriteLine("Subcharge Amount                     :{0}",subCharge);
            // Console.WriteLine("Net Amount Paid By the Customer     :{0}",netAmount);
            } 
        }
    }
}
