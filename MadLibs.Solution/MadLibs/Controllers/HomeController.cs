using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/hello")]

    public string Hello() { return "Hello Friend!"; }

    [Route("/")]
    public string Story() { return "story here"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/story")]
    public ActionResult Story(string properNoun, string adjective, string color, string animal, string place) //route for form data to go to
    {
        BlankVariable myBlankVariable = new BlankVariable();
        myBlankVariable.ProperNoun = properNoun;
        myBlankVariable.Adjective = adjective;
        myBlankVariable.Color = color;
        myBlankVariable.Animal = animal;
        myBlankVariable.Place = place;
        return View(myBlankVariable);
    }
  }
}