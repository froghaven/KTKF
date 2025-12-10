


namespace System_Battle
{



    public class Battler
    {
        // TODO : Hookup RPS & SelectP1 System For Actual Player Input and Selection 


        public List<Player> Players = new List<Player>();

        public static List<string> COMessages = new List<string>() 
        {
            "KTK! : Rock, Paper, Scissors! The Winner Decides Who Plays First!",
            " Shoot Again!",
            " IS THE VICTOR !!!",
            "Choose Who Will Go First!", 
            "Formation Setup Phase! Place Your King!",
            "Formation Setup Phase! Fill In Your Formation!"

        };


        public Battler(Player player)
        {
            Player cpu = new Player();


            Console.WriteLine(COMessages[0]);
            Player rpsVictor;
            do {
                var rpsResults = RockPaperScissors(player, cpu);
                Console.WriteLine(rpsResults.Key);
                rpsVictor = rpsResults.Value;
            }   while (rpsVictor == null);


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
            Player rpsVictor;
            do { 
                var rpsResults = RockPaperScissors(home, away);
                Console.WriteLine(rpsResults.Key);
                rpsVictor = rpsResults.Value;
            }   while (rpsVictor == null);


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
                { "Tie!" + COMessages[1], null  },
                { "Home" + COMessages[2], home },
                { "Away" + COMessages[2], away}
            };


            if (away.SelectedAction == home.SelectedAction) { return victorKey.ElementAt(0); }
            else if (rpsKey[away.SelectedAction] == home.SelectedAction) { return victorKey.ElementAt(1); }
            else { return victorKey.ElementAt(2); }
        }


        public void EnterFormationLayoutPhase(List<Player> Players)
        {
            Console.WriteLine("Formation Layout Phase!");
        }
    }
}
