namespace Tree
{
    public static class BinaryTreeExtensions
    {
        public static List<int> DFSPreorder(this BinaryTree node)
        {
            List<int> result = new List<int>();
            if (node == null)
            {
                return result;
            }

            result.Add(node.Value);
            if (node.Left != null)
            {
                result.AddRange(node.Left.DFSPreorder());
            }

            if (node.Right != null)
            {
                result.AddRange(node.Right.DFSPreorder());
            }

            return result;
        }

        public static List<int> DFSPostOrder(this BinaryTree node)
        {
            List<int> result = new List<int>();
            if (node == null)
            {
                return result;
            }

            if (node.Left != null)
            {
                result.AddRange(node.Left.DFSPostOrder());
            }

            if (node.Right != null)
            {
                result.AddRange(node.Right.DFSPostOrder());
            }

            result.Add(node.Value);
            return result;
        }

        public static List<int> DFSInorder(this BinaryTree node)
        {
            List<int> result = new List<int>();
            if (node == null)
            {
                return result;
            }

            if (node.Left != null)
            {
                result.AddRange(node.Left.DFSInorder());
            }

            result.Add(node.Value);

            if (node.Right != null)
            {
                result.AddRange(node.Right.DFSInorder());
            }

            return result;
        }

        public static List<int> BFS(this BinaryTree node)
        {
            List<int> result = new List<int>();
            if (node == null)
            {
                return result;
            }

            Queue<BinaryTree> queue = new Queue<BinaryTree>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                result.Add(current.Value);
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return result;
        }
    }
}
