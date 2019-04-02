using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Expert
{
    class Invertory
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public T_type Maximum<T_type>(T_type a, T_type b) where T_type : IComparable
        {
            //if (a > b)
            //    return a;
            //else if (a == b)
            //    return a;
            //else 
            //    return b;

            if (a.CompareTo(b) > 0)
                return a;
            else
                return b;
        }

        public T_type Minimum<T_type>(T_type a, T_type b) where T_type : IComparable
        {
            if (a.CompareTo(b) < 0)
                return a;
            else
                return b;
        }

        public bool OsszehasonlitListaErtekre<T_type, K_type>(T_type a, K_type b)
        {
            return a.Equals(b);
        }

        public bool OsszehasonlitasTipusra<T, K>(T a, K b)
        {
            return typeof(T).Equals(typeof(K));
        }
    }
}
