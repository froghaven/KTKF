using System_Battle;



namespace Test_System_Battle
{


    public class SetupTests
    {



        [Theory]

        [InlineData ("rock", "scissors", 1)]
        [InlineData ("rock", "paper", 2)]
        [InlineData ("rock", "rock", 0)]

        [InlineData("paper", "paper", 0)]
        [InlineData ("paper", "rock", 1)]
        [InlineData ("paper", "scissors", 2)]

        [InlineData ("scissors", "scissors", 0)]
        [InlineData ("scissors", "paper", 1)]
        [InlineData ("scissors", "rock", 2)]
        public void RPS(string homeInput, string awayInput, int expectedVictoryMessageIndex)
        {
            List<string> victoryMessages = new List<string>()
            {
                "Tie! Shoot Again!",
                "Home IS THE VICTOR!",
                "AWAY IS THE VICTOR!"
            }; 


            Player home = new Player(); home.SelectedAction = homeInput;
            Player away = new Player(); away.SelectedAction = awayInput;


            Assert.Equal(Battler.RockPaperScissors(home, away).Key, victoryMessages[expectedVictoryMessageIndex]); 
        }
    }
}