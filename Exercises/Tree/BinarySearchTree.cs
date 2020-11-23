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

        public TreeNode Lookup(int value)
        {
            if (root == null)
            {
                return null;
            }

            var currentNode = this.root;

            while (currentNode != null)
            {
                if (value == currentNode.Value)
                {
                    return currentNode;
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

            return null;
        }

        public void Remove(int value)
        {
            if(this.root == null)
            {
                return;
            }

            var currentNode = this.root;
            TreeNode parentNode = null;

            while (currentNode != null)
            {
                // We have a match, so lets get to work.
                if (value == currentNode.Value)
                {   

                    // Option 1: no right child.
                    if (currentNode.Right == null)
                    {   

                        if (parentNode == null)
                        {
                            this.root = currentNode.Left;
                            return;
                        }
                        else
                        {
                            // If current < parent, make current left child a child of parent.
                            if (currentNode.Value < parentNode.Value)
                            {   
                                parentNode.Left = currentNode.Left;
                                return;
                            }
                            // If parent < current value, make left child a right child of parent.
                            else if (parentNode.Value < currentNode.Value)
                            {   
                                parentNode.Right = currentNode.Left;
                                return;
                            }
                        }
                    }
                    // Option 2: Right child which doesn't have a left child.
                    else if (currentNode.Right.Left == null)
                    {   

                        currentNode.Right.Left = currentNode.Left;

                        if (parentNode == null)
                        {
                            this.root = currentNode.Left;
                            return;
                        }
                        else
                        {
                            // If current < parent, make current right child the left of parent.
                            if (currentNode.Value < parentNode.Value)
                            {   
                                parentNode.Left = currentNode.Right;
                                return;
                            }
                            // If parent < current value, make right child a right child of parent.
                            else if (parentNode.Value < currentNode.Value)
                            {   
                                parentNode.Right = currentNode.Right;
                                return;
                            }
                        }
                    }
                    // Option 3: Right child that has a left child.
                    else
                    {
                        //find the Right child's left most child
                        var leftmost = currentNode.Right.Left;
                        var leftmostParent = currentNode.Right;
                        while (leftmost.Left != null)
                        {
                            leftmostParent = leftmost;
                            leftmost = leftmost.Left;
                        }

                        //Parent's left subtree is now leftmost's right subtree
                        leftmostParent.Left = leftmost.Right;
                        leftmost.Left = currentNode.Left;
                        leftmost.Right = currentNode.Right;

                        if (parentNode == null)
                        {
                            this.root = leftmost;
                            return;
                        }
                        else
                        {
                            if (currentNode.Value < parentNode.Value)
                            {
                                parentNode.Left = leftmost;
                                return;
                            }
                            else if (currentNode.Value > parentNode.Value)
                            {
                                parentNode.Right = leftmost;
                                return;
                            }
                        }
                    }
                }
                else if (value < currentNode.Value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Left;
                }
                else
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Right;
                }
            }

            return;
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
