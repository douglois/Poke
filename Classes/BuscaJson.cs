using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokeSon.Classes
{
    public static class BuscaJson
    {
        public static string GetJsonDados()
        {
            var request = WebRequest.Create("https://pokeapi.co/api/v2/pokemon?limit=55");
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream);
                    var json = reader.ReadToEnd();
                    return json.ToString();
                }
            }
            return "";
        }

        public static string GetJsonCaracteristica(string urlCaracteristica)
        {
            var request = WebRequest.Create(urlCaracteristica);
            request.Method = "GET";
            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream);
                    var json = reader.ReadToEnd();
                    return json.ToString();
                }
            }
            return "";
        }
    }
}
