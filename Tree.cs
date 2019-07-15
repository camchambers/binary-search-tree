/**
 *  A Binary Search Tree (BST) is made up of nodes, where each node comprises of
 *  a left pointer, a right pointer, and a value.
 *  
 *  BSTs meet the following properties: 
 *      - The left subtree of a given node contains only nodes with values that 
 *        have a lesser value than the current node's value.
 *      - The right subtree of a node contains only nodes with values that are
 *        greater than the current node's key.
 *      - The left and right subtree each must also be a binary search tree.
 *      - There must be no duplicate nodes 
 */

using System;

namespace BinarySearchTree
{
    class Tree
    {
        /// <summary>
        /// Inserts a new node into the tree
        /// </summary>
        /// <param name="root">The root node </param>
        /// <param name="value">The new value being inserted into the tree</param>
        /// <returns>
        /// Returns the current root node
        /// </returns>
        public Node insert(Node root, int value)
        {
            // If there is no root node, create a new one and set its value
            // to the value provided
            // Otherwise recruse down the tree and insert the value
            if (root == null)
            {
                root = new Node();
                root.value = value;
            }
            else if (value < root.value)
            {
                root.left = insert(root.left, value);
            }
            else
            {
                root.right = insert(root.right, value);
            }

            return root;
        }

        /// <summary>
        /// Traverses the tree and prints out the value of the current node
        /// </summary>
        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            // Print out the value of the current node
            Console.WriteLine(root.value);
            traverse(root.left);
            traverse(root.right);
        }
    }
}