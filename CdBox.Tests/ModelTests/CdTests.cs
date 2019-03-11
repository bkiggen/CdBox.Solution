using Microsoft.VisualStudio.TestTools.UnitTesting;
using CdBox.Models;
using System.Collections.Generic;
using System;

namespace CdBox.Tests
{
  [TestClass]
  public class CdTest : IDisposable
  {
    public void Dispose()
    {
      Cd.ClearAll();
    }
    [TestMethod]
    public void CdConstructor_CreatesInstanceOfCd_Cd()
    {
      Cd newCd = new Cd("test", "test");
      Assert.AreEqual(typeof(Cd), newCd.GetType());
    }
  }
}
