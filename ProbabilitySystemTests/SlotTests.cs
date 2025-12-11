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
            }, 0));

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
            }, 0));

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
            }, 0));

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
            }, 0));

            var bet = slotMachine.Spin(3);

            Assert.Equal(bet, 20);
        }

        [Fact]
        public void WhenRoll_ThenHitRow3_ShouldReturnBet20()
        {
            var slotMachine = new SlotMachine(Reels.Create(new List<List<string>>
            {
                new List<string> { "A", "Q", "K", "K" },
                new List<string> { "A", "Q", "K", "K" },
                new List<string> { "A", "Q", "H", "K" },
                new List<string> { "A", "Q", "K", "K" },
                new List<string> { "J", "J", "K", "K" }
            }, 1));

            var bet = slotMachine.Spin(3);

            Assert.Equal(bet, 20);
        }
    }
}