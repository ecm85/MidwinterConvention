using System.Collections.Generic;
using MidwinterConvention.CLI;

namespace MidwinterConvention.PL.Models
{
    public class MidwinterModel
    {
        public IEnumerable<GameInfo> PlayToWinGames { get; set; }
        public IEnumerable<GameInfo> NonPlayToWinGames { get; set; }
    }
}
