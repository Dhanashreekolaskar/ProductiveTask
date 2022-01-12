using System;

namespace TypeConv
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //byte b = (byte)i;
            ////explicit converion
            //Console.WriteLine(i);

            //System.OverflowException: 'Value was either too large or too small for an unsigned byte.'
            //to handle exception we need to use try catch

            try
            {
                var number = "1234";

                byte b = Convert.ToByte(number);


                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("Value was either too large or too small for an unsigned byte");
            }

           
        }
    }
}
