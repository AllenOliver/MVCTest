using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApp.Models;

namespace TestApp.Services
{
    public class GameService
    {
        public List<Game> getGamesGreaterThanOne()
        {
            Games game = new Games();

            return game.Game
                .Select(x => x)
                .Where(x => x.GameID > 1)
                .OrderBy(x => x.GameName)
                .ToList();
        }

        public List<string> GetZelda()
        {
            Games game = new Games();

            return game.Game.Select(x => x.GameName).Where(x => x.Contains("Zelda")).ToList();
        }
    }
}