using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class listNode
    {
        private listNode _next;
        private listNode _previous;
        private Object _data;


        public listNode(object value)
        {
            _data = value;

        }

        public Object Data{
            get { return _data; }
            set { _data = value; }
            }
       public listNode Next
        {
            get { return this._next; }
            set { this._next = value; }
        }

        public listNode previous
        {
            get { return this._previous; }
            set { this._previous = value; }
        } 
        
    }
}
