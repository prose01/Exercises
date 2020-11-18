using System;

namespace Exercises
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(int value)
        {
            var newTreeNode = new TreeNode(value);

            if (this.root == null)
            {
                this.root = newTreeNode;
            }
            else
            {
                var currentNode = this.root;

                while (true)
                {
                    if(value < currentNode.Value)
                    {
                        //Left
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = newTreeNode;
                            return;
                        }

                        currentNode = currentNode.Left;
                    }
                    else
                    {
                        //Right
                        if(currentNode.Right == null)
                        {
                            currentNode.Right = newTreeNode;
                            return;
                        }

                        currentNode = currentNode.Right;
                    }
                }
            }
        }

        public bool Lookup(int value)
        {
            if (root == null)
            {
                return false;
            }

            var currentNode = this.root;

            while (currentNode != null)
            {
                if (value == currentNode.Value)
                {
                    return true;
                }
                else if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }

            return false;
        }

        public void Remove(int value)
        {
        }

        private TreeNode TraversTreeNodes(TreeNode node)
        {
            var treeNode = new TreeNode(node.Value);
            treeNode.Right = node.Right == null ? null : this.TraversTreeNodes(node.Right);
            treeNode.Left = node.Left == null ? null : this.TraversTreeNodes(node.Left);

            return treeNode;
        }
    }

    public class TreeNode
    {
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public int Value { get; set; }

        public TreeNode(int value)
        {
            this.Left = null;
            this.Right = null;
            this.Value = value;
        }
    }
}
