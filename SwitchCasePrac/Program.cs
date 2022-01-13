using System;

namespace SwitchCasePrac
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //int y = 50;

        //    //switch (y)
        //    //{
        //    //    case 10: 
        //    //        Console.WriteLine("Value of y is 10");
        //    //        break;

        //    //        case 50:
        //    //        Console.WriteLine("Value of y is 50");
        //    //        break;

        //    //    case 30:
        //    //        Console.WriteLine("Value of y is 30");
        //    //        break;

        //    //    default:
        //    //        Console.WriteLine("Unknown value");
        //    //        break;


        //    //string line = "switch";

        //    //switch (line)
        //    //{
        //    //    case "id.else":
        //    //        Console.WriteLine("if else");
        //    //        break;

        //    //    case "switch":
        //    //        Console.WriteLine("switch");

        //    //        break;

        //    //    case "loop":
        //    //        Console.WriteLine("loop");
        //    //        break;

        //    //    default:
        //    //        Console.WriteLine("Not found");
        //    //        break;

        //    //}


        //    //return statement in switch

        //}

        static void Main(string[] args)
        {
            int x = 122;
            Console.Write(isOdd(x) ? "Even value" : "Odd value");
        }

        static bool isOdd(int x)
        {
            switch (x % 2)
            {
                case 0:
                    return true;
                case 1:
                    return false;
                default:
                    return false;
            }

          
        }
    }
}

