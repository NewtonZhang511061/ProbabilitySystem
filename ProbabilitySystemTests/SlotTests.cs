using Domain;
using Xunit;

namespace ProbabilitySystemTests
{
    public class SlotTests
    {
        [Fact]
        public void WhenLose_ShouldReturnBet0()
        {
            var slotMachine = new SlotMachine(Reels.Create(new List<List<string>>
            {
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "J", "J", "$" }
            }, RandomNumberGenerator.Create([0, 0, 0, 0, 0])));

            var bet = slotMachine.Spin(1);

            Assert.Equal(bet, 0);
        }

        [Fact]
        public void WhenHitRow1_ShouldReturnBet20()
        {
            var slotMachine = new SlotMachine(Reels.Create(new List<List<string>>
            {
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "J", "$" }
            }, RandomNumberGenerator.Create([0, 0, 0, 0, 0])));

            var bet = slotMachine.Spin(1);

            Assert.Equal(bet, 20);
        }

        [Fact]
        public void WhenHitRow2_ShouldReturnBet20()
        {
            var slotMachine = new SlotMachine(Reels.Create(new List<List<string>>
            {
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "J", "Q", "$" }
            }, RandomNumberGenerator.Create([0, 0, 0, 0, 0])));

            var bet = slotMachine.Spin(2);

            Assert.Equal(bet, 20);
        }

        [Fact]
        public void WhenHitRow3_ShouldReturnBet20()
        {
            var slotMachine = new SlotMachine(Reels.Create(new List<List<string>>
            {
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K" },
                new List<string> { "J", "J", "K" }
            }, RandomNumberGenerator.Create([0, 0, 0, 0, 0])));

            var bet = slotMachine.Spin(3);

            Assert.Equal(bet, 20);
        }

        [Fact]
        public void WhenRoll_ThenHitRow3_ReturnBet0_ThenRoll_HitRow3_ShouldReturnBet20()
        {
            var slotMachine = new SlotMachine(Reels.Create(new List<List<string>>
            {
                new List<string> { "A", "Q", "K", "K", "J" },
                new List<string> { "A", "Q", "K", "K", "J" },
                new List<string> { "A", "Q", "H", "S", "J" },
                new List<string> { "A", "Q", "K", "K", "J" },
                new List<string> { "J", "J", "K", "K", "J" }
            }, RandomNumberGenerator.Create([1, 1, 1, 1, 1])));

            var firstBet = slotMachine.Spin(3);
            var secondBet = slotMachine.Spin(3);

            Assert.Equal(firstBet, 0);
            Assert.Equal(secondBet, 20);
        }

        [Fact]
        public void IndRoll_ThenHitRow3_ReturnBet20()
        {
            var slotMachine = new SlotMachine(Reels.Create(new List<List<string>>
            {
                new List<string> { "A", "Q", "K" },
                new List<string> { "A", "Q", "K", "K" },
                new List<string> { "A", "Q", "H", "S", "K" },
                new List<string> { "A", "Q", "K", "K", "J", "K" },
                new List<string> { "J", "J", "K", "K", "J", "S", "K" }
            }, RandomNumberGenerator.Create([0, 1, 2, 3, 4])));

            var bet = slotMachine.Spin(3);

            Assert.Equal(bet, 20);
        }
    }
}