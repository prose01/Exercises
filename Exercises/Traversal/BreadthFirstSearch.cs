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
    }
}
