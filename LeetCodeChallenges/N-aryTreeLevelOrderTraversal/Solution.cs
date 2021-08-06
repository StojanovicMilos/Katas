using System;
using System.Collections.Generic;
using System.Linq;

namespace N_aryTreeLevelOrderTraversal
{
    //https://leetcode.com/explore/challenge/card/august-leetcoding-challenge-2021/613/week-1-august-1st-august-7th/3871/

    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }


    public class Solution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            var current = root;
            result.Add(new List<int> { current.val });

            var children = current.children;
            while (children.Any())
            {
                result.Add(children.Where(child => child?.val != null).Select(child => child.val).ToList());
                children = children.Where(child => child?.children != null).SelectMany(child => child.children).ToList();
            }

            return result;
        }
    }
}
