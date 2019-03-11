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
    [TestMethod]
    public void GetArtist_ReturnsArtist_String()
    {
      string artist = "David Bowie";
      Cd newCd = new Cd(artist, "Low");
      string result = newCd.GetArtist();
      Assert.AreEqual(artist, result);
    }
    [TestMethod]
    public void GetAlbum_ReturnsAlbum_String()
    {
      string album = "Low";
      Cd newCd = new Cd("David Bowie", album);
      string result = newCd.GetAlbum();
      Assert.AreEqual(album, result);
    }
    [TestMethod]
    public void GetAll_ReturnsCds_CdList()
    {
      string artist1 = "Can";
      string album1 = "Monster Movie";
      string artist2 = "Nirvana";
      string album2 = "Bleach";
      Cd newCd1 = new Cd(artist1, album1);
      Cd newCd2 = new Cd(artist2, album2);
      List<Cd> newCdList = new List<Cd> { newCd1, newCd2 };
      List<Cd> result = Cd.GetAll();
      CollectionAssert.AreEqual(newCdList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectCd_Cd()
    {
      string artist1 = "Can";
      string album1 = "Monster Movie";
      string artist2 = "Nirvana";
      string album2 = "Bleach";
      Cd newCd1 = new Cd(artist1, album1);
      Cd newCd2 = new Cd(artist2, album2);
      List<Cd> newCdList = new List<Cd> { newCd1, newCd2 };
      Cd result = Cd.Find(2);
      Assert.AreEqual(newCd2, result);
    }
  }
}
