using System.ComponentModel.DataAnnotations.Schema;

namespace michael_blackmer_pantry_collab_1.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public string Steps { get; set; }
        public string FamilyName { get; set; }
        public string PantryName { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
