using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadName { get ; }
    public string Description { get ; }
    public int Price { get; }
    // { 
    //   get
    //   {
    //     return Price;
    //   }
    //   set
    //   {
    //     Price = value;
    //   }
    // }

    public Bread(string breadName, string description, int price)
    {
      BreadName = breadName;
      Description = description;
      Price = price;
    }

    // public int GetBreadPrice(int userNumberOfLoaves)
    // {
    //   // return (Price * userNumberOfLoaves);
    //   // will actually have to have if conditional, given that there is a buy 2 get 1 free deal. Each loaf costs $5.
    // }
  }

  // public class Pastry. Do the same for this class, create constructor, then create a few new object instances of different pastries. Must test bread one first tho. Will it work to have two classes in the same file?

  // Like in To Do example do I have to create a list in order to be able to access multiple fields in constructor? Specifically in testing.
}