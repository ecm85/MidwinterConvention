using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MidwinterConvention.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStuff();
        }

        private static void PrintStuff()
        {
            var allItems = GetAllItems();
            var allBggIds = allItems.Select(item => item.bgg_id).ToList();
            var allBggIdsParameter = string.Join(",", allBggIds);
            var allBggItems = GetBggInfo(allBggIdsParameter);
            var gameInfos = allItems
                .Select(item => new GameInfo
                {
                    MidwinterItem = item,
                    BggItem = item.bgg_id == null ? null : allBggItems[(uint) item.bgg_id]
                })
                .ToList();
            Console.WriteLine("Free To Play Games");
            Console.WriteLine("--------------------------------------------------");
            var freeToPlayItems = gameInfos
                .Where(gameInfo => gameInfo.MidwinterItem.is_play_to_win == 1)
                .OrderByDescending(gameInfo => gameInfo.AverageRating)
                .ToList();
            foreach (var freeToPlayItem in freeToPlayItems)
            {
                PrintGameInfo(freeToPlayItem);
            }

            Console.WriteLine();
            Console.WriteLine("Non-Free To Play Games");
            Console.WriteLine("--------------------------------------------------");
            var nonFreeToPlayItems = gameInfos
                .Except(freeToPlayItems)
                .OrderByDescending(gameInfo => gameInfo.AverageRating);
            foreach (var nonFreeToPlayItem in nonFreeToPlayItems)
            {
                PrintGameInfo(nonFreeToPlayItem);
            }
        }

        private static void PrintGameInfo(GameInfo gameInfo)
        {
            if (gameInfo.AverageRating == null)
            {
                Console.WriteLine(gameInfo.MidwinterItem.name + " - NO BGG ID!!!");
            }
            else
            {
                Console.WriteLine(gameInfo.MidwinterItem.name + " - " + gameInfo.AverageRating);
            }
        }

        private static IDictionary<uint, BGG.itemsItem> GetBggInfo(string bggIdParameter)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                var uri = $"https://www.boardgamegeek.com/xmlapi2/thing?id={bggIdParameter}&stats=1";
                var response = client.GetAsync(uri).Result;
                //var resultStream = response.Content?.ReadAsStreamAsync().Result;
                var bytes = response.Content?.ReadAsByteArrayAsync().Result;
                var xml = System.Text.Encoding.UTF8.GetString(bytes).Replace("\n", "");
                using (var resultStream = new StringReader(xml))
                {
                    //return xml;
                    var items = (BGG.items) new XmlSerializer(typeof(BGG.items)).Deserialize(resultStream);
                    return items.item.ToDictionary(item => item.id);
                }
            }
        }

        private static List<Item> GetAllItems()
        {
            var allItems = new List<Item>();

            using (var client = new HttpClient())
            {
                var hasMoreRecords = true;
                var currentPage = 1;
                while (hasMoreRecords)
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var uri =
                        $"https://tabletop.events/api/library/02F1333C-FD20-11E6-BDA5-1B535B1715C3/librarygames?_include_options=1&_include_relationships=1&_items_per_page=100&_order_by=name&_page_number={currentPage}&is_in_circulation=1&query=";
                    var response = client.GetAsync(uri).Result;
                    var resultText = response.Content?.ReadAsStringAsync().Result;
                    var rootobject = JsonConvert.DeserializeObject<Rootobject>(resultText);

                    var resultItems = rootobject.result.items;
                    allItems.AddRange(resultItems);
                    if (rootobject.result.paging.total_pages == currentPage)
                        hasMoreRecords = false;
                    currentPage++;
                }
            }

            return allItems;
        }
    }

    public class Rootobject
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public Item[] items { get; set; }
        public Paging paging { get; set; }
    }

    public class Paging
    {
        public int items_per_page { get; set; }
        public int next_page_number { get; set; }
        public int previous_page_number { get; set; }
        public string page_number { get; set; }
        public int total_pages { get; set; }
        public int total_items { get; set; }
    }

    public class Item
    {
        public _Relationships _relationships { get; set; }
        public string catalog_number { get; set; }
        public int is_in_circulation { get; set; }
        public int age { get; set; }
        public string date_updated { get; set; }
        public int is_play_to_win { get; set; }
        public string uri_part { get; set; }
        public int missing_components { get; set; }
        public string name { get; set; }
        public int average_seconds_checked_out { get; set; }
        public int checkout_count { get; set; }
        public int missing_instructions { get; set; }
        public object condition_notes { get; set; }
        public string object_type { get; set; }
        public int box_unacceptable { get; set; }
        public _Options _options { get; set; }
        public object notes { get; set; }
        public int max_play_time { get; set; }
        public string last_checkin_date { get; set; }
        public int max_players { get; set; }
        public string date_created { get; set; }
        public string overall_condition { get; set; }
        public Custom_Fields custom_fields { get; set; }
        public string lastcheckout_id { get; set; }
        public int game_weight { get; set; }
        public int min_play_time { get; set; }
        public int due_for_triage { get; set; }
        public string id { get; set; }
        public string view_uri { get; set; }
        public int? bgg_id { get; set; }
        public int min_players { get; set; }
        public string library_id { get; set; }
        public string description { get; set; }
        public string last_checkout_date { get; set; }
        public string publisher_name { get; set; }
        public int is_checked_out { get; set; }
        public string object_name { get; set; }
    }

    public class _Relationships
    {
        public string checkouts { get; set; }
        public string self { get; set; }
        public string library { get; set; }
        public string playtowins { get; set; }
        public string logs { get; set; }
        public string lastcheckout { get; set; }
    }

    public class _Options
    {
        public object[] is_play_to_win { get; set; }
        public string[] overall_condition { get; set; }
        public _Missing_Instructions _missing_instructions { get; set; }
        public _Is_Play_To_Win _is_play_to_win { get; set; }
        public string[] is_in_circulation { get; set; }
        public object[] box_unacceptable { get; set; }
        public _Is_In_Circulation _is_in_circulation { get; set; }
        public object[] missing_instructions { get; set; }
        public _Box_Unacceptable _box_unacceptable { get; set; }
        public _Is_Checked_Out _is_checked_out { get; set; }
        public _Overall_Condition _overall_condition { get; set; }
        public object[] is_checked_out { get; set; }
        public _Due_For_Triage _due_for_triage { get; set; }
        public _Missing_Components _missing_components { get; set; }
        public object[] due_for_triage { get; set; }
        public object[] missing_components { get; set; }
    }

    public class _Missing_Instructions
    {
        public string _0 { get; set; }
        public string _1 { get; set; }
    }

    public class _Is_Play_To_Win
    {
        public string _0 { get; set; }
        public string _1 { get; set; }
    }

    public class _Is_In_Circulation
    {
        public string _0 { get; set; }
        public string _1 { get; set; }
    }

    public class _Box_Unacceptable
    {
        public string _0 { get; set; }
        public string _1 { get; set; }
    }

    public class _Is_Checked_Out
    {
        public string _0 { get; set; }
        public string _1 { get; set; }
    }

    public class _Overall_Condition
    {
        public string fair { get; set; }
        public string unplayable { get; set; }
        public string verygood { get; set; }
        public string poor { get; set; }
        public string good { get; set; }
        public string mint { get; set; }
    }

    public class _Due_For_Triage
    {
        public string _0 { get; set; }
        public string _1 { get; set; }
    }

    public class _Missing_Components
    {
        public string _0 { get; set; }
        public string _1 { get; set; }
    }

    public class Custom_Fields
    {
        public string Donatedby { get; set; }
    }
}
