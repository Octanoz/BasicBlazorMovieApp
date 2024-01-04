namespace BasicBlazorMovieApp.Models;

public class MovieModel(int id, string title, string description, string imageUrl, string review)
{
    public int Id { get; } = id;
    public string Title { get; } = title;
    public string Description { get; } = description;
    public string ImageUrl { get; } = imageUrl;
    public string Review { get; } = review;
}
