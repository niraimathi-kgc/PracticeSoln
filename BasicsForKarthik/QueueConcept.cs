using System;
using System.Collections;
using System.Text;

namespace StackConcept
{
    class QueueConcept
    {
        public void QueueConcpt()
        {

            //First In First Out Concept


            char strVal;
            int a, i;
            Queue myQueue = new Queue();
            Console.WriteLine("Enter the number of values to EnQueue inside Queue : ");
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the {0} value to Enqueue in Queue : ", i + 1);
                strVal = Convert.ToChar(Console.ReadLine());
                myQueue.Enqueue(strVal);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("QUEUE ENQUEUE OPERATION");
            foreach (char queue in myQueue)
            {
                Console.WriteLine(queue);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("QUEUE DEQUEUE OPERATION");
            myQueue.Dequeue();
            foreach (char que in myQueue)
            {
                Console.WriteLine(que);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("QUEUE PEEK OPERATION : {0}", myQueue.Peek());
            
               // PEEK IS USED TO RETURN THE FIRST VALUE OF QUEUE WITHOUT DEQUEUEING IT...
            
            Console.WriteLine("----------------------------");
        }
    }
}
