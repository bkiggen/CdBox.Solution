using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CdBox.Models;

namespace CdBox.Controllers
{
  public class GenresController : Controller
  {
    [HttpGet("/genres")]
    public ActionResult Index()
    {
      List<Genre> allGenres = Genre.GetAll();
      return View(allGenres);
    }
    [HttpGet("/genres/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/genres")]
    public ActionResult Create(string genreName)
    {
      Genre newGenre = new Genre(genreName);
      List<Genre> allGenres = Genre.GetAll();
      return View("Index", allGenres);
    }
    [HttpPost("/genres/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Genre selectedGenre = Genre.Find(id);
      List<Cd> genreItems = selectedGenre.GetCds();
      model.Add("genre", selectedGenre);
      model.Add("cds", genreItems);
      return View(model);
    }
    [HttpPost("/genres/{genreId}/cds")]
    public ActionResult Create(int genreId, string cdArtist, string cdAlbum)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Genre foundGenre = Genre.Find(genreId);
      Cd newCd = new Cd(cdArtist, cdAlbum);
      foundGenre.AddCd(newCd);
      List<Cd> genreCds = foundGenre.GetCds();
      model.Add("cds", genreCds);
      model.Add("genre", foundGenre);
      return View("Show", model);
    }
  }
}
