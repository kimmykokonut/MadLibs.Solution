using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers 
{
  public class HomeController : Controller
  {
    [Route("/hello")]

    public string Hello() { return "Hello Friend!"; }

    [Route("/")]
    public string Story() { return "story here"; }

    // [Route"/form"]
    // public string Form() { return View(); }
  }
}