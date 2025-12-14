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


        public bool IsRowHit(int hitLine)
        {
            var screenReels = GetScreen();
            return screenReels.isScreenRowHit(hitLine);
        }

        private Screen GetScreen()
        {
            var screenReels = new List<List<string>>();
            for (var index = 0; index < _reels.Count; index++)
            {
                screenReels.Add(_reels[index].GetScreenReel(_randomNumberGenerator.Generate()));
            }
            return Screen.Create(screenReels);
        }
    }
}
