using System;

namespace PrimeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Number");

            //int number = int.Parse(Console.ReadLine());
            //bool IsPrime = true;

            //for (int i = 2; i < number/2; i++)
            //{
            //    if(number % i == 0 )
            //    {
            //        IsPrime = false;
            //        break;
            //    }
            //}
            //if(IsPrime)
            //{
            //    Console.WriteLine("Numder is Prime");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not prime");
            //}

            //Console.ReadKey();

            Console.WriteLine("Enter start number:");
            int startnumber = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Enter end Number");
            int endnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The Prime no between {startnumber} and {endnumber} are :");


            for(int i = startnumber; i<=endnumber; i++)
            {
                int count = 0;
                for(int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i != 1)
                {
                    Console.WriteLine("{0}",i);
                }
            }
            Console.ReadKey();
        }
    }
}
