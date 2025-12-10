


namespace System_Battle
{



    public class Battler
    {
        // TODO : Hookup RPS & SelectP1 System For Actual Player Input and Selection 



        public Player Home; 
        public Player Away;


        public Battler(Player Home, Player Away) 
        {
            this.Home = Home;
            this.Away = Away;
            Player rpsVictor; 

            do { rpsVictor = RockPaperScissors(Home, Away).Value; }
            while (rpsVictor == null);


            SelectPlayer1(rpsVictor, rpsVictor.SelectedAction); 
        }

        public void SelectPlayer1(Player rpsVictor, string selectionInput)
        {
            if (selectionInput == "Home") { Home.ID = 1; Away.ID = 2; }
            else { Away.ID = 1; Home.ID = 2; }
        }

        public static KeyValuePair<string, Player?> RockPaperScissors(Player home, Player away)
        {
            Dictionary<string, string> rpsKey = new Dictionary<string, string>()
            {
                { "rock", "paper"},
                { "scissors", "rock"},
                { "paper", "scissors"}
            };

            Dictionary<string, Player?> victorKey = new Dictionary<string, Player?>()
            {
                { "Tie!", null  },
                { "Home!", home },
                { "Away!", away}
            };


           if (away.SelectedAction == home.SelectedAction) { return victorKey.ElementAt(0); }
           else if (rpsKey[away.SelectedAction] == home.SelectedAction) { return victorKey.ElementAt(1); }
           else { return victorKey.ElementAt(2); }
        }


       
    }
}
