using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TPixelRestCore
{
    public static class Utils
    {

        public static JObject GetHttp(string url) {
            using (var client = new HttpClient())
            {
                return JObject.Parse(client.GetAsync(url).Result.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
