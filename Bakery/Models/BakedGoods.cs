using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string BreadName { get; }
    public string Description { get; }
    public int Price { get; }

    public Bread(string breadName, string description, int price)
    {
      BreadName = breadName;
      Description = description;
      Price = price;
    }
  }

  // public class Pastry. Do the same for this class, create constructor, then create a few new object instances of different pastries. Must test bread one first tho. Will it work to have two classes in the same file?
}