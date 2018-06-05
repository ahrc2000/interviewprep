using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class TreeNode
    {
        private int _data;
        private List<TreeNode> _neighbours;

        public TreeNode() { }

        public TreeNode(int data)
        {
            _data = data;
            _neighbours = null;

        }

        public TreeNode(int data, List<TreeNode> neighbours)
        {
            _data = data;
            _neighbours = neighbours;
        }

        public int Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public List<TreeNode> Neighbour
        {
            get
            {
                if (_neighbours == null)
                    _neighbours = new List<TreeNode>();
                return _neighbours;
            }

            set
            {
                _neighbours = value;
            }


        }








    }
}
