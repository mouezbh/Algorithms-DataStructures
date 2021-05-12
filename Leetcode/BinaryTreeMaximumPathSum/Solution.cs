// link : https://leetcode.com/problems/binary-tree-maximum-path-sum/

using System;

public class Solution
{
    private int max = int.MinValue;

    public int MaxSumPath(TreeNode root)
    {
        MaxSum(root);
        return this.max;
    }

    private int MaxSum(TreeNode node)
    {
        if (node == null)
            return 0;

        var left = MaxSum(node.left);
        var right = MaxSum(node.right);

        var leftArrow = left + node.val;
        var rightArrow = right + node.val;
        var maxArrow = Math.Max(leftArrow, rightArrow);

        var sumWithCurrentNode = left + right + node.val;

        this.max = Math.Max(this.max, Math.Max(maxArrow, sumWithCurrentNode));

        return maxArrow;
    }

    /*
    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    */
}