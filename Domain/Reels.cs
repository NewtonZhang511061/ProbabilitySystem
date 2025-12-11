using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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

        public void Spin()
        {
            _index = _nextIndex;
        }

        public bool IsRowHit(int betLine)
        {
            var finalRow = betLine - 1 + _nextIndex;
            var equalSymbolSet = new HashSet<string>();
            foreach (var reel in _reels)
            {
                equalSymbolSet.Add(reel[finalRow]);
            }
            return equalSymbolSet.Count == 1;
        }
    }
}
