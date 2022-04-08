using System;
using System.Collections;

namespace StackConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueConcept queueConcept = new QueueConcept();
            char strVal;
            int a, i;
            Stack Mystack = new Stack();
            Console.WriteLine("Enter the number of values to push inside stack: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the {0} value to push in stack: ", i + 1);
                strVal = Convert.ToChar(Console.ReadLine());
                Mystack.Push(strVal);  // Last In First Out
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("STACK PUSH OPERATION");
            foreach (char stack in Mystack)
            {
                Console.WriteLine(stack);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("STACK POP OPERATION");
            Mystack.Pop();
            foreach (char stk in Mystack)
            {
                Console.WriteLine(stk);
            }
            Console.WriteLine("----------------------------");

            queueConcept.QueueConcpt();
        }
    }
}
