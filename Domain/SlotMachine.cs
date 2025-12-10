using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SlotMachine
    {
        public SlotMachine() { }

        public int Spin(int betLine)
        {
            return betLine == 1? 20: 0;
        }
    }
}
