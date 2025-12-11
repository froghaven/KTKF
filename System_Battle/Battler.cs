


using System.Numerics;

namespace System_Battle
{



    public class Battler
    {
        // TODO : Hookup RPS System For Actual Player Input and Selection 

        public FieldManager Field;

        public int FormationLimit { get; set; }


        public List<Player> Players = new List<Player>();
        Player Player1; 
        Player Player2; 


        public static List<string> COMessages = new List<string>() 
        {
            "KTK! : Rock, Paper, Scissors! The Winner Decides Who Plays First!",
            " Shoot Again!",
            " IS THE VICTOR !!!",
            "Choose Who Will Go First!",
            // 0 - 3

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


            Console.WriteLine(COMessages[3]);
            if (rpsVictor.SelectedAction == "Player")
            {
                Player1 = player; Player1.ID = 1;
                Player2 = cpu; Player2.ID = 2;  
            }
            else
            {
                Player1 = cpu; Player1.ID = 1; 
                Player2 = player; Player2.ID = 2; 
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


            Console.WriteLine(COMessages[3]);
            if (rpsVictor.SelectedAction == "Home")
            {
                Player1 = home; Player1.ID = 1;
                Player2 = away; Player2.ID = 2;
            }
            else
            {
                Player1 = away; Player1.ID = 1;
                Player2 = home; Player2.ID = 2;
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


        public void FormationSetup_Phase()
        {
            Console.WriteLine(COMessages[4]);

            Field = new FieldManager(Player1, Player2);

            Field.SetupFormation(); 

            // Field Sends Layout Query For King To Player
            // Player Completes Query With Selected Action 
            // Field Updates Player Formation
            // P1 layout King 



            // P2 layout King 

            // While Formation is NOT FULL
            // P1 layout Guardian // Manage Turn // Update Field
            // P2 layout Guardian // Manage Turn // Update Field

            // P1 sends enviro cards to share pile
            // P2 sends enviro cards to share pile

            // Shuffle p1 Deck
            // Shuffle p2 Deck
            // Shuffle Enviro Deck
        }


        public void Battle_Phase()
        {
            
        }  


        public void MatchEnd_Phase() 
        { 
        
        }

    }
}
