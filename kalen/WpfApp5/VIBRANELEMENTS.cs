using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApp5
{
    internal class VIBRANELEMENTS
    {
        public DateTime dateday { get; private set; }
        public List<obektkalend> vibelem { get; private set; }
        public VIBRANELEMENTS(DateTime dateday, List<obektkalend> vibelem)
        {
            this.dateday = dateday;
            this.vibelem = vibelem;
        }
        
    }
}
