using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node root = null;

        public void Add(Node leftNode, Node rightNode, int data)
        {
            Node node = new Node();
            node.data = data;

            if (root == null)
            {
                root = new Node();
                root.data = data;
            }
            else if (data < root.data)
            {
                root.leftNode = new Node(root.leftNode, data);
            }


        }
    }
}
