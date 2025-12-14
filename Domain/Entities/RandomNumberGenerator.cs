using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RandomNumberGenerator
    {
        private List<int> _startIndices;
        private List<int> _spinPaces;

        private RandomNumberGenerator(List<int> spinPaces)
        {
            _startIndices = spinPaces.Select(reel => 0).ToList();
            _spinPaces = spinPaces;
        }
        public static RandomNumberGenerator Create(List<int> spinPaces)
        {
            return new RandomNumberGenerator(spinPaces);
        }

        public List<int> Generaate()
        {
            _startIndices = _startIndices.Select((value, index) => value += _spinPaces[index]).ToList();
            return _startIndices;
        }
    }
}
