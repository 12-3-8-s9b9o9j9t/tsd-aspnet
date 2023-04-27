namespace Yummy_CookBook.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public string Difficulty { get; set; }
        public int NbLikes { get; set; }
        public ICollection<string> Ingredients { get; set; }
        public string Process { get; set; }
        public ICollection<string> TipsTricks { get; set; }
    }
}
