using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NLUInterface
{
    public class GetResult
    {
        public static Task<RasaModel> English(string input)
        {
            return Task.Run(() =>
            {
                string url = string.Format("http://localhost:5000/parse?q={0}", input);
                string json_data = "";
                using (var w = new WebClient())
                {
                    try
                    {
                        json_data = w.DownloadString(url);
                    }
                    catch (Exception) { }
                }
                return JsonConvert.DeserializeObject<RasaModel>(json_data);
            });
        }

        public static Task<RasaModel> Vietnamese(string input)
        {
            return Task.Run(() =>
            {
                string url = string.Format("http://localhost:5005/parse?q={0}", input);
                string json_data = "";
                using (var w = new WebClient())
                {
                    try
                    {
                        json_data = w.DownloadString(url);
                    }
                    catch (Exception) { }
                }
                return JsonConvert.DeserializeObject<RasaModel>(json_data);
            });
        }
    }
}
