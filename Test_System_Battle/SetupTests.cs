using System_Battle;



namespace Test_System_Battle
{
    public class SetupTests
    {


        [Theory]

        [InlineData ("rock", "scissors", "Home!")]
        [InlineData ("rock", "paper", "Away!")]
        [InlineData ("rock", "rock", "Tie!")]

        [InlineData("paper", "paper", "Tie!")]
        [InlineData ("paper", "rock", "Home!")]
        [InlineData ("paper", "scissors", "Away!")]

        [InlineData ("scissors", "scissors", "Tie!")]
        [InlineData ("scissors", "paper", "Home!")]
        [InlineData ("scissors", "rock", "Away!")]
        public void RPS(string homeInput, string awayInput, string expectedVictor)
        {
            Player home = new Player();
            Player away = new Player();
            home.SelectedAction = homeInput;
            away.SelectedAction = awayInput;


            Assert.Equal(Battler.RockPaperScissors(home, away).Value, expectedVictor); 
        }
    }
}