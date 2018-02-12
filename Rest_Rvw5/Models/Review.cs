using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rest_Rvw5.Models
{
  public class Review
  {
    [Key]
    public int ReviewId { get; set; }
    [ForeignKey("ApplicationUser")]
    public string UserId { get; set; }
    [ForeignKey("Restaurant")]
    public int RestaurantId { get; set; }
    public DateTime ReviewDate { get; set; }
    public string ReviewTitle { get; set; }
    public float OverallRating { get; set; }
    public virtual ApplicationUser ApplicationUser { get; set; }
    public virtual Restaurant Restaurant { get; set; }

    public Review()
    {
      ReviewId =            0;
      UserId =        "";
      RestaurantId =  0;
      ReviewDate =    new DateTime();
      ReviewTitle =   "";
      OverallRating = 0.0f;
    }

    public Review(int reviewId, string userId, int restaurantId, DateTime reviewDate, string reviewTitle, float overallRating)
    {
      ReviewId =            reviewId;
      UserId =        userId;
      RestaurantId =  restaurantId;
      ReviewDate =    reviewDate;
      ReviewTitle =   reviewTitle;
      OverallRating = overallRating;
    }
  }
}