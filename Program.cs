using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new random generator
            Random random = new Random();

            // Generate an array of pseudo-random numbers to insert into our 
            // binary search tree
            int[] values = new int[10];
            for (int i = 0; i < 10; i++)
            {
                // Generate a non-negative random integer between 0 and 1000
                values[i] = random.Next(1000);
            }

            // Instantiate a new binary search tree
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            // Instantiate an initial root node
            Node root = null;

            // Iterate over values array and insert values into the binary
            // search tree
            for (int i = 0; i < values.Length; i++)
            {
                root = binarySearchTree.insert(root, values[i]);
            }

            // Traverse the binary search tree and print out the values of 
            // each node
            // TODO Add different traversal options here
            binarySearchTree.traverse(root);
        }
    }
}
