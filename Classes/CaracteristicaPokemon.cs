using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSon.Classes
{
    public class CaracteristicaPokemon
    {
        public class Ability
        {
            public Ability ability { get; set; }
            public bool is_hidden { get; set; }
            public int slot { get; set; }
        }

        public class Ability2
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Animated
        {
            public object back_default { get; set; }
            public object back_female { get; set; }
            public object back_shiny { get; set; }
            public object back_shiny_female { get; set; }
            public object front_default { get; set; }
            public object front_female { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_female { get; set; }
        }

        public class BlackWhite
        {
            public Animated animated { get; set; }
            public object back_default { get; set; }
            public object back_female { get; set; }
            public object back_shiny { get; set; }
            public object back_shiny_female { get; set; }
            public string front_default { get; set; }
            public object front_female { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_female { get; set; }
        }

        public class Crystal
        {
            public object back_default { get; set; }
            public object back_shiny { get; set; }
            public object back_shiny_transparent { get; set; }
            public object back_transparent { get; set; }
            public object front_default { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_transparent { get; set; }
            public object front_transparent { get; set; }
        }

        public class DiamondPearl
        {
            public object back_default { get; set; }
            public object back_female { get; set; }
            public object back_shiny { get; set; }
            public object back_shiny_female { get; set; }
            public object front_default { get; set; }
            public object front_female { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_female { get; set; }
        }

        public class DreamWorld
        {
            public object front_default { get; set; }
            public object front_female { get; set; }
        }

        public class Emerald
        {
            public object front_default { get; set; }
            public object front_shiny { get; set; }
        }

        public class FireredLeafgreen
        {
            public object back_default { get; set; }
            public object back_shiny { get; set; }
            public object front_default { get; set; }
            public object front_shiny { get; set; }
        }

        public class Form
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class GenerationI
        {
            [JsonProperty("red-blue")]
            public RedBlue redblue { get; set; }
            public Yellow yellow { get; set; }
        }

        public class GenerationIi
        {
            public Crystal crystal { get; set; }
            public Gold gold { get; set; }
            public Silver silver { get; set; }
        }

        public class GenerationIii
        {
            public Emerald emerald { get; set; }

            [JsonProperty("firered-leafgreen")]
            public FireredLeafgreen fireredleafgreen { get; set; }

            [JsonProperty("ruby-sapphire")]
            public RubySapphire rubysapphire { get; set; }
        }

        public class GenerationIv
        {
            [JsonProperty("diamond-pearl")]
            public DiamondPearl diamondpearl { get; set; }

            [JsonProperty("heartgold-soulsilver")]
            public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }
            public Platinum platinum { get; set; }
        }

        public class GenerationV
        {
            [JsonProperty("black-white")]
            public BlackWhite blackwhite { get; set; }
        }

        public class GenerationVi
        {
            [JsonProperty("omegaruby-alphasapphire")]
            public OmegarubyAlphasapphire omegarubyalphasapphire { get; set; }

            [JsonProperty("x-y")]
            public XY xy { get; set; }
        }

        public class GenerationVii
        {
            public Icons icons { get; set; }

            [JsonProperty("ultra-sun-ultra-moon")]
            public UltraSunUltraMoon ultrasunultramoon { get; set; }
        }

        public class GenerationViii
        {
            public Icons icons { get; set; }
        }

        public class Gold
        {
            public object back_default { get; set; }
            public object back_shiny { get; set; }
            public object front_default { get; set; }
            public object front_shiny { get; set; }
            public object front_transparent { get; set; }
        }

        public class HeartgoldSoulsilver
        {
            public object back_default { get; set; }
            public object back_female { get; set; }
            public object back_shiny { get; set; }
            public object back_shiny_female { get; set; }
            public object front_default { get; set; }
            public object front_female { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_female { get; set; }
        }

        public class Home
        {
            public string front_default { get; set; }
            public object front_female { get; set; }
            public string front_shiny { get; set; }
            public object front_shiny_female { get; set; }
        }

        public class Icons
        {
            public object front_default { get; set; }
            public object front_female { get; set; }
        }

        public class OfficialArtwork
        {
            public string front_default { get; set; }
        }

        public class OmegarubyAlphasapphire
        {
            public object front_default { get; set; }
            public object front_female { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_female { get; set; }
        }

        public class Other
        {
            public DreamWorld dream_world { get; set; }
            public Home home { get; set; }

            [JsonProperty("official-artwork")]
            public OfficialArtwork officialartwork { get; set; }
        }

        public class Platinum
        {
            public object back_default { get; set; }
            public object back_female { get; set; }
            public object back_shiny { get; set; }
            public object back_shiny_female { get; set; }
            public object front_default { get; set; }
            public object front_female { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_female { get; set; }
        }

        public class RedBlue
        {
            public object back_default { get; set; }
            public object back_gray { get; set; }
            public object back_transparent { get; set; }
            public object front_default { get; set; }
            public object front_gray { get; set; }
            public object front_transparent { get; set; }
        }

        public class Root
        {
            public List<Ability> abilities { get; set; }
            public int base_experience { get; set; }
            public List<Form> forms { get; set; }
            public List<object> game_indices { get; set; }
            public int height { get; set; }
            public List<object> held_items { get; set; }
            public int id { get; set; }
            public bool is_default { get; set; }
            public string location_area_encounters { get; set; }
            public List<object> moves { get; set; }
            public string name { get; set; }
            public int order { get; set; }
            public List<object> past_types { get; set; }
            public Species species { get; set; }
            public Sprites sprites { get; set; }
            public List<Stat> stats { get; set; }
            public List<Type> types { get; set; }
            public int weight { get; set; }
        }

        public class RubySapphire
        {
            public object back_default { get; set; }
            public object back_shiny { get; set; }
            public object front_default { get; set; }
            public object front_shiny { get; set; }
        }

        public class Silver
        {
            public object back_default { get; set; }
            public object back_shiny { get; set; }
            public object front_default { get; set; }
            public object front_shiny { get; set; }
            public object front_transparent { get; set; }
        }

        public class Species
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Sprites
        {
            public object back_default { get; set; }
            public object back_female { get; set; }
            public object back_shiny { get; set; }
            public object back_shiny_female { get; set; }
            public string front_default { get; set; }
            public object front_female { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_female { get; set; }
            public Other other { get; set; }
            public Versions versions { get; set; }
        }

        public class Stat
        {
            public int base_stat { get; set; }
            public int effort { get; set; }
            public Stat stat { get; set; }
        }

        public class Stat2
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Type
        {
            public int slot { get; set; }
            public Type type { get; set; }
        }

        public class Type2
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class UltraSunUltraMoon
        {
            public object front_default { get; set; }
            public object front_female { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_female { get; set; }
        }

        public class Versions
        {
            [JsonProperty("generation-i")]
            public GenerationI generationi { get; set; }

            [JsonProperty("generation-ii")]
            public GenerationIi generationii { get; set; }

            [JsonProperty("generation-iii")]
            public GenerationIii generationiii { get; set; }

            [JsonProperty("generation-iv")]
            public GenerationIv generationiv { get; set; }

            [JsonProperty("generation-v")]
            public GenerationV generationv { get; set; }

            [JsonProperty("generation-vi")]
            public GenerationVi generationvi { get; set; }

            [JsonProperty("generation-vii")]
            public GenerationVii generationvii { get; set; }

            [JsonProperty("generation-viii")]
            public GenerationViii generationviii { get; set; }
        }

        public class XY
        {
            public object front_default { get; set; }
            public object front_female { get; set; }
            public object front_shiny { get; set; }
            public object front_shiny_female { get; set; }
        }

        public class Yellow
        {
            public object back_default { get; set; }
            public object back_gray { get; set; }
            public object back_transparent { get; set; }
            public object front_default { get; set; }
            public object front_gray { get; set; }
            public object front_transparent { get; set; }
        }

        public static Root DeserializaClassCaracteristica(string vJson)
        {
            return JsonConvert.DeserializeObject<Root>(BuscaJson.GetJsonCaracteristica(vJson));
        }
    }
}
