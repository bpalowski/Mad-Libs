using Microsoft.AspNetCore.Mvc;
using Lib.Models;

namespace Lib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    //  public string Hello() { return "Hello friend!"; }
    public ActionResult Form()
    {
      return View();
    }

    [Route("/mad_libs")]
    //  public string Hello() { return "Hello friend!"; }
    public ActionResult MadLibs()
    {
      Letter myLetter = new Letter();
      myLetter.SetRecipient(Request.Query["recipient"]);
      myLetter.SetSender(Request.Query["sender"]);
      return View(myLetter);
    }
  }
}
