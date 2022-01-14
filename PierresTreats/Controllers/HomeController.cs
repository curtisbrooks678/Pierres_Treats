using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace PierresTreats.Controllers
{
  public class HomeController : Controller
  {
    [Authorize]
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}