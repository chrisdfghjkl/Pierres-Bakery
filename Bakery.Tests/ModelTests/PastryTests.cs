using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryCount_ReturnsNumberOfPastriesPurchased_Int()
    {
      int pastryCount = 2;
      Pastry newPastry = new Pastry(pastryCount);
      Assert.AreEqual(pastryCount, newPastry.PastryCount);
    }

    [TestMethod]
    public void PastryCost_ReturnCostUpToTwoPastries_Int()
    {
      int pastryCount = 2;
      Pastry newPastry = new Pastry(pastryCount);
      Assert.AreEqual(4, newPastry.PastryCost());
    }
  }
}