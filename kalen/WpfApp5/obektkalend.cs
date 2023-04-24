using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{

    public class obektkalend
    {
        public string n { get; set; }
        public string i { get; set; }
        public bool v { get; set; }
        public obektkalend(string n, string i = "/krtstik.png", bool v = false)
        {
            this.n = n;
            this.i = i;
            this.v = v;
        }
    }

}
 