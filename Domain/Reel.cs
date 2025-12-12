using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Reel
    {
        private List<string> _symbools;
        public Reel(List<string> symbools) {
            _symbools = symbools;
        }
        public static Reel Create(List<string> symbools)
        {
            return new Reel(symbools);
        }

        public List<string> GetScreenReel(int startIndex)
        {
            return _symbools.GetRange(startIndex, 3);
        }
    }
}
