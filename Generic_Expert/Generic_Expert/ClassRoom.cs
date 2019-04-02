using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Expert
{
    class ClassRoom
    {
        public string ClassName { get; set; }
        public int ClassCount   { get; set; }

        public override string ToString()
        {
            return ClassName;
        }
    }
}
