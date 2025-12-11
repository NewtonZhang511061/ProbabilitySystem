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
        private int _index;
        private int _nextIndex;

        public Reels (List<List<string>> reels, int nextIndex)
        {
            _reels = reels;
            _index = 0;
            _nextIndex = nextIndex;
        }

        public static Reels Create(List<List<string>> reels, int nextIndex)
        {
            return new Reels(reels, nextIndex);
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
