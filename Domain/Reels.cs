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
        private int _startIndex;
        private int _spinPace;

        public Reels (List<List<string>> reels, int spinPace)
        {
            _reels = reels;
            _startIndex = 0;
            _spinPace = spinPace;
        }

        public static Reels Create(List<List<string>> reels, int nextIndex)
        {
            return new Reels(reels, nextIndex);
        } 

        public void Spin()
        {
            _startIndex = _spinPace;
        }

        public bool IsRowHit(int betLine)
        {
            var screenReels = new List<List<string>>();
            foreach (var reel in _reels)
            {
                screenReels.Add(reel.GetRange(_startIndex, 3));
            }
            var equalSymbolSet = new HashSet<string>();
            foreach (var reel in screenReels)
            {
                equalSymbolSet.Add(reel[betLine - 1]);
            }
            return equalSymbolSet.Count == 1;
        }
    }
}
