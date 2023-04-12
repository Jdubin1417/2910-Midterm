namespace MidtermReview
{
    public interface IVideoGame
    {
        string Title { get; set; }
        Rating Rating { get; set; }
        double RetailPrice { get; set; }
    }
}
