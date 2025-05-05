using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Demo_App
{
    internal class ArrayOperations
    {
        
        public static void Array_OP()
        {
            int[] arr = new int[111];
            int size = 0;
            bool start = true;

            while (start)
            {
                Console.WriteLine("\n-----Array Menu--------");
                Console.WriteLine("1.Insert Array\n2.Search Element\n3.Sort Array\n4.Display Array\n5.Back To Main Menu");
                Console.WriteLine("Choose Optiot: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Element You to Insert: ");
                        int value = Convert.ToInt32(Console.ReadLine());
                        arr[size] = value;
                        size++;//First Storing in array of variable size as array index and incrementing it by adding array element
                        Console.WriteLine("Inserted");
                        break;
                    case 2:
                        Console.WriteLine("Enter Element you want to search: ");
                        int num=Convert.ToInt32(Console.ReadLine());
                        bool flag = false;
                        for(int i = 0; i < size; i++)
                        {
                            if (arr[i] == num)
                            {
                                Console.WriteLine("Element Found At index: "+i);
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            Console.WriteLine("Element not found!!");
                        }
                        break;
                    case 3:

                        Array.Sort(arr, 0, size);//used predifined method to sort array
                        Console.WriteLine("Array Sorted!!");
                        break;
                    case 4:
                        Console.WriteLine("Array Elements: ");
                        for(int i = 0; i < size; i++)
                        {
                            Console.WriteLine(" " + arr[i]);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Returning to Main Menu...");
                        start=false;
                        break;
                }
            }
        }
    }
}
