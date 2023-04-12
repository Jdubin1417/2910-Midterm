namespace MidtermReview
{
    public class FileRoot
    {
        public static string root =
            Directory.GetParent(Directory.GetCurrentDirectory())
            .Parent
            .Parent
            .ToString();
    }
}
