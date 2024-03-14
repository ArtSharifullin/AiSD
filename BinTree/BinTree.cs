using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Bin_tree
{
    public class Tree
    {
        public TreeNode root;

        public void AddNode(int value)
        {
            var curNode = root;
            var node = new TreeNode{ Value = value };
            if (curNode == null)
            {
                root = node;
                return;
            }

            while (curNode != null)
            {
                if (curNode.Value < value)
                {
                    if (curNode.Right != null) curNode = curNode.Right;
                    else curNode.Right = node;
                }

                else if (curNode.Value > value)
                {
                    if (curNode.Left != null) curNode = curNode.Left;
                    else curNode.Left = node;
                }
                else break;
            }
        }

        private int FindMinNode(TreeNode start)
        {
            var min = int.MaxValue;
            var curNode = start;
            while (curNode.Left != null)
            {
                min = curNode.Value;
                curNode = curNode.Left;
            }

            curNode = null;

            return min;
        }

        public int[] BFS()
        {
            var res = new List<int>();
            var queue = new Queue<TreeNode?>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current is not null)
                {
                    queue.Enqueue(current.Left);
                    queue.Enqueue(current.Right);
                    res.Add(current.Value);
                }
            }
            return res.ToArray();
        }

        public void DFS_STR(List<int> res, TreeNode? current)
        {
            res.Add(current!.Value);
            if (current.Left is not null)
                DFS_STR(res, current.Left);
            if (current.Right is not null)
                DFS_STR(res, current.Right);
        }

        public void DFS_SYM(List<int> res, TreeNode? current)
        {
            if (current!.Left is not null)
                DFS_SYM(res, current.Left);
            res.Add(current.Value);
            if (current.Right is not null)
                DFS_SYM(res, current.Right);
        }

        public void DFS_REV(List<int> res, TreeNode? current)
        {
            if (current!.Left is not null)
                DFS_REV(res, current.Left);
            if (current.Right is not null)
                DFS_REV(res, current.Right);
            res.Add(current.Value);
        }

        public void RemoveWithoutChildren(int value)
        {
            TreeNode curNode = root;
            TreeNode parent = null;
            if (curNode == null) throw new Exception("tree is empty");
            while (curNode != null)
            {
                if (curNode.Value == value)
                {
                    if (parent == null)
                    {
                        root = null;
                    }

                    else if (parent.Left == curNode)
                    {
                        parent.Left = null;
                    }
                    else
                    {
                        parent.Right = null;
                    }

                    break;
                }

                parent = curNode;
                if (curNode.Value > value) curNode = curNode.Left;
                else curNode = curNode.Right;
            }

        }

        public void RemoveWithOneChild(int value)
        {
            TreeNode curNode = root;
            TreeNode parent = null;
            if (curNode == null) throw new Exception("empty tree");
            while (curNode != null)
            {
                if (curNode.Value == value)
                {
                    if (parent == null)
                    {
                        root = null;
                    }

                    else if (parent.Left == curNode)
                    {
                        parent.Left = findChild(parent.Left);
                    }
                    else
                    {
                        parent.Right = findChild(parent.Right);
                    }

                    break;
                }

                parent = curNode;
                if (curNode.Value > value) curNode = curNode.Left;
                else curNode = curNode.Right;
            }

            TreeNode findChild(TreeNode node)
            {
                if (node.Left == null) return node.Right;
                else return node.Left;
            }
        }

        public void RemoveWithTwoChildren(int value)
        {
            TreeNode curNode = root;
            TreeNode parent = null;
            if (curNode == null) throw new Exception("empty tree");
            while (curNode != null)
            {
                if (curNode.Value == value)
                {
                    if (parent == null)
                    {
                        root = null;
                    }

                    else if (parent.Left == curNode)
                    {
                        parent.Left.Value = FindMinNode(parent.Left);
                    }

                    else
                    {
                        parent.Right.Value = FindMinNode(parent.Right);
                    }

                    break;
                }

                parent = curNode;
                if (curNode.Value > value) curNode = curNode.Left;
                else curNode = curNode.Right;
            }
        }

    }

    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
    }
}
