using System.ComponentModel.DataAnnotations.Schema;

namespace michael_blackmer_pantry_collab_1.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; } =string.Empty;
        public string Image { get; set; }=string.Empty;
        public int Calories { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }   
        public string FamilyName { get; set; } = string.Empty;

    }
}
