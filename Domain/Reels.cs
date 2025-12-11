using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Reels
    {
        private List<List<string>> _reels;
        public Reels (List<List<string>> reels)
        {
            _reels = reels;
        }

        public static Reels Create(List<List<string>> reels)
        {
            return new Reels(reels);
        } 

        public bool IsHitRow(int betLine)
        {
            var equalSymbolSet = new HashSet<string>();
            foreach (var reel in _reels)
            {
                equalSymbolSet.Add(reel[betLine-1]);
            }
            return equalSymbolSet.Count == 1;
        }
    }
}
