using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rest_Rvw5.Models
{
  public class WebSiteComment
  {
    public int Id { get; set; }
    [ForeignKey("ApplicationUser")]
    public string UserId { get; set; }
    public DateTime Date { get; set; }
    public string Comment { get; set; }
    public virtual ApplicationUser ApplicationUser { get; set; }

    public WebSiteComment()
    {
      Id = 0;
      UserId =   "";
      Date =      DateTime.Now;
      Comment =   "";
    }

    public WebSiteComment(int commentId, string userID, string comment, DateTime? date = null)
    {
      Id =        commentId;
      UserId =    userID;
      Date =      date ?? DateTime.Now;
      Comment =   comment;
    }
  }
}