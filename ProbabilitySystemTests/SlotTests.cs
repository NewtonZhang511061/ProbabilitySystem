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
            }, DesignatedRandomNumberGeneratorImpl.Create([0, 0, 0, 0, 0])));

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
            }, DesignatedRandomNumberGeneratorImpl.Create([0, 0, 0, 0, 0])));

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
            }, DesignatedRandomNumberGeneratorImpl.Create([0, 0, 0, 0, 0])));

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
            }, DesignatedRandomNumberGeneratorImpl.Create([0, 0, 0, 0, 0])));

            var bet = slotMachine.Spin(3);

            Assert.Equal(bet, 20);
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
                new List<string> { "S", "J", "K", "K", "J", "S", "K" }
            }, DesignatedRandomNumberGeneratorImpl.Create([0, 1, 2, 3, 4])));

            var bet = slotMachine.Spin(3);

            Assert.Equal(bet, 20);
        }
    }
}