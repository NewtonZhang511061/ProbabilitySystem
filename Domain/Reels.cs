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
        private List<Reel> _reels;
        private int _startIndex;
        private int _spinPace;

        public Reels (List<List<string>> reels, int spinPace)
        {
            _reels = reels.Select(reel => Reel.Create(reel)).ToList();
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

        public bool IsRowHit(int hitLine)
        {
            var screenReels = GetScreen();
            return screenReels.isRowHit(hitLine);
        }

        public Screen GetScreen()
        {
            var screenReels = new List<List<string>>();
            foreach (var reel in _reels)
            {
                screenReels.Add(reel.GetScreenReel(_startIndex));
            }
            return Screen.Create(screenReels);
        }
    }
}
