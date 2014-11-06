using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using Core.Model;

namespace GameKeeperWeb.Controllers
{
    [Route("api/games")]
    public class GameController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Json(new List<Game>() { new Game()});
        }
    }
}