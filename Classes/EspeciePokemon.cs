﻿using Newtonsoft.Json;
using PokeSon.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSon
{
    public class EspeciePokemon
    {

        public class Color
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Habitat
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Pokedex
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class PokedexNumber
        {
            public int entry_number { get; set; }
            public Pokedex pokedex { get; set; }
        }

        public class Pokemon
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Root
        {
            public int base_happiness { get; set; }
            public int capture_rate { get; set; }
            public Color color { get; set; }
            public object evolves_from_species { get; set; }
            public List<object> form_descriptions { get; set; }
            public bool forms_switchable { get; set; }
            public int gender_rate { get; set; }
            public Habitat habitat { get; set; }
            public bool has_gender_differences { get; set; }
            public int hatch_counter { get; set; }
            public int id { get; set; }
            public bool is_baby { get; set; }
            public bool is_legendary { get; set; }
            public bool is_mythical { get; set; }
            public string name { get; set; }
            public int order { get; set; }
            public List<PokedexNumber> pokedex_numbers { get; set; }

        }

        public static Root DeserializaClassEspecie(string vJson)
        {
            return JsonConvert.DeserializeObject<Root>(BuscaJson.GetJsonCaracteristica(vJson));
        }
    }
}
