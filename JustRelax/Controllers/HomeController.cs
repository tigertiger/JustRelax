using Microsoft.AspNetCore.Mvc;

namespace JustRelax.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() 
    { 
      return View(); 
    }

    public ActionResult Create()
    {
      return View();
    }
  }

}