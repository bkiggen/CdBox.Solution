using System.Collections.Generic;

namespace CdBox.Models
{
  public class Cd
  {
    private string _artist;
    private string _album;
    private static List<Cd> _instances = new List<Item> { };

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
    public void SetArtist(string newDescription)
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
  }
}
