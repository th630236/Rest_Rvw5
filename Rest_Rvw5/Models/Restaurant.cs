using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rest_Rvw5.Models
{
  public class Restaurant
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public bool Pending { get; set; }
    public DbSet<Review> Reviews { get; set; }


    public Restaurant()
    {
      Id =           0;
      Name =         "";
      Address =      "";
      City =         "";
      State =        "";
      Pending =      true;
    }

    public Restaurant(int restaurantId, string name, string address, string city, string state, bool pending)
    {
      Id =           restaurantId;
      Name =         name;
      Address =      address;
      City =         city;
      State =        state;
      Pending =      pending;
    }
  }
}