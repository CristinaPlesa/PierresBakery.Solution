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
      _price = price;
    }

    public int SetBreadPrice(int userNumberOfLoaves)
    {
      for(int i = 1; i <= userNumberOfLoaves; i++)
      {
        if (i % 3 == 0)
        {
          Price += 0;
        }
        else
        {
          Price += 5;
        }
      }
      return Price;
    }
  }

  public class Pastry
  {
    public string PastryName { get ; }
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

    public Pastry(string pastryName, string description, int price)
    {
      PastryName = pastryName;
      Description = description;
      _price = price;
    }

    public int SetPastryPrice(int userNumberOfPastries)
    {
      for(int i = 1; i <= userNumberOfPastries; i++)
      {
        if (i % 3 == 0)
        {
          Price += 1;
        }
        else
        {
          Price += 2;
        }
      }
      return Price;
    }
  }
}