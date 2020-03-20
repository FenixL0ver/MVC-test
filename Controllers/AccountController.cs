using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryOut.Models;

namespace TryOut.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [Authorize]
        public ActionResult Welcome(Participant model)
        {
            return View(model);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Participant model)
        {
            if(ModelState.IsValid)
            {
                using (var context = new ChampionsContext())
                {
                    var participant = context.Participants.FirstOrDefault(user => user.Login == model.Login);
                    if (participant != null)
                    {
                        return RedirectToAction("Welcome", participant as Participant);
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Signup()
        {
            var r = new Random();
            ViewBag.ID = r.Next();
            return View();
        }

        [HttpPost]
        public ActionResult Signup(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                using (var context = new ChampionsContext())
                {
                    context.Participants.Add(model);
                    context.SaveChanges();
                    return RedirectToAction("Welcome", model);
                }
            }
            return View();
        }
    }
}