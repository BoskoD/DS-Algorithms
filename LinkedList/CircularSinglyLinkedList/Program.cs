using System;

namespace CircularSinglyLinkedList
{
    public class CSLL
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
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current;
        }

        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            Console.WriteLine(head.Data);
            Node current = head.Next;

            while (current != head)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine();
        }

        public int SearchValue(int value)
        {
            if (head == null)
            {
                return -1;
            }
            if (head.Data == value)
            {
                return 0;
            }
            int index = 1;
            Node current = head.Next;
            while (current != head)
            {
                if (current.Data == value)
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public void AddNode(int data)
        {
            Node newNode = new(data);
            if (head == null)
            {
                head = tail = newNode;
                tail.Next = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Next = head;
                tail = newNode;
            }
            size++;
        }

        public void AddAtHead(int val)
        {
            Node newNode = new(val);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                tail.Next = newNode;
                head = newNode;
            }
            size++;
        }

        public void AddAtTail(int val)
        {
            Node newNode = new(val);
            if (head == null)
            {
                head = tail = newNode;
                tail.Next = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Next = head;
                tail = newNode;
            }
            size++;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > size)
            {
                return;
            }
            if (index == 0)
            {
                AddAtHead(val);
            }
            else if (size == index)
            {
                AddAtTail(val);
            }
            else
            {
                Node newNode = new(val);
                Node prevNode = GetNode(index - 1);
                prevNode.Next = newNode;
                newNode.Next = prevNode.Next.Next;
            }
            size++;
        }

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
    };

    class Program
    {
        static void Main(string[] args)
        {
            CSLL circularSinglyLinkedList = new();

            circularSinglyLinkedList.AddNode(1);
            circularSinglyLinkedList.AddNode(2);
            circularSinglyLinkedList.AddNode(3);
            circularSinglyLinkedList.AddNode(4);
            circularSinglyLinkedList.Print(); // 1, 2, 3, 4

            circularSinglyLinkedList.AddAtHead(0);
            circularSinglyLinkedList.Print(); // 0, 1, 2, 3, 4

            circularSinglyLinkedList.AddAtTail(5);
            circularSinglyLinkedList.Print(); // 0, 1, 2, 3, 4, 5

            // TODO AddAtIndex
        }
    }
}