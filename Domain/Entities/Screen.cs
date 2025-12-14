using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Screen
    {
        private List<List<string>> _screenReels;
        public Screen(List<List<string>> screenReels)
        {
            _screenReels = screenReels;
        }
        public static Screen Create(List<List<string>> screenReels)
        {
            return new Screen(screenReels);
        }

        public bool isScreenRowHit(int hitLine)
        {
            var equalSymbolSet = new HashSet<string>();
            foreach (var reel in _screenReels)
            {
                equalSymbolSet.Add(reel[hitLine - 1]);
            }
            return equalSymbolSet.Count == 1;
        }
    }
}
