using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void LoafCount_ReturnsNumberOfLoavesPurchased_Int()
    {
      int loafCount = 2;
      Bread newBread = new Bread(loafCount);
      Assert.AreEqual(loafCount, newBread.LoafCount);
    }

    [TestMethod]
    public void BreadCost_ReturnsCostOfZeroLoavesPurchased_Int()
    {
      int loafCount = 0;
      Bread newBread = new Bread(loafCount);
      Assert.AreEqual(0, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadCost_ReturnsCostOfOneOrTwoLoavesPurchased_Int()
    {
      int loafCount = 2;
      Bread newBread = new Bread(loafCount);
      Assert.AreEqual(10, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadCost_ReturnsCostIfDivisibleByThree_Int()
    {
      int loafCount = 6;
      Bread newBread = new Bread(loafCount);
      Assert.AreEqual(20, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadCost_ReturnsCostIfNotDivisibleByThree_Int()
    {
      int loafCount = 5;
      Bread newBread = new Bread(loafCount);
      Assert.AreEqual(20, newBread.BreadCost());
    }
  }
} 