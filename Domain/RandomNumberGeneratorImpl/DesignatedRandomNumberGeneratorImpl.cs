using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DesignatedRandomNumberGeneratorImpl: RandomNumberGeneratorGateway
    {
        private List<int> _spinPaces;


        private DesignatedRandomNumberGeneratorImpl(List<int> spinPaces)
        {
            _spinPaces = spinPaces;
        }
        public static DesignatedRandomNumberGeneratorImpl Create(List<int> spinPaces)
        {
            return new DesignatedRandomNumberGeneratorImpl(spinPaces);
        }

        public int Generate()
        {
            var number = _spinPaces[0];
            _spinPaces.RemoveAt(0);
            return number;
        }
    }
}
