using System.Linq;

namespace MidwinterConvention.CLI
{
    public class GameInfo
    {
        public BGG.itemsItem BggItem { get; set; }
        public Midwinter.Item MidwinterItem { get; set; }

        public decimal? AverageRating
        {
            get
            {
                if (BggItem == null)
                    return null;
                var indexOfStatistics = BggItem.ItemsElementName.ToList().IndexOf(BGG.ItemsChoiceType.statistics);
                var statistics = (BGG.itemsItemStatistics)BggItem.Items[indexOfStatistics];
                return statistics.ratings.bayesaverage.value;
            }
        }
    }
}
