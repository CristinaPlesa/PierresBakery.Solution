using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      // Arrange/Act
      Bread newBread = new Bread();
      // Assert
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    // Tests
  }
}