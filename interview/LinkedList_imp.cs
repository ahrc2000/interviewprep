using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interview
{
    public class LinkedList_imp
    {
        private listNode head;
        
        private listNode previous;
        private int size;

        public bool isEmpty
        {
            get{
                return head== null;
            }
        }

        public LinkedList_imp()
        {
            head = null;
            size = 0;
        }
        

        public int getSize()
        {
            return size;
        }

        public void InsertAtHead(object val)
        {
            listNode newNode = new listNode(val);
            newNode.Next = this.head;
            this.head = newNode;

            
        }


        public void insertAtEnd(object val)
        {
            bool flag = false;
            if (head == null)
            {
                InsertAtHead(val);
            }
            else
            {
                listNode current = this.head;
                while(current.Next !=null)
                {
                        current = current.Next;
                    
                }

                listNode newNode = new listNode(val);
                current.Next = newNode;
                size++;
            }
        }

        public void print()
        {
            listNode current = this.head;
            while(current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }



        public void deleteNode(object val)
        {
            listNode current = this.head;
            
            if(head != null)
            {
                while (current.Next != null)
                {
                    if(current.Next.Data == val)
                    {
                        current.Next = current.Next.Next;
                        return;
                    }
                    current = current.Next;
                }
            }
        
        }
        





    }
}
