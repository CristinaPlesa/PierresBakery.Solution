using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\nWelcome to Pierre's Bakery!");
  
      Console.WriteLine("\n" + @"Today's Bread of the Day: Colac" +
      "\nDescription: Traditional Romanian sweet bread. It is made from whole wheat flour and is braided in a circle. Traditionally this bread is made for special occasions, but we make it fresh daily!" +
      "\nPrice: $5 each, or buy two get one free!");

      Console.WriteLine("\n" + @"Today's Pastry of the Day: Galuste cu Prune" +
      "\nDescription: Traditional Romanian dessert. It is made with prunes that are wrapped in potato dough and rolled in bread crumbs. They are served with dipping sugar. We make them fresh daily!" +
      "\nPrice: $2 each, or get 3 for $5!");

      Console.WriteLine("\nHow many Loaves of Bread would you like to buy?");
      int userNumberOfLoaves = Int32.Parse(Console.ReadLine());

      Console.WriteLine("How many Pastries would you like buy?");
      int userNumberOfPastries = Int32.Parse(Console.ReadLine());

      Console.WriteLine("\nThank you for shopping at Pierre's Bakery!");

      Bread newBread = new Bread("Colac", "Traditional Romanian sweet bread. It is made from whole wheat flour and is braided in a circle. Traditionally this bread is made for special occasions, but we make it fresh daily!", 0);
      Console.WriteLine("\nTotal price for your Loaves: $");
      Console.WriteLine(newBread.SetBreadPrice(userNumberOfLoaves));

      Pastry newPastry = new Pastry("Galuste cu Prune", "Traditional Romanian dessert. It is made with prunes that are wrapped in potato dough and rolled in bread crumbs. They are served with dipping sugar. We make them fresh daily!", 0);
      Console.WriteLine("\nTotal price for your Pastries: $");
      Console.WriteLine(newPastry.SetPastryPrice(userNumberOfPastries));

      Console.WriteLine("\nTotal price for your order: $");
      Console.WriteLine(newBread.Price + newPastry.Price);
    }
  }
}