using System.Collections.Generic;

namespace Exercises
{
    public class BreadthFirstSearch
    {
        //Iterative
        public List<int> BreathFirstSearch(TreeNode currentNode)
        {
            List<int> list = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(currentNode);

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                list.Add(currentNode.Value);

                //Check Left to Right first, just like reading :)
                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

            return list;
        }

        //Recurcive
        public List<int> BreathFirstSearchRecurcive(Queue<TreeNode> queue, List<int> list)
        {
            if (queue.Count == 0)
            {
                return list;
            }

            var currentNode = queue.Dequeue();
            list.Add(currentNode.Value);

            //Check Left to Right first, just like reading :)
            if (currentNode.Left != null)
            {
                queue.Enqueue(currentNode.Left);
            }

            if (currentNode.Right != null)
            {
                queue.Enqueue(currentNode.Right);
            }

            return BreathFirstSearchRecurcive(queue, list);
        }


        //Iterative
        public bool Lookup(TreeNode currentNode, int value)   // 0(log n) but can be 0(n) if everything is to one side, fx. if every new value is bigger than the previous [1, 2, 3, 4...].
        {
            if (currentNode == null || currentNode.Value < 0) // Assuming values are always positive integers.
            {
                return false;
            }

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
    }
}
