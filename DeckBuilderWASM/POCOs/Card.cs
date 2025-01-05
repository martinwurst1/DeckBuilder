using System.Text.Json.Serialization;

namespace DeckBuilderWASM.POCOs
{
    public class Card(ApiCardResult exactSearchResult, string name, int anzahl)
    {
        public ApiCardResult ExactSearchResult { get; set; } = exactSearchResult;

        public List<ApiCardResult> ArtSearchResult { get; set; } = new();

        public ApiCardResult SelectedVersion { get; set; } = exactSearchResult;

        public string Name { get; } = name;

        public int Anzahl { get; set; } = anzahl;

        public byte[] Image { get; set; }
    }
}
