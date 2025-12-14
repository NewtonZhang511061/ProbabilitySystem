using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class NativeRandomGeneratorImpl: RandomNumberGeneratorGateway
    {

        private readonly int _upperBound;
        public NativeRandomGeneratorImpl(int upperBound) {
            _upperBound = upperBound;
        }
        public static NativeRandomGeneratorImpl Create(int upperBound) { 
            return new NativeRandomGeneratorImpl(upperBound);
        }
        public int Generate()
        {
            var number = new Random().Next(_upperBound);
            return number;
        }
    }
}
