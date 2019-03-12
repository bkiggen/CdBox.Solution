using System.Collections.Generic;

namespace CdBox.Models
{
  public class Genre
  {
    private static List<Genre> _instances = new List<Genre> { };
    private string _genre;
    private int _id;
    private List<Cd> _cds;
    public Genre(string genreName)
    {
      _genre = genreName;
      _instances.Add(this);
      _id = _instances.Count;
      _cds = new List<Cd>{ };
    }
    public string GetGenre()
    {
      return _genre;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Genre> GetAll()
    {
      return _instances;
    }
    public static Genre Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public List<Cd> GetCds()
    {
      return _cds;
    }
    public void AddCd(Cd cd)
    {
      _cds.Add(cd);
    }
  }
}
