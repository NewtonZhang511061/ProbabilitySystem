using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Bet
    {
        private readonly int[] _hitLines;
        private Bet(params int[] hitLines) { 
            _hitLines = hitLines;
        }
        public static Bet Create(params int[] hitLines) {
            return new Bet(hitLines);
        }

        public bool Include(int line)
        {
            return _hitLines.Contains(line);
        }
    }
}
