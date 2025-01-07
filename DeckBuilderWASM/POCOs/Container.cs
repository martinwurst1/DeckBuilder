namespace DeckBuilderWASM.POCOs
{
    public class Container
    {
        public string Input { get; set; }

        public string DeckName { get; set; } = "Deck";

        public List<Card> Data { get; set; } = new();
    }
}
