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
        private int _startIndex;

        public Reel(List<string> symbools) {
            _startIndex = 0;
            _symbools = symbools;
        }

        public static Reel Create(List<string> symbools)
        {
            return new Reel(symbools);
        }

        public void Spin(int space)
        {
            _startIndex = space;
        }

        public List<string> GetScreenReel()
        {
            return _symbools.GetRange(_startIndex, 3);
        }
    }
}
