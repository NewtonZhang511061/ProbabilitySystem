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

        public static SlotMachine Create(Reels reels, int nextIndex) { 
            return new SlotMachine(reels);
        }

        public int Spin(int betLine)
        {
            if (_reels.IsHitRow(betLine) && betLine == 1) return 20;
            if (_reels.IsHitRow(betLine) && betLine == 2) return 20;
            if (_reels.IsHitRow(betLine) && betLine == 3) return 20;
            return 0;
        }
    }
}
