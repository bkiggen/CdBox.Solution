using Microsoft.AspNetCore.Mvc;
using CdBox.Models;
using System.Collections.Generic;

namespace CdBox.Controllers
{
  public class CdsController : Controller
  {
    [HttpGet("/genres/{genreId}/cds/new")]
    public ActionResult New(int genreId)
    {
      Genre genre = Genre.Find(genreId);
      return View(genre);
    }
    [HttpPost("/cds/delete")]
    public ActionResult DeleteAll()
    {
      Cd.ClearAll();
      return View();
    }
    [HttpGet("/genres/{genreId}/cds/{cdId}")]
    public ActionResult Show(int genreId, int cdId)
    {
      Cd cd = Cd.Find(cdId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Genre genre = Genre.Find(genreId);
      model.Add("cd", cd);
      model.Add("genre", genre);
      return View(model);
    }
  }
}
