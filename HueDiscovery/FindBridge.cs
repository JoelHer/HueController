using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace HueController.HueDiscovery
{
    class FindBridge
    {
        public static JArray discoverBridges()
        {
            string unparsedObj;
            string uri = "https://discovery.meethue.com";
            Console.WriteLine("Searching via GET to " + uri);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                unparsedObj = reader.ReadToEnd();
            }

            //JSON PARSING
            JObject jsonString = JObject.Parse("{ bridges: " + unparsedObj + " }");
            return (JArray)jsonString["bridges"];
        }
    }
}
