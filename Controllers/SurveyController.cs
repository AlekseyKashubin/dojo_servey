using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


// Be sure to use your own project's namespace here! 
namespace dojo_survey.Controllers;

public class SurveyController : Controller   // Remember inheritance?    
{


    [HttpGet("")]
    public ViewResult Index()
    {

        return View();
    }

    [HttpPost("results")]
    public ViewResult Results(string Name, string Location, string FavLang, string Comment)
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.FavLang = FavLang;
        ViewBag.Comment = Comment;

        return View("results");
    }

}