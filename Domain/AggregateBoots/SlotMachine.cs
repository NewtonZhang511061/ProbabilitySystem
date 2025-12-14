using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain
{
    public class SlotMachine
    {
        private Reels _reels { get; set; }

        public SlotMachine(Reels reels)
        {
            _reels = reels;
        }

        public static SlotMachine Create(Reels reels, int nextIndex)
        {
            return new SlotMachine(reels);
        }

        public int Spin(Bet bet)
        {
            _reels.Spin();
            var screenReels = _reels.GetScreen();
            var payTable = PayTable.Create();
            return payTable.CalcBet(bet, screenReels);
        }
    }
}
