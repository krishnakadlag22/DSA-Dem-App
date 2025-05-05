using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DSA_Demo_App
{
    public class QueueOperations
    {
        static Queue<int> q = new Queue<int>();
        public static void Queue()
        {
            bool inside = true;
            while (inside)
            {
                Console.WriteLine("\n-----Queue MEnu-------\n");
                Console.WriteLine("\n1.Enqueue\n2.Dequeue\n3.Peek\n4.Display Queue\n5.Exit");
                Console.WriteLine("Choose Following Option: ");
                int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Element to insert in Queue: ");
                        int value = int.Parse(Console.ReadLine());
                        q.Enqueue(value);
                        Console.WriteLine("\nElement Added");
                        break;
                    case 2:
                        if(q.Count>0)
                            Console.WriteLine(q.Dequeue()+ "  Dequeued!!");
                        else
                            Console.WriteLine("Queue is Empty!!");
                        break;
                    case 3:
                        if (q.Count > 0)
                        {
                            Console.WriteLine("Peeked: "+q.Peek());
                        }
                        else
                            Console.WriteLine("Queue is Empty");
                        break;
                    case 4:
                        if (q.Count > 0)
                        {
                            foreach(int i in q)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else
                            Console.WriteLine("Queue is Empty!!");
                        break;
                    case 5:
                        Console.WriteLine("Returning to MAin MEnu!!");
                        inside = false;
                        break;
                }
            }
        }
    }
}
