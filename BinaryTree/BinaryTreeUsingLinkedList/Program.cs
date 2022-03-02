using System;

namespace BinaryTreeUsingLinkedList
{
    public class Node
    {
        public Node left, right;
        public int? element;

        public Node()
        {
            left = null;
            right = null;
            element = null;
        }

        public Node(int? data)
        {
            element = data;
            left = null;
            right = null;
        }

        public void Display()
        {
            Console.WriteLine(element + "  ");
        }
    }

    public class BinaryTreeUsingLinkedList
    {
        public Node root;

        public BinaryTreeUsingLinkedList()
        {
            root = null;
        }

        public Node ReturnRoot()
        {
            return root;
        }

        public void Insert(int? data)
        {
            Node newnode = new(data);
            Node current;

            if (root == null)
            {
                root = newnode;
            }
            else
            {
                current = root;
                Node Parent;
                while (true)
                {
                    Parent = current;
                    if (data < current.element)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            Parent.left = newnode;
                            return;
                        }
                    }
                    else if (data == current.element)
                    {
                        Console.WriteLine("Node Already Exist");
                        break;
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            Parent.right = newnode;
                            return;
                        }
                    }
                }
            }
        }

        public static void Delete(int? data, Node root)
        {
            while (root.element != data)
            {
                if (data < root.element)
                {
                    root = root.left;
                }
                else if (data > root.element)
                {
                    root = root.right;
                }
            }

            root.element = null;
            root.right = null;
            root.left = null;
        }

        public void Inorder(Node Root)
        {
            if ((Root.left) != null)
            {
                Postorder(Root.left);
            }

            Console.Write(Root.element + " ");

            if ((Root.right) != null)
            {
                Postorder(Root.right);
            }

            Console.Write(Root.element + " ");
        }

        public void Preorder(Node Root)
        {
            Console.Write(Root.element + " ");

            if ((Root.left) != null)
            {
                Postorder(Root.left);
            }

            Console.Write(Root.element + " ");

            if ((Root.right) != null)
            {
                Postorder(Root.right);
            }
        }

        public void Postorder(Node Root)
        {
            if ((Root.left) != null)
            {
                Postorder(Root.left);
            }

            if ((Root.right) != null)
            {
                Postorder(Root.right);
            }

            Console.Write(Root.element + " ");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeUsingLinkedList binaryTree = new();

        A:  Console.WriteLine("\n1. Add\n2. Display Preorder\n3. Display Inorder\n4. Display Postorder\n5. Delete");
            int rep = Convert.ToInt32(Console.ReadLine());

            switch (rep)
            {
                case 1:
                    Console.WriteLine("Enter data ?");
                    int? data = Convert.ToInt32(Console.ReadLine());
                    binaryTree.Insert(data);
                    goto A;
                case 2:
                    binaryTree.Preorder(binaryTree.root);
                    goto A;
                case 3:
                    binaryTree.Inorder(binaryTree.root);
                    goto A;
                case 4:
                    binaryTree.Postorder(binaryTree.root);
                    goto A;
                case 5:
                    Console.WriteLine("Enter the Node element you want to delete?");
                    int? dat = Convert.ToInt32(Console.ReadLine());
                    BinaryTreeUsingLinkedList.Delete(dat, binaryTree.root);
                    goto A;
            }
        }
    }
}