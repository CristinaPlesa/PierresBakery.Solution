using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadClass_CreatesClassForBread_Bread()
    {
      // Arrange/Act
      Bread newBread = new Bread("test", "test", 5);
      // Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Bread_CreatesInstanceOfBread_Bread()
    {
      // Arrange
      string testBreadName = "Colac";
      string testDescription = "Traditional Romanian sweet bread. It is made from whole wheat flour and is braided in a circle. Traditionally this bread is made for special occasions, but we make it fresh daily!";
      int testPrice = 5;
      //Act
      Bread newBread = new Bread(testBreadName, testDescription, testPrice);
      // Assert
      Assert.AreEqual(testBreadName, newBread.BreadName);
      Assert.AreEqual(testDescription, newBread.Description);
      Assert.AreEqual(testPrice, newBread.Price);
    }

    [TestMethod]
    public void SetBreadPrice_ReturnsCorrectPriceForMultipleInputtedLoaves_Price()
    {
      // Arrange
      string testBreadName = "Colac";
      string testDescription = "Traditional Romanian sweet bread. It is made from whole wheat flour and is braided in a circle. Traditionally this bread is made for special occasions, but we make it fresh daily!";
      int testPrice = 0;
      Bread newBread = new Bread(testBreadName, testDescription, testPrice);
      int userNumberOfLoaves = 3;
      //Act
      int userPriceOf3Loaves = 10;
      int result = newBread.SetBreadPrice(userNumberOfLoaves);
      // Assert
      Assert.AreEqual(userPriceOf3Loaves, result);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryClass_CreatesClassForPastries_Pastry()
    {
      // Arrange/Act
      Pastry newPastry = new Pastry("test", "test", 2);
      // Assert
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void Pastry_CreatesInstanceOfPastry_Pastry()
    {
      // Arrange
      string testPastryName = "Galuste cu Prune";
      string testDescription = "Traditional Romanian dessert. It is made with prunes that are wrapped in potato dough and rolled in bread crumbs. They are served with dipping sugar. We make them fresh daily!";
      int testPrice = 2;
      //Act
      Pastry newPastry = new Pastry(testPastryName, testDescription, testPrice);
      // Assert
      Assert.AreEqual(testPastryName, newPastry.PastryName);
      Assert.AreEqual(testDescription, newPastry.Description);
      Assert.AreEqual(testPrice, newPastry.Price);
    }
  }
}