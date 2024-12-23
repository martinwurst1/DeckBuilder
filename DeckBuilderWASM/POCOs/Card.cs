namespace DeckBuilderWASM.POCOs
{
    public class Card(ApiCardResult exactSearchResult, string name)
    {
        public ApiCardResult ExactSearchResult { get; set; } = exactSearchResult;

        public List<ApiCardResult> ArtSearchResult { get; set; } = new();

        public ApiCardResult SelectedVersion { get; set; } = exactSearchResult;

        public string Name { get; } = name;
    }
}
