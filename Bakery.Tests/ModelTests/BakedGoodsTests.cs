using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadClass_CreatesInstanceOfBread_Bread()
    {
      // Arrange/Act
      Bread newBread = new Bread("test", "test", 0);
      // Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      // Arrange
      string breadName = "Colac";
      string description = "Traditional Romanian sweet bread. It is made from whole wheat flour and is braided in a circle. Traditionally this bread is made for special occasions, but we make it fresh daily!";
      int price = 2;
      Bread newBread = new Bread(breadName, description, price);

      //Act
      string result = newBread.breadName;
      // string actualResult = newBread.Bread(breadName, description, price);
      // string anticipatedResult = breadName, description, price;

      // Assert
      Assert.AreEqual(result, breadName);
    }
    // Tests
  }
}