using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Demo_App
{
    public class StackOperation
    {
        static Stack<int> s = new Stack<int>();
        public static void Stack()
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("\n-----------STACK MENU--------------\n");
                Console.WriteLine("\n1.PUSH\n2.POP\n3.PEEK\n4.Display Stack\n5.EXIT");
                Console.WriteLine("Choose Option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element you to Insert: ");
                        int value = int.Parse(Console.ReadLine());
                        s.Push(value);
                        break;
                    case 2:
                        if (s.Count > 0)
                        {
                            Console.WriteLine("Pop Element: " + s.Pop());
                        }
                        else
                            Console.WriteLine("Stack is Empty");
                        break;
                    case 3:
                        if (s.Count > 0)
                        {
                            Console.WriteLine("Top Element: " + s.Peek());
                        }
                        else
                            Console.WriteLine("Stack Is Empty");
                        break;
                    case 4:
                        if (s.Count > 0)
                        {
                            Console.WriteLine("\n");
                            foreach (int i in s)
                            {
                                Console.Write(" " + i);                       
                            }
                        }
                        else
                            Console.WriteLine("Stack is Empty");
                        break;
                    case 5:
                        Console.WriteLine("Returning to MAin Menu...");
                        exit = false;
                        break;
                }
            }

        }
    }
}
