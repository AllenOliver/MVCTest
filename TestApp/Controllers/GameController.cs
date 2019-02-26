using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;
using TestApp.Services;

namespace TestApp.Controllers
{
    public class GameController : Controller
    {
        private GameService gs = new GameService();

        // GET: Game
        public ActionResult Index()
        {
            ViewBag.Message = "This is the Games page!!";
            ViewBag.Title = "Games Page";

            //var allGames = game.Game.Select(x => x).ToList();
            var filteredGames = gs.getGamesGreaterThanOne();
            return View(filteredGames);
        }

        public List<string> returnZelda()
        {
            return gs.GetZelda();
        }
    }
}