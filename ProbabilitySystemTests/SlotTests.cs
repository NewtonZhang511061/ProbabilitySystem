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
                new List<string> { "A", "J", "$" }
            }));

            var bet = slotMachine.Spin(2);

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
            }));

            var bet = slotMachine.Spin(1);

            Assert.Equal(bet, 20);
        }
    }
}