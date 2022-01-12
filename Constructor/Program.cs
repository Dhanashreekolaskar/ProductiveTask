using System;

namespace Constructor
{
    public class Animal
    {
        string user;
        int age;
        //Default Constructor
        public Animal()
        {
            user = "SHREE";
            age = 23;
            Console.WriteLine("Previous User {0} and he was {1} year old", user, age);
        }

        //Parameterized Constructor
        public Animal(string name, int age1)
        {
            user = name;
            age = age1;
            Console.WriteLine("Current User {0} and he is {1} year old", user, age);
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            //default Constructor
            var animal = new Animal();
         

            //overloaded constructor
            var animall = new Animal("Cat",50);
            

        }
    }
}
