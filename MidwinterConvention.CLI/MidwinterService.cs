using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace MidwinterConvention.CLI
{
    public class MidwinterService
    {
        public List<Midwinter.Item> GetAllItems()
        {
            var allItems = new List<Midwinter.Item>();

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
                    var rootobject = JsonConvert.DeserializeObject<Midwinter.Rootobject>(resultText);

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
}
