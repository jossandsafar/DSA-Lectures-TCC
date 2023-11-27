using System;
using System.Collections.Generic;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }
        public bool IsEmpty { get; private set; }
        public int linkedlistlength = 0;
        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data + "\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {

            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
            if (First == null)
            {
                Node Temp = new Node(val);
                Temp.Data = val;
                Temp.Next = First;
                First = Temp;
                return;
            }
            Node move = First;
            while (move.Next != null)
                move = move.Next;
            Node temp = new Node(val);
            move.Next = temp;

        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty

            LinkedList list = new LinkedList();

            // Check if the list is empty
            if (list.IsEmpty)
            {
                Console.WriteLine("The list is empty.");
            }
            if (First.Data == key)
            {
                First = First.Next;
                linkedlistlength--;
                return;
            }
            Node current = First.Next;
            Node previous = First;
            while (current != null)
            {
                if (current.Data == key)
                {
                    previous.Next = current.Next;
                    current.Next = null;
                    linkedlistlength--;
                    return;
                }
                previous = current;
                current = current.Next;

            }


        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list

            if (other_list == null || other_list.First == null)
            {
                // The other list is empty, nothing to merge
                return;
            }

            Node current = First;

            while (current.Next != null)
            {
                current = current.Next;
            }

            // At this point, 'current' points to the last node of the current list
            current.Next = other_list.First;
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
            Node current = First;
            Node previous = null;
            Node next = null;

            while (current != null)
            {
                next = current.Next; // Store the next node temporarily
                current.Next = previous; // Reverse the link

                // Move pointers one position ahead
                previous = current;
                current = next;
            }

            // Update the head of the list
            First = previous;
        }

    }
}

