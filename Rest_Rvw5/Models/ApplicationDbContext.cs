using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Reflection.Emit;

namespace Rest_Rvw5.Models
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext()
      : base("DefaultConnection", throwIfV1Schema: false)
    {      
    }

    public static ApplicationDbContext Create()
    {
      return new ApplicationDbContext();
    }

    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<WebSiteComment> WebSiteComments { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<AnswerOpt> AnswerOpts { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<ApplicationRole> IdentityRoles { get; set; }
  }
}