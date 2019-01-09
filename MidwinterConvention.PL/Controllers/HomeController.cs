using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MidwinterConvention.CLI;
using MidwinterConvention.PL.Models;

namespace MidwinterConvention.PL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var gameService = new GameService();
            var gameInfos = gameService.GetAllGames().ToList();

            var playToWinGames = gameInfos
                .Where(gameInfo => gameInfo.MidwinterItem.is_play_to_win == 1)
                .OrderByDescending(gameInfo => gameInfo.BggRating)
                .ToList();
            var nonPlayToWinGames = gameInfos
                .Except(playToWinGames)
                .OrderByDescending(gameInfo => gameInfo.BggRating);
            var midwinterModel = new MidwinterModel
            {
                PlayToWinGames = playToWinGames,
                NonPlayToWinGames = nonPlayToWinGames
            };
            return View(midwinterModel);
        }
    }
}
