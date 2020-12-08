using System.Collections.Generic;

namespace Exercises
{
    public class DepthFirstSearch
    {
        // Recursive function. 
        public List<int> DFSInOrder(TreeNode node, List<int> list)
        {
            if(node.Left != null)
            {
                DFSInOrder(node.Left, list);
            }

            //In Order add is between Left and Right.
            list.Add(node.Value);

            if (node.Right != null)
            {
                DFSInOrder(node.Right, list);
            }

            return list;
        }

        // Recursive function. 
        public List<int> DFSPreOrder(TreeNode node, List<int> list)
        {
            //Pre Order add is before Left and Right.
            list.Add(node.Value);

            if (node.Left != null)
            {
                DFSPreOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                DFSPreOrder(node.Right, list);
            }

            return list;
        }

        // Recursive function. 
        public List<int> DFSPostOrder(TreeNode node, List<int> list)
        {
            if (node.Left != null)
            {
                DFSPostOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                DFSPostOrder(node.Right, list);
            }

            //Post Order add is after Left and Right.
            list.Add(node.Value);

            return list;
        }
    }
}
