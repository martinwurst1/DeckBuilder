namespace DeckBuilderWASM.POCOs
{
    public class Container
    {
        public string Input { get; set; }

        public string DeckName { get; set; }

        public string Language { get; set; } = "en";

        public List<Card> Data { get; set; }
    }
}
