using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using DataTransfer.Models;

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        private OlympicContext context;
        public HomeController(OlympicContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index(OlympicListViewModel model, string activeGame = "all", string activeSport = "All")
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGame(activeGame);
            session.SetActiveSport(activeSport);

            int? count = session.GetMyCountryCount();
            if (count == null)
			{
                var cookies = new OlympicCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();

                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
				{
                    mycountries = context.Countries.Include(testc => testc.Game)
                        .Include(t => t.Sport)
                        .Where(t => ids.Contains(t.CountryID)).ToList();
				}
                session.SetMyCountries(mycountries);
			}

            model.Games = context.Games.ToList();
            model.Sports = context.Sports.ToList();

            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(t => t.Game.GameID.ToLower() == activeGame.ToLower());
            if (activeSport != "all")
                query = query.Where(t => t.Sport.SportID.ToLower() == activeSport.ToLower());
            model.Countries = query.ToList();
            return View(model);
        }
        
        // Uses session
        [HttpGet]
        public ViewResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new OlympicViewModel
            {
                Country = context.Countries
                    .Include(t => t.Game)
                    .Include(t => t.Sport)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveSport = session.GetActiveGame(),
                ActiveGame = session.GetActiveSport()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(OlympicViewModel model)
		{
            model.Country = context.Countries
                .Include(t => t.Game)
                .Include(t => t.Sport)
                .Where(t => t.CountryID == model.Country.CountryID)
                .FirstOrDefault();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            /*creates new OlympicCookies object with the controller's response object.
             * calls SetMyCountryIds and passes updated list of Country objects. 
             */
            var cookies = new OlympicCookies(Response.Cookies);
            cookies.SetMyCountryIds(countries);

            TempData["message"] = $"{model.Country.CountryName} added to your favorites";  //message

            return RedirectToAction("Index",    //redirection
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveSport = session.GetActiveSport()
                });
		}
    }
}
