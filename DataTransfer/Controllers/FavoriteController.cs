using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using DataTransfer.Models;
using Newtonsoft.Json;

namespace DataTransfer.Controllers
{
	public class FavoriteController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			var session = new OlympicSession(HttpContext.Session);
			var model = new OlympicListViewModel
			{
				ActiveGame = session.GetActiveGame(),
				ActiveSport = session.GetActiveSport(),
				Countries = session.GetMyCountries()
			};

			return View(model);
		}
		[HttpPost]
		public RedirectToActionResult Delete()
		{
			var session = new OlympicSession(HttpContext.Session);
			var cookies = new OlympicCookies(Response.Cookies);

			session.RemoveMyCountries();
			cookies.RemoveMyCountryIds();

			TempData["message"] = "Favorite countries cleared";

			return RedirectToAction("Index", "Home",
				new
				{
					ActiveGame = session.GetActiveGame(),
					ActiveSport = session.GetActiveSport()
				});
		}
	}
}
