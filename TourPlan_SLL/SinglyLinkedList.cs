using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TourPlan_SLL;

namespace TourPlan_SLL
{
    internal class SinglyLinkedList
    {
        public Node head;
        public SinglyLinkedList()
        {
            head = null;
        }        
        public void insertLast(string city) 
        {
            // Write Your code here to insert the city (given in parameter) at the end of the list
        }
       

        public void removeCity(string city)
        {
            // Write your code here to remove the city given in parameter
        }
        public void display()
        {
            Node pointer = head;
            if (pointer == null)
            {
                Console.WriteLine("List empty \n");
                return;
            }

            while (pointer != null)
            {
                Console.Write(pointer.data + "----> ");
                pointer = pointer.next;
            }
            Console.WriteLine("Null\n");
        }
    }
}
