using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Expert
{
    class IntStack
    {
        int[] elements;
        int ct;

        public int Top => elements[ct - 1];
        // public T_type Top { get { return elements[ct - 1]; } }

        public IntStack(int length)
        {
            elements = new int[length];
            ct = 0;
        }

        public void Push(int element)
        {
            if (ct == elements.Length)
                throw new StackOverFlowException() { Message = "Something happened, IntStack is full... :(" };
            else
                elements[ct++] = element;
        }

        public int Pop()
        {
            return elements[--ct];
        }
    }
}
