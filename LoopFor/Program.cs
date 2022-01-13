using System;

namespace LoopFor
{
    class Program
    {

        static void Main(string[] args)
        {
            ////FoR lOOP(Print 10 number)

            //for (int i = 0; i < 10 ; i++)
            //{
            //    Console.WriteLine("Print number : {0}",i);
            //}

            ////INFINITE fOR lOOP

            //for (; ; )
            //    Console.WriteLine(1);


            ////To print even and odd Number
            //int i = 0;

            //Console.WriteLine("Even No is :");
            //for (i =1; i<=30; i++)
            //{


            //    if(i % 2 == 0)
            //    {
            //        Console.Write(i +",");
            //    }



            //}

            //Console.WriteLine("\n Odd No. is:");

            //for ( i = 1; i < 30; i++)
            //{

            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + ",");
            //    }
            //}

            //Console.WriteLine();

            ////decimal value for loop

            //for(double n = 1.01d; n<1.10; n+= 0.01d )
            //{
            //    Console.WriteLine("Value of n is: {0}",n);
            //}


            ////while loop

            //int i = 0;

            //while (i > 10)
            //{
            //    Console.WriteLine("i= {0}", i);

            //    i++;
            //}

            ////Infinite loop
            //int i = 1;

            //while (i > 0)
            //{
            //    Console.WriteLine("i= {0}", i);

            //    i++;
            //}

            int i = 0;
            do
            {
                Console.WriteLine("no is : {0}", i);

                i++;
            } while (i <10 );
        }
    }
}
