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
  }
} 