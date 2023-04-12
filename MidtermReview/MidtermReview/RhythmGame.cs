using System.Transactions;

namespace MidtermReview
{
    public class RhythmGame : VideoGame, IComparable<RhythmGame>
    {
        public string? ComposerFirstName { get; set; }
        public string? ComposerLastName { get; set; } = string.Empty;

        public RhythmGame(string title, Rating rating, double retailPrice, 
            string fName, string? lName = ""): base(title, rating, retailPrice)
        {
            ComposerFirstName = fName;
            ComposerLastName = lName;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nComposer:\t{ComposerFirstName} {ComposerLastName}";
        }

        public int CompareTo(RhythmGame? other)
        {
            if (this.RetailPrice > other.RetailPrice) return 1;
            else if (this.RetailPrice < other.RetailPrice) return -1;
            else return 0;
        }
    }
}
