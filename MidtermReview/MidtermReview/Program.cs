using System.Text.Json;

namespace MidtermReview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RhythmGameStuff();
        }

        static void DiceStuff()
        {
            bool isValidNum = false;
            int sides = 0;
            do
            {
                try
                {
                    // Ask the user for the # sides
                    Console.Write("Enter the number of sides you want your die to have: ");
                    // We need to parse (convert) the string from ReadLine() to a number
                    sides = int.Parse(Console.ReadLine());
                    isValidNum = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input. Please try again...\n");
                }
            } while (!isValidNum);

            var die = new Random().Next(1, sides + 1);

            // + <-- concatenation operator
            Console.WriteLine("The value rolled on the d" + sides + " was a " + die + ".");

            // $ <--  interpolation operator
            // {} <-- value(s) will go inside curly braces
            Console.WriteLine($"The value rolled on the d{sides} was a {die}.");
        }

        static void VideoGameStuff()
        {
            const double SALES_TAX = .095;

            var banger = new VideoGame("Elden Ring", Rating.M, 59.987654321);
            Console.WriteLine(banger);
            Console.WriteLine();

            var bop = new RhythmGame("Rhythm Heaven", Rating.E, 49.99, "Tsunku");
            Console.WriteLine(bop);
            Console.WriteLine();

            banger.RetailPrice = banger.RetailPrice + (banger.RetailPrice * SALES_TAX);
            Console.WriteLine($"{banger.Title}'s price after tax is {banger.RetailPrice.ToString("c")}");

            Console.WriteLine();
            Console.WriteLine($"{banger.Title} has a password of {banger.Password}");

            // named arguments
            var gameTotal = GameCheckOut(salesTax: SALES_TAX, numGames: 4, gamePrice: 19.99);
        }

        static void RhythmGameStuff()
        {
            List<VideoGame> games = new List<VideoGame>()
            {
                new RhythmGame("Rhythm Heaven", Rating.E, 49.99, "Tsunku"),
                new VideoGame("Elden Ring", Rating.M, 59.987654321),
                new VideoGame("Legend of Zelda", Rating.T, 64.99),
                new RhythmGame("Clone Hero", Rating.T, 0.00, "N/A"),
                new RhythmGame("Patapon", Rating.E, 19.99, "Hiroyuki", "Katani")
            };

            games.Sort();
            foreach (var game in games)
                Console.WriteLine(game + "\n");

            var root = FileRoot.root;
            var filePath = root + "\\rhythm_games.txt";

            // calls the Dispose method automatically
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach(var game in games)
                {
                    if(game.GetType() == typeof(RhythmGame))
                    {
                        sw.WriteLine("======================================");
                        sw.WriteLine(game);                  
                    }
                }
            }
        }

        static void ArrayStuff()
        {
            string[] names = new string[]
            {
                "Bob", "James", "Joeann", "Kathy", "Stephen", "George"
            };
        }

        static double GameCheckOut(int numGames, double gamePrice, double salesTax)
        {
            var preTax = numGames * gamePrice;
            var total = preTax + (preTax * salesTax);
            return total;
        }
    
    
    }
}