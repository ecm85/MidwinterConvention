using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace MidwinterConvention.CLI
{
    public class BggService
    {
        public IDictionary<ulong, BGG.itemsItem> GetBggItems(IEnumerable<int> bggIds)
        {
            var bggIdsParameter = string.Join(",", bggIds);
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                var uri = $"https://www.boardgamegeek.com/xmlapi2/thing?id={bggIdsParameter}&stats=1";
                var response = client.GetAsync(uri).Result;
                var bytes = response.Content?.ReadAsByteArrayAsync().Result;
                var xml = System.Text.Encoding.UTF8.GetString(bytes).Replace("\n", "");
                using (var resultStream = new StringReader(xml))
                {
                    var items = (BGG.items)new XmlSerializer(typeof(BGG.items)).Deserialize(resultStream);
                    return items.item.ToDictionary(item => item.id);
                }
            }
        }
    }
}
