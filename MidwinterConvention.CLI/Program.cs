﻿using System;
using System.Linq;

namespace MidwinterConvention.CLI
{
    class Program
    {
        static void Main()
        {
            var gameService = new GameService();
            var gameInfos = gameService.GetAllGames().ToList();

            Console.WriteLine("Play to Win Games");
            Console.WriteLine("--------------------------------------------------");
            var freeToPlayItems = gameInfos
                .Where(gameInfo => gameInfo.MidwinterItem.is_play_to_win == 1)
                .OrderByDescending(gameInfo => gameInfo.BggRating)
                .ToList();
            foreach (var freeToPlayItem in freeToPlayItems)
            {
                PrintGameInfo(freeToPlayItem);
            }

            Console.WriteLine();
            Console.WriteLine("Non-Play to Win Games");
            Console.WriteLine("--------------------------------------------------");
            var nonFreeToPlayItems = gameInfos
                .Except(freeToPlayItems)
                .OrderByDescending(gameInfo => gameInfo.BggRating);
            foreach (var nonFreeToPlayItem in nonFreeToPlayItems)
            {
                PrintGameInfo(nonFreeToPlayItem);
            }
        }

        private static void PrintGameInfo(GameInfo gameInfo)
        {
            if (gameInfo.BggRating == null)
            {
                Console.WriteLine(gameInfo.MidwinterItem.name + " - NO BGG ID!!!");
            }
            else
            {
                Console.WriteLine(gameInfo.MidwinterItem.name + " - " + gameInfo.BggRating);
            }
        }
    }
}
