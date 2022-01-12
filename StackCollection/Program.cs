using System;
using System.Collections.Generic;

namespace StackCollection
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Create Stack

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach(var item in stack)
            Console.WriteLine(item + ",");


            //Create stack with Array-insted of push array can add direct list

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Stack<int> stackno = new Stack<int>(array);

            foreach (var item in stackno)
                Console.WriteLine(item + ",");


            //Pop()

            Stack<int> pop = new Stack<int>();
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Push(15);

            Console.WriteLine("Stack Count list : {0}",pop.Count);

            while (pop.Count > 0) ;
            Console.WriteLine(pop.Pop() +  ",");

            Console.WriteLine("Stack Count list : {0}", pop.Count);


            //peek()

            Stack<int> peek = new Stack<int>();
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);
            stack.Push(15);

            Console.WriteLine("Stack element : {0}",peek.Count);

            if (peek.Count > 0)
                Console.WriteLine(peek.Peek()+",");

            Console.WriteLine("Stack element : {0}", peek.Count);


        }
    }
}
