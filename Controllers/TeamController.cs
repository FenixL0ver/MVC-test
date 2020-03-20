using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryOut.Models;

namespace TryOut.Controllers
{
    public class TeamController : Controller
    {

        public ActionResult Home(Team model)
        {
            return View(model);
        }

        // GET: Team
        [HttpGet]
        public ActionResult CreateTeam ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTeam(Team model)
        {
            if(ModelState.IsValid)
            {
                Team team = null;
                using (ChampionsContext context = new ChampionsContext())
                {
                  team = context.Teams.FirstOrDefault(club => club.Name == model.Name);
                }
                if (team == null)
                {
                    using (ChampionsContext context = new ChampionsContext())
                    {
                        context.Teams.Add(model);
                        context.SaveChanges();
                        return RedirectToAction("Home", model);
                    }
                }
            }
            return View(model);
        }
    }
}