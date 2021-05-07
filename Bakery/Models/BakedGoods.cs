using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadName { get ; }
    public string Description { get ; }

    private int _price;
    public int Price
    { 
      get
      {
        return _price;
      }
      set
      {
        _price = value;
      }
    }

    public Bread(string breadName, string description, int price)
    {
      BreadName = breadName;
      Description = description;
      Price = price;
    }

    public int SetBreadPrice(int userNumberOfLoaves)
    {
      return (Price * userNumberOfLoaves);
    }

      // will actually have to have if conditional, given that there is a buy 2 get 1 free deal. Each loaf costs $5.
      // maybe it won't actually be a if conditional, but a loop that skips at every number divisable by 3. Similar to Mr. Roboger's project. Look to see how that one was flushed out.
  }

  // public class Pastry. Do the same for this class, create constructor, then create a few new object instances of different pastries. Must test bread one first tho. Will it work to have two classes in the same file?

  // Like in To Do example do I have to create a list in order to be able to access multiple fields in constructor? Specifically in testing.
}