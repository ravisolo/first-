using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assinment3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine(" Enter a : ");
             a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter b : ");
             b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter c : ");
             c = Convert.ToDouble(Console.ReadLine());

            if (((b * b) - 4 * a * c) > 0)
            {
                
                double r1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / 2 * a;
                double r2 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / 2 * a;
               
                Console.WriteLine("the equation has two roots : {0:F5} and {1:F5}",r1,r2);
            }
            if (((b * b) - 4 * a * c) == 0)
            {
                double root = -b / (2 * a);
                Math.Round(root,4);
                Console.WriteLine("the equation has one root : {0:F5}",root);
            }
             if (((b * b) - 4 * a * c) < 0)
             {
                 Console.WriteLine("the equation has no real roots");
             }
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("");



             Console.WriteLine("Enter the exchange rate from dollers to yuan :");
             double rate = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Enter 0 to convert from dollers or 1 for the vice versa :");
             int decision = Convert.ToInt32(Console.ReadLine());
             if (decision == 0)
             {
                 Console.WriteLine("Enter the dollar amount :");
                 double amount = Convert.ToDouble(Console.ReadLine());
                 double result = rate * amount;
                 Console.WriteLine("{0:c} is {1:F2} yuan",amount,result);
             }
             else if (decision == 1)
             {
                 Console.WriteLine("Enter the yuan amount :");
                 double amount = Convert.ToDouble(Console.ReadLine());
                 double result = amount / rate;
                 Console.WriteLine("{0:F2} yuan is {1:c} ",amount,result);
             }
             else
                 Console.WriteLine("invalid option");

             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("");
             Console.WriteLine("");

             Console.WriteLine(" Enter an integer :");
             int i = Convert.ToInt32(Console.ReadLine());
            if(i%5==0 || i%7==0)
            {
                Console.WriteLine("{0} is divisible by eaither 5 or 7",i);
            }
            if(i%5==0 && i%7==0)
                {
                    Console.WriteLine("{0} is divisible by 5 and 7 ",i);
                }
            if (i % 5 == 0 ^ i % 7 == 0)
            {
                Console.WriteLine("{0} is divisible by either 5 or 7, but not both");

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Random generator = new Random();
            int randomNumber = generator.Next(11);
            switch (randomNumber)
            {
                case 0:
                    Console.WriteLine("January");break;
                case 1:
                    Console.WriteLine("february"); break;
                case 2:
                    Console.WriteLine("march"); break;
                case 3:
                    Console.WriteLine("April"); break;
                case 4:
                    Console.WriteLine("May"); break;
                case 5:
                    Console.WriteLine("June"); break;
                case 6:
                    Console.WriteLine("July"); break;
                case 7:
                    Console.WriteLine("August"); break;
                case 8:
                    Console.WriteLine("September"); break;
                case 9:
                    Console.WriteLine("Octomber"); break;
                case 10:
                    Console.WriteLine("November"); break;
                case 11:
                    Console.WriteLine("december"); break;
                default:
                    Console.WriteLine("number not lies between 0-11"); break;
            }
            



           


        }
    }
}
