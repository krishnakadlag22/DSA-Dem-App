using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Demo_App
{
    public class LinkedList_Operations
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
            
        }
        static Node head = null;
        public static void Linked()
        {
            bool inside = true;
            while (inside)
            {
                Console.WriteLine("\n------LinkedList MENU-------\n");
                Console.WriteLine("\n1.INsert At End.\n2.Delete Value.\n3.Search value.\n4.Display List.\n5.Back To Main Menu");
                Console.WriteLine("Choose the Option: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter Element u want to Inser: ");
                        int val=int.Parse(Console.ReadLine());
                        InsertAtEnd(val);
                        break;
                    case 2:
                        Console.WriteLine("Enter Value To Delete:");
                        int del = int.Parse(Console.ReadLine());
                        DeleteByValue(del);
                        break;
                    case 3:
                        Console.WriteLine("Enter Value U to Search:");
                        int find = int.Parse(Console.ReadLine());
                        SearchVal(find);
                        break;
                    case 4:
                        Console.WriteLine("Displaying List!!!");
                        DisplayList();
                        break;
                    case 5:
                        Console.WriteLine("Returning to Main Menu");
                        inside = false;
                        break;
                }
            }
        }
        static void InsertAtEnd(int val)
        {
            Node newN = new Node(val);
            if (head == null)
                head = newN;
            else
            {
                Node temp=head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newN;
            }

        }
        static void DeleteByValue(int del)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty!!");
                return;
            }
            if (head.data == del)
            {
                head = head.next;
                Console.WriteLine("Deleted Successfully");
                return;
            }
            Node temp = head;
            while(temp.next!=null && temp.next.data != del)
            {
                temp=temp.next;
                //Console.WriteLine("Deleted Succesfully!!!");
            }
            if (temp.next == null)
                Console.WriteLine("Value not Found");
            else
            {
                temp.next = temp.next.next;
                Console.WriteLine("Deleted Successfully!!");

            }
        }
        static void SearchVal(int find)
        {
            Node temp = head;
            int pos = 0;
            while (temp != null)
            {
                if (temp.data == find)
                {
                    Console.WriteLine("Vale found At Position: "+pos);
                    return;
                }
                temp = temp.next;
                pos++;
            }
            Console.WriteLine("Value Not Found!!!");
        }
        static void DisplayList()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty!!");
                return;
            }
            Console.WriteLine("Linked List Elements:");
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data+"->");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }
    }
}
