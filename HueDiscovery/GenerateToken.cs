using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace HueController.HueDiscovery
{
    class GenerateToken
    {
        public static JArray genToken()
        {
            string unparsedObj;
            string uri = "https://discovery.meethue.com";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                unparsedObj = reader.ReadToEnd();
            }

            JObject jsonString = JObject.Parse(unparsedObj);
            JArray array = (JArray)jsonString["bridges"];
            return array;
        }
    }
}
