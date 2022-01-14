using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PierresTreats.Models;
using System.Threading.Tasks;
using PierresTreats.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace PierresTreats.Controllers
{
  public class AccountController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, PierresTreatsContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
    
    public async Task<ActionResult> Details()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      return View(currentUser);
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model)
    {
      var user = new ApplicationUser { UserName = model.UserName, Email = model.Email };  
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);

      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else 
      {
        return View();
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    public ActionResult LogOff()
    {
      return View();
    }

    [HttpPost, ActionName("LogOff")]
    public async Task<ActionResult> LogOffConfirmed()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}