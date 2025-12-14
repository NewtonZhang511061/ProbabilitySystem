using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PayTable
    {
        private PayTable() { }
        public static PayTable Create()
        {
            return new PayTable();
        }

        public int CalcBet(Bet bet, Screen reels)
        {
            if (reels.isScreenRowHit(1) && bet.Include(1)) return 20;
            if (reels.isScreenRowHit(2) && bet.Include(2)) return 20;
            if (reels.isScreenRowHit(3) && bet.Include(3)) return 20;
            return 0;
        }
    }
}
