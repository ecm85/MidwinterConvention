using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidwinterConvention.CLI
{
    public class GameInfo
    {
        public BGG.itemsItem BggItem { get; set; }
        public Item MidwinterItem { get; set; }

        public decimal? AverageRating
        {
            get
            {
                if (BggItem == null)
                    return null;
                var indexOfStatistics = BggItem.ItemsElementName.ToList().IndexOf(BGG.ItemsChoiceType.statistics);
                var statistics = (BGG.itemsItemStatistics)BggItem.Items[indexOfStatistics];
                return statistics.ratings.average.value;
            }
        }
    }
}
