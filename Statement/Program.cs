using System;

namespace Statement
{
    class Program
    {

       
        static void Main(string[] args)
        {
            ////IF STATEMENT
            //int i = 20;
            //int j = 40;

            //if (i > j)
            //{
            //    Console.WriteLine("i is greater than j ");
            //}

            //if (i<j)
            //{
            //    Console.WriteLine("i is less than j");
            //}

            ////IF ELSE STATEMENT

            //int i = 100;
            //int j = 15;

            //if (i<j)
            //{
            //    Console.WriteLine("i is less than j");
            //}

            //else
            //{
            //    Console.WriteLine("i is greater than j");
            //}


            ////Else if Statement

            //int k = 100;
            //int m = 100;

            //if (k < m)
            //{
            //    Console.WriteLine("k IS LESS THAN M");

            //}

            //else if (k < m)
            //{
            //    Console.WriteLine("k is greater");
            //}

            //else
            //{
            //    Console.WriteLine("k is equal to m");
            //}


            //int i = 30;
            //int k = 60;
            //int m = 60;

            //if (i>k)
            //{
            //    Console.WriteLine("i>k");

            //    if (m>k)
            //    {
            //        Console.WriteLine("m>k");

            //    }

            //    else if(k>i)
            //    {
            //        if (m<k)
            //        {
            //            Console.WriteLine("k<m");

            //        }

            //        else if(m == k)
            //        {
            //            Console.WriteLine("M=K");
            //        }

            //    }


            //}

            //else
            //{
            //    Console.WriteLine("k>i");
            //}

            //Ternary Opperator ?

            int x = 100 , y = 200;

            string reuslt = x < y ? "x<y" :
                            x > y ? "x>y" :
                            x == y ? "x=y" : "No result";
            Console.WriteLine(reuslt);
        }
    }
}
