using System;

namespace SinglyLinkedList
{
    public class SLL
    {
        class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        Node head = null;
        Node tail = null;
        int size = 0;

        private Node GetNode(int index)
        {
            Node p = head;
            for (int i = 0; i < index; ++i)
            { 
                p = p.Next;
            }
            return p;
        }

        public void Print()
        {
            Node current = head;

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            Console.WriteLine("Nodes of the singly linked list:");
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void Traverse()
        {
            if (head == null) return;
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public int SearchValue(int value)
        {
            if (head == null) return -1;
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Data == value) return index;
                index++;
                current = current.Next;
            }
            return -1;
        }

        // AddAtHead() will add a new node to the head of the linked list
        public void AddAtHead(int data)
        {
            Node node = new(data);
            if (size == 0) head = tail = node;
            else
            {
                node.Next = head;
                head = node;
            }
            size++;
        }

        // AddAtTail() append a node of value val to the end of the linked list.
        public void AddAtTail(int data)
        {
            Node node = new(data);
            if (size == 0) head = tail = node;
            else
            {
                tail.Next = node;
                tail = node;
            }
            size++;
        }

        // AddAtIndex() will add note at a given index
        public void AddAtIndex(int index, int data)
        {
            if (index < 0 || index > size) return;
            if (index == 0) AddAtHead(data);
            else if (index == size) AddAtTail(data);
            else
            {
                Node prevNode = GetNode(index - 1);
                Node node = new(data);
                node.Next = prevNode.Next;
                prevNode.Next = node;
                size++;
            }
        }

        // DeleteAtIndex() method will remove the node from a given index
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                return;
            }
            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node prevNode = GetNode(index - 1);
                prevNode.Next = prevNode.Next.Next;
                if (index == size - 1)
                {
                    tail = prevNode;
                }
            }
            size--;
        }

        public void DeleteEntireList()
        {
            head = tail = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SLL singlyLinkedList = new();

            singlyLinkedList.AddAtHead(1);
            singlyLinkedList.AddAtHead(2);
            singlyLinkedList.AddAtHead(4);
            singlyLinkedList.Print(); // 4, 2, 1

            singlyLinkedList.AddAtTail(0);
            singlyLinkedList.Print(); // 4, 2, 1, 0

            singlyLinkedList.AddAtIndex(1, 3);
            singlyLinkedList.Print(); // 4, 3, 2, 1, 0

            singlyLinkedList.DeleteAtIndex(4);
            singlyLinkedList.Print(); // 4, 3, 2, 1

            singlyLinkedList.DeleteEntireList();
            singlyLinkedList.Print();
        }
    }
}