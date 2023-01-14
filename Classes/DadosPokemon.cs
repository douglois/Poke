using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSon.Classes
{
    public class DadosPokemon
    {

        public class Result
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Root
        {
            public int count { get; set; }
            public object next { get; set; }
            public object previous { get; set; }
            public List<Result> results { get; set; }
        }

        public static Root DeserializaClassDados()
        {
            return JsonConvert.DeserializeObject<Root>(BuscaJson.GetJsonDados());
        }
    }
}
