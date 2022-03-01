using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class LogicalPrograms
    {

        int i;
        int number;


        /// <summary>
        /// THIS PROGRAM IS FOR FIBONACCI SERIES
        /// </summary>
        public void FibonacciSeries()
        {
            int n1 = 0;
            int n2 = 1;
            int n3;

            Console.Write(" Enter Number of Element: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

            }
        }
        /// <summary>
        /// THIS PROGRAM IS FOR PERFECT NUMBER 
        /// </summary>
        public void PerfectNumber()
        {

            int sum = 0, n;
            Console.Write("enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(" Entered number is a perfect number");

            }
            else
            {
                Console.WriteLine(" Entered number is not a perfect number");

            }
        }

        /// <summary>
        /// THIS PROGRAM IS FOR REVERSEN NUMBER
        /// </summary>
        public void ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }

        public void PrimeNumber() 
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }

        public void CouponNumber() 
        {
            List<int> coupons = new List<int>();
            Random rand = new Random();
            int randomInput;
            int n;

            Console.WriteLine("Enter A Number : ");
            n=Convert.ToInt32(Console.ReadLine());
            while (coupons.Count < n)
            {
                randomInput = rand.Next(1, n + 1);
                if (coupons.Contains(randomInput) is false)
                    coupons.Add(randomInput);
            }
            Console.WriteLine("Coupons Generated:");
            foreach (int coupon in coupons)
                Console.Write(coupon + " ");


        }
    }

   
    
}
       
    

