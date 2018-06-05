using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class BinaryTreeNode:TreeNode
    {
        public BinaryTreeNode() : base() { }


        public BinaryTreeNode(int data) : base(data) { }

        public BinaryTreeNode(int data, BinaryTreeNode left, BinaryTreeNode right)
        {
            base.Data = data;
            base.Neighbour = new List<TreeNode>();
            for(int i =0; i<=1; i++)
            {
                base.Neighbour.Add(default(TreeNode));
            }
            base.Neighbour[0] = left;
            base.Neighbour[1] = right;
        }

        public BinaryTreeNode Left
        {
            get
            {
                if (base.Neighbour == null)
                    return null;
                return (BinaryTreeNode)base.Neighbour[0];
            }

            set
            {
                if (base.Neighbour == null)
                {
                    base.Neighbour = new List<TreeNode>();
                    for (int i = 0; i <= 1; i++)
                    {
                        base.Neighbour.Add(default(TreeNode));
                    }
                    base.Neighbour[0] = value;
                }
                else
                {
                    base.Neighbour[0] = value;
                }

            }


        }

        public BinaryTreeNode Right
        {
            get
            {
                if (base.Neighbour == null)
                    return null;
                return (BinaryTreeNode)base.Neighbour[1];
            }

            set
            {
                if (base.Neighbour == null)
                {
                    base.Neighbour = new List<TreeNode>();
                    for (int i = 0; i <= 1; i++)
                    {
                        base.Neighbour.Add(default(TreeNode));
                    }
                    base.Neighbour[1] = value;
                }
                else
                {
                    base.Neighbour[1] = value;
                }

            }
        }
    }
}
