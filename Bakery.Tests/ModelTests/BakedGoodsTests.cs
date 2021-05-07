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
    public void BreadClass_CreatesInstanceOfBread_Bread()
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
    // Tests
  }
}