using System.Collections.Generic;

namespace CdBox.Models
{
  public class Cd
  {
    private string _artist;
    private string _album;
    private int _id;
    private static List<Cd> _instances = new List<Cd> { };

    public Cd(string artist, string album)
    {
      _artist = artist;
      _album = album;
      _id = _instances.Count;
      _instances.Add(this);
    }

    public string GetArtist()
    {
      return _artist;
    }
    public string GetAlbum()
    {
      return _album;
    }
    public void SetArtist(string artist)
    {
      _artist = artist;
    }
    public static List<Cd> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Cd Find(int id)
    {
      return _instances[id];
    }
    public int GetId()
    {
      return _id;
    }
  }
}
