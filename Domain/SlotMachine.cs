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

        public int Spin(int hitLine)
        {
            var isRowHit = _reels.IsRowHit(hitLine);
            if (isRowHit && hitLine == 1) return 20;
            if (isRowHit && hitLine == 2) return 20;
            if (isRowHit && hitLine == 3) return 20;
            return 0;
        }
    }
}
