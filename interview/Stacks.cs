using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class Stacks
    {
        private listNode _top;
        private int _size;
        public Stacks() {

            _top = null;
            _size = 0;
        }

        public int Size{
            get{
            return _size;}

            }
        public void Push(Object k)
        {
            listNode newNode = new listNode(k);
                newNode.Next = _top;
                _top = newNode;
            _size++;
        }


        public listNode Pop(Object k)
        {
            listNode result;
            if (_top == null)
                throw new Exception("Stack is empty");
            
                result = _top;
                _top = _top.Next;
                _size--;
            
            return result;
        }

        public bool isEmpty()
        {
            return _top == null;
        }
        
    }
}
