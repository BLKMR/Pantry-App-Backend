namespace michael_blackmer_pantry_collab_1.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Instructions { get; set; }
        public ICollection<Item> Ingredients { get; set; }
        public Pantry Pantry { get; set; }

        
    }
}
