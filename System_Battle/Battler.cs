


namespace System_Battle
{



    public class Battler
    {
        // TODO : Hookup RPS & SelectP1 System For Actual Player Input and Selection 


        public List<Player> Players = new List<Player>();


        public Battler(Player player)
        {
            Player cpu = new Player();

            // RPS for player 1
            Player rpsVictor;
            do { rpsVictor = RockPaperScissors(player, cpu).Value; } while (rpsVictor == null);


            if (rpsVictor.SelectedAction == "Player")
            {
                player.ID = 1; Players.Add(player);
                cpu.ID = 2; Players.Add(cpu);
            }
            else
            {
                cpu.ID = 1; Players.Add(cpu);
                player.ID = 2; Players.Add(player);
            }
        }
        public Battler(Player home, Player away) 
        {
            // RPS for player 1
            Player rpsVictor; 
            do { rpsVictor = RockPaperScissors(home, away).Value; } while (rpsVictor == null);
            

            if (rpsVictor.SelectedAction == "Home") 
            {
                home.ID = 1; Players.Add(home);
                away.ID = 2; Players.Add(away);
            }
            else 
            {
                away.ID = 1; Players.Add(away);
                home.ID = 2; Players.Add(home);
            }
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
