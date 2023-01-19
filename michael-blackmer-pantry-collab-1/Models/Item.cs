namespace michael_blackmer_pantry_collab_1.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }
        public int Calories { get; set; }   
        public int PantryId { get; set; }
        public Pantry Pantry { get; set; }
    }
}
