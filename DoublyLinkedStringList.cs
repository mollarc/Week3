using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    internal class DoublyLinkedStringList
    {
        public bool isHead;
        public bool isTail;
        public DoublyLinkedStringList? next;
        public DoublyLinkedStringList? previous;
        public string[]? theList;
        public DoublyLinkedStringList(bool isHead, bool isTail)
        {
            this.isHead = isHead;
            this.isTail = isTail;
        }
        public DoublyLinkedStringList(bool isHead, bool isTail, DoublyLinkedStringList? next, DoublyLinkedStringList? previous, string[] strings)
        {
            this.isHead = isHead;
            this.isTail = isTail;
            this.next = next;
            this.previous = previous;
            this.theList = strings;
        }
        //Set methoods for all variables
        public void setNext(DoublyLinkedStringList next)
        {
            this.next=next;
        }

        public void setPrevious(DoublyLinkedStringList previous)
        {
            this.previous=previous;
        }

        public void setHead(bool  head)
        {
            this.isHead=head;
        }

        public void setTail(bool tail)
        {
            this.isTail=tail;
        }

        public void setList(string[] list)
        {
            this.theList=list;
        }
    }
}
