using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Expert
{
    class GenStack<T_type>
    {
        T_type[] elements;
        int ct;

        //public T_type Top => elements[ct - 1];
        public T_type Top { get { return elements[ct - 1]; } }

        public GenStack(int length)
        {
            elements = new T_type[length];
            ct = 0;
        }

        public void Push(T_type element)
        {
            if (ct == elements.Length)
                throw new StackOverFlowException() { Message = "GenStack OverflowException" };
            elements[ct++] = element;
        }

        public T_type Pop()
        {
            T_type vissza = elements[--ct];
            return vissza;
        }
    }
}
