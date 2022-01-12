using System;
using System.Text;

namespace Sbuilder
{
    class Program
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder("ABC",50);

            //ADD Character to the end of string
            builder.Append(new char[] { 'D','E','F'});
            builder.AppendFormat("GHI{0}{1}",'J','k');

            Console.WriteLine("{0} char :{1}",builder.Length,builder.ToString());

            //insert string to string uilder
            builder.Insert(0,"Alphabet: ");

            builder.Replace('k', 'K');




            Console.WriteLine("{0} char : {1}",builder.Length,builder.ToString());
        }
    }
}
