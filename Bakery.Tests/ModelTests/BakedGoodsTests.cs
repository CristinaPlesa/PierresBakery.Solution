using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BakedGoodsTests
  {
    [TestMethod]
    public void BakedGoodsConstructor_CreatesInstanceOfBakedGoods_BakedGoods()
    {
      // Arrange/Act
      BakedGoods newBakedGoods = new BakedGoods();
      // Assert
      Assert.AreEqual(typeof(BakedGoods), newBakedGoods.GetType());
    }
    // Tests
  }
}