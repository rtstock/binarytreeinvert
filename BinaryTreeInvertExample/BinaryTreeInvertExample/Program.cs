using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BinaryTreeInvertExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Methods
            TestMethods tm = new TestMethods();
            InternalMethods im = new InternalMethods();

            // Initialize Variable: Test Binary Tree 
            Node<int> t0;

            // Create Test Binary Tree
            t0 = tm.CreateTestTree1();

            // Output Test Binary Tree to console
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------ Original Tree ----------");
            Console.WriteLine(t0.Data);
            Console.WriteLine("{0} - {1}", t0.LeftChild.Data, t0.RightChild.Data);
            Console.WriteLine("{0} - {1} - {2} - {3}", t0.LeftChild.LeftChild.Data, t0.LeftChild.RightChild.Data, t0.RightChild.LeftChild.Data, t0.RightChild.RightChild.Data);

            // Traverse inverted binary tree
            Console.WriteLine("------ Original Tree (Traverse) ----------");
            im.Traverse(t0);

            // Invert Test Binary Tree
            im.InvertTree(t0);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------ Inverted Tree --------");
            Console.WriteLine(t0.Data);
            Console.WriteLine("{0} - {1}", t0.LeftChild.Data, t0.RightChild.Data);
            Console.WriteLine("{0} - {1} - {2} - {3}", t0.LeftChild.LeftChild.Data, t0.LeftChild.RightChild.Data, t0.RightChild.LeftChild.Data, t0.RightChild.RightChild.Data);

            // Traverse inverted binary tree
            Console.WriteLine("------ Inverted Tree (Traverse) ----------");
            im.Traverse(t0);
            Console.ReadLine();
        }

    }
    public class TestMethods
    {
        // Create a binary tree to match Brickendon Programming excercise
        //       7
        //     /   \
        //    6     8
        //   / \   / \
        //  1   4 3   5 

        public Node<int> CreateTestTree1()
        {
            var n1 = new Node<int> { Data = 1 };
            var n2 = new Node<int> { Data = 4 };
            var n3 = new Node<int> { Data = 3 };
            var n4 = new Node<int> { Data = 5 };
            var n5 = new Node<int> { Data = 6, LeftChild = n1, RightChild = n2 };
            var n6 = new Node<int> { Data = 8, LeftChild = n3, RightChild = n4 };
            var n0 = new Node<int> { Data = 7, LeftChild = n5, RightChild = n6 };
            return n0;

            //var n1 = new Node<int> { Data = "1" };
            //var n2 = new Node<int> { Data = "4" };
            //var n3 = new Node<int> { Data = "3" };
            //var n4 = new Node<int> { Data = "5" };
            //var nx1 = new Node<int> { Data = "51" };
            //var nx2 = new Node<int> { Data = "52" };
            //var ny1 = new Node<int> { Data = "53" };
            //var ny2 = new Node<int> { Data = "54" };
            //var n5 = new Node<int> { Data = "6", LeftChild = n1, RightChild = n2 };
            
            //var nx = new Node<int> { Data = "71", LeftChild = nx1, RightChild = nx2 };
            //var ny = new Node<int> { Data = "72", LeftChild = ny1, RightChild = ny2 };
            //var n6 = new Node<int> { Data = "73", LeftChild = nx, RightChild = ny };
            //var n8 = new Node<int> { Data = "7", LeftChild = n5, RightChild = n6 };
            //return n8;
        }


    }
    public class InternalMethods
    {
        // use recursion to reverse all stems of tree node
        public void InvertTree(Node<int> node)
        {
            Node<int> temp = node.LeftChild;
            node.LeftChild = node.RightChild;
            node.RightChild = temp;

            if (node.LeftChild != null)
                InvertTree(node.RightChild);

            if (node.RightChild != null)
                InvertTree(node.LeftChild);
        }

        public void Traverse (Node<int> root){ // Each child of a tree is a root of its subtree.
            if (root.LeftChild != null){
                Traverse (root.LeftChild);
            }
            Console.WriteLine(root.Data);
            if (root.RightChild != null){
                Traverse (root.RightChild );
            }
        }
    }

    // Implement the Binary Tree Node class
    // No Parent property needed here, conserves memory
    public class Node<T>
    {
        public Node<T> LeftChild { get; set; }

        public Node<T> RightChild { get; set; }

        public T Data { get; set; }

    }


}

