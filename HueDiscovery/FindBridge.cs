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
            HueBridge.ip = jsonString["bridges"][0]["internalipaddress"].ToString();
            HueBridge.id = jsonString["bridges"][0]["id"].ToString();
            return (JArray)jsonString["bridges"];
        }

        public static JArray getToken(string _ip)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + _ip + "/api");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"devicetype\":\"HueController#DESKTOP123\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return (JArray)result;
            }
        }
    }
}
