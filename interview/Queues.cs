using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class Queues
    {

        private listNode _head;
        private listNode _tail;
        private int size;
        private Object minElement;
        public Queues()
        {
            _head = null;
            _tail = null;
            size = 0;
        }

        public int Size
        {
            get
            {
                return size;
            }
        }



        public void queueAdd(object k)
        {
            listNode current ;
            if (_tail == null)
            {
                current = new listNode(k);
                _head = _tail = current;
                minElement = k;

                size++;
            }
            else
            {
                
                listNode newNode = new listNode(k);
                _tail.Next = newNode;
                _tail = newNode;
                if ((int) k < (int) minElement)
                    minElement = k;
                size++;
            }
        }

        public listNode remove()
        {
            if (_head == null)
            { _tail = null;

                throw new Exception("the list is already empty");
            }
            listNode current = _head;
            _head = _head.Next;
            size--;
            updateMin();
            return current;

        }

        public listNode getTop()
        {
            if (_head != null)
                return _head;
            else
                throw new Exception("Empty queue");
        }

        public listNode getLast()
        {
            if (_tail != null)
                return _tail;
            else
                throw new Exception("empty queue");
        }

        private void updateMin()
        {
            if (_head == null)
                return;
            listNode current = _head;

            while (current.Next != null)
            {
                if ((int) minElement < (int) current.Data)
                    minElement = current.Data;
                current = current.Next;
            }
            
        } 

    }
}
