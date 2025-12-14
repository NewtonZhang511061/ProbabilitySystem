using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Domain
{
    public class Reels
    {
        private List<Reel> _reels;
        private RandomNumberGeneratorGateway _randomNumberGenerator;

        public Reels(List<List<string>> reels, RandomNumberGeneratorGateway randomNumberGenerator)
        {
            _reels = reels.Select(reel => Reel.Create(reel)).ToList();
            _randomNumberGenerator = randomNumberGenerator;
        }

        public static Reels Create(List<List<string>> reels, RandomNumberGeneratorGateway randomNumberGenerator)
        {
            return new Reels(reels, randomNumberGenerator);
        }

        public void Spin()
        {
            foreach (var reel in _reels)
            {
                reel.Spin(_randomNumberGenerator.Generate());
            }
        }

        public Screen GetScreen()
        {
            var screenReels = new List<List<string>>();
            for (var index = 0; index < _reels.Count; index++)
            {
                screenReels.Add(_reels[index].GetScreenReel());
            }
            return Screen.Create(screenReels);
        }
    }
}
