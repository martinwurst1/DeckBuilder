namespace DeckBuilderWASM.POCOs
{
    using System;
    using System.Text.Json.Serialization;
    using System.Collections.Generic;

    public class ImageUris
    {
        [JsonPropertyName("small")]
        public string Small { get; set; }

        [JsonPropertyName("normal")]
        public string Normal { get; set; }

        [JsonPropertyName("large")]
        public string Large { get; set; }

        [JsonPropertyName("png")]
        public string Png { get; set; }

        [JsonPropertyName("art_crop")]
        public string ArtCrop { get; set; }

        [JsonPropertyName("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class ApiCardResult
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("mana_cost")]
        public string ManaCost { get; set; }

        ////[JsonPropertyName("cmc")]
        ////public int Cmc { get; set; }

        ////[JsonPropertyName("type_line")]
        ////public string TypeLine { get; set; }

        ////[JsonPropertyName("oracle_text")]
        ////public string OracleText { get; set; }

        //[JsonPropertyName("colors")]
        //public List<string> Colors { get; set; }

        [JsonPropertyName("set")]
        public string Set { get; set; }

        //[JsonPropertyName("rarity")]
        //public string Rarity { get; set; }

        //[JsonPropertyName("flavor_text")]
        //public string FlavorText { get; set; }

        [JsonPropertyName("image_uris")]
        public ImageUris ImageUris { get; set; }
    }

    public class ApiSearchResult
    {
        [JsonPropertyName("data")]
        public List<ApiCardResult> ApiCards { get; set; }
    }
}
