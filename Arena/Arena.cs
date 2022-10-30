using Fighter;
namespace ArenaGame
{
    public class Arena
    {
        public List<BaseFighter> Fighters { get; set; }

        public Arena()
        {
            Console.WriteLine("You just entered the game!");
        }

        public Arena(List<BaseFighter> fighters)
        {
            Fighters = fighters;
            Console.WriteLine("You just entered the game!");
            Console.WriteLine($"You are {Fighters[0].Name} and your opponent is {Fighters[1].Name}\n");
        }
        public void StartGame()
        {
            Console.WriteLine($"Start fight! {Fighters[0].Name} you start!");
            string? choice;
            Random random = new Random();
            int randomNumber;
            string[] typesOfHits = { "h", "p", "d", "k", "s" };
            do
            {
                Console.WriteLine("Player - you can choose: Hit - press h; Punch - press p; DoubleHit - press d; Kick - press k; SpecialAbillity - press s");
                choice = null;
                Console.WriteLine("Type the wanted type of hit.");
                try
                {
                    choice = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                ChoiceTypeOfHit(choice, 0, 1);

                Console.WriteLine("It's opponent turn!");
                randomNumber = random.Next(typesOfHits.Length);
                ChoiceTypeOfHit(typesOfHits[randomNumber], 1, 0);
            }
            while (EndGame());
        }

        public static string Winner(List<BaseFighter> fighters)
        {
            string winner;
            if (fighters[0].Life > fighters[1].Life)
            {
                winner = $"you, {fighters[0].Name}";
            }
            else
            {
                winner = $"your opponent, {fighters[1].Name}";
            }

            return winner;
        }

        public bool EndGame()
        {
            if (Fighters[0].HealthPoints <= 0 || Fighters[1].HealthPoints <= 0 || Fighters[0].Life <= 0 || Fighters[1].Life <= 0)
            {
                Console.WriteLine($"The game has ended! We have a winner! The winner is {Winner(Fighters)}");
                return false;
            }
            else
                return true;
        }

        private void ChoiceTypeOfHit(string choice, int i, int j)
        {
            switch (choice)
            {
                case "h":
                    Fighters[i].Hit(Fighters[j]);
                    break;
                case "p":
                    Fighters[i].Punch(Fighters[j]);
                    break;
                case "d":
                    Fighters[i].DoubleHit(Fighters[j]);
                    break;
                case "k":
                    Fighters[i].Kick(Fighters[j]);
                    break;
                case "s":
                    Fighters[i].SpecialAbillity(Fighters[j]);
                    break;
                default:
                    Console.WriteLine("You didn't made a right decision so you lost your turn!\n");
                    break;
            }
        }

    }
}
