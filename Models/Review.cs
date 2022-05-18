namespace BestRestaurants.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public int ReviewRating { get; set; }
    public string ReviewText { get; set; }
    public string ReviewAuthor { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}