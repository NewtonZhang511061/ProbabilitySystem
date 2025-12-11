using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SlotMachine
    {
        private Reels _reels { get; set; }
        public SlotMachine(Reels reels) { 
            _reels = reels;
        }

        public static SlotMachine Create(Reels reels) { 
            return new SlotMachine(reels);
        }

        public int Spin(int betLine)
        {
            return _reels.Spin(betLine);
        }
    }
}
