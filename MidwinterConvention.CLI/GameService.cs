using System.Collections.Generic;
using System.Linq;

namespace MidwinterConvention.CLI
{
    public class GameService
    {
        public IEnumerable<GameInfo> GetAllGames()
        {
            var midwinterService = new MidwinterService();
            var bggService = new BggService();
            var allItems = midwinterService.GetAllItems();
            var allBggIds = allItems.Where(item => item.bgg_id != null).Select(item => item.bgg_id.Value).ToList();
            var allBggItems = bggService.GetBggItems(allBggIds);

            return allItems
                .Select(item => new GameInfo
                {
                    MidwinterItem = item,
                    BggItem = item.bgg_id == null || item.bgg_id == 0 ? null : allBggItems[(uint)item.bgg_id]
                })
                .ToList();
        }
    }
}
