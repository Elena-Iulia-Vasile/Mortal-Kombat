

using ArenaGame;
using Fighter;

namespace Battle_Game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Console.WriteLine("Welcome to the game, players!\n");
            var FightersList = new List<BaseFighter>();
            string? choice = null;
            Console.WriteLine("Who do you want to be your player?\nIf you want to be Jax - press j;\nif you want to be Scorpion - press n;\nif you want to be Sonya - press s;\nif you want to be Warrior - press w");
            try
            {
                choice = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            CreateFighters(choice, FightersList);

            string[] choices = { "j", "n", "s", "w", "d" };
            Random rand = new Random();
            int randomNumber = rand.Next(choices.Length);

            CreateFighters(choices[randomNumber], FightersList);

            var game = new Arena(FightersList);
            game.StartGame();

            Console.ReadKey();

        }

        private static void CreateFighters(string choice, List<BaseFighter> FightersList)
        {
            switch (choice)
            {
                case "j":
                    var fighterJax = new Jax("Jax");
                    FightersList.Add(fighterJax);
                    break;
                case "n":
                    var fighterScorpion = new Scorpion("Scorpion", 110);
                    FightersList.Add(fighterScorpion);
                    break;
                case "s":
                    var fighterSonya = new Sonya("Sonya", 98);
                    FightersList.Add(fighterSonya);
                    break;
                case "w":
                    var fighterWarrior = new Warrior("Warrior", 6);
                    FightersList.Add(fighterWarrior);
                    break;
                default:
                    var fighter = new FighterBasic("Fighter");
                    FightersList.Add(fighter);
                    break;
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"An exception unexpected was catched: {e.ExceptionObject}");
        }
    }
}