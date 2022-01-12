using System;

namespace MethodOverLoading
{
    public class OverLoading
    {

        public string Sound(string Voice)
        {

            Console.WriteLine("Sound Is:"+Voice);

            return Voice ;
        }

        public string Sound(string Voice, string Behaviour)
        {
            Console.WriteLine("Sound is :"+ Voice + " and Behaviour Is" + Behaviour);

            return Voice + Behaviour;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OverLoading loading = new OverLoading();

            loading.Sound("Meow");

            loading.Sound("Bow", "Friendly");
        }
    }
}
