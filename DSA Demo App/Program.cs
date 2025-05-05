using System;

namespace DSA_Demo_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool start=true;;
            while (start)
            {
                Console.WriteLine("\n-------DSA ConsoleAPP");
                Console.WriteLine("1. Array Operations\n2. Stack Operations.\n3. Queue Operations.\n4. Linekd List Operations\n5. EXIT");
                Console.WriteLine("Enter your Choice.");
                int choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ArrayOperations.Array_OP();
                        break;
                    case 2:
                        StackOperation.Stack();
                        break;
                    case 3:
                        QueueOperations.Queue();
                        break;
                    case 4:
                        LinkedList_Operations.Linked();
                        break;
                    case 5:
                        start = false;
                        break;

                }
            }
        }
    }
}