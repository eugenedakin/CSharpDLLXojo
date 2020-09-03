using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;

namespace CSXojo
{
    public class Class1
    {
        [DllExport]
        public static int AddTwo(int x, int y)
        {
            return x + y;
        }
    }
}
