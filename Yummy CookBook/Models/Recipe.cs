namespace Yummy_CookBook.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public uint Time { get; set; }
        public string Difficulty { get; set; }
        public uint NbLikes { get; set; }
        public string Ingredients { get; set; }
        public string Process { get; set; }
        public string? TipsTricks { get; set; }
    }
}
