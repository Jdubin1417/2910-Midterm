namespace MidtermReview
{
    public class VideoGame : IVideoGame, IComparable<VideoGame>
    {
        public string? Title { get; set; } = string.Empty;
        public Rating Rating { get; set; }
        public double RetailPrice { get; set; }

        // "backing field"
        private string _password;
        public string Password
        {
            get {  return _password; }
            set { _password = value; }
        }

        public VideoGame() { }

        public VideoGame(string? title, Rating rating, double retailPrice)
        {
            Title = title;
            Rating = rating;
            RetailPrice = retailPrice;
            Password = "1";
        }

        public VideoGame(VideoGame game)
        {
            // todo: deep copy
        }


        public override string ToString()
        {
            return
                $"Title:\t\t{Title}\n" +
                $"Rating:\t\t{Rating}\n"+
                $"Retail Price:\t{RetailPrice.ToString("c")}";
        }

        protected bool IsItCheap()
        {
            if (RetailPrice < 10)
                return true;
            else
                return false;
        }

        public int CompareTo(VideoGame? other)
        {
            if (this.RetailPrice > other.RetailPrice) return 1;
            else if (this.RetailPrice < other.RetailPrice) return -1;
            else return 0;
        }
    }
}
