namespace MtgJson.Objects
{
    public class Card
    {
        public string[] colorIdentity { get; set; }
        public string[] colorIndicator { get; set; }
        public string[] colors { get; set; }
        public float convertedManaCost { get; set; }
        public float faceConvertedManaCost { get; set; }
        public ForeignData[] foreignData { get; set; }
        public string hand { get; set; }
        public bool isReserved { get; set; }
        public string layout { get; set; }
        public Legalities legalities { get; set; }
        public string life { get; set; }
        public string loyalty { get; set; }
        public string manaCost { get; set; }
        public int mtgstocksId { get; set; }
        public string name { get; set; }
        public string[] names { get; set; }
        public string power { get; set; }
        public Prices prices { get; set; }
        public string[] printings { get; set; }
        public PurchaseUrls purchaseUrls { get; set; }
        public Rulings rulings { get; set; }
        public string scryfallOracleId { get; set; }
        public string side { get; set; }
        public string[] subtypes { get; set; }
        public string[] supertypes { get; set; }
        public string text { get; set; }
        public string toughness { get; set; }
        public string type { get; set; }
        public string[] types { get; set; }
        public string uuid { get; set; }
    }
}