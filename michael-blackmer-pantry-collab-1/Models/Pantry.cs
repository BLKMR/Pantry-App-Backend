using System.ComponentModel.DataAnnotations.Schema;

namespace michael_blackmer_pantry_collab_1.Models
{
    public class Pantry
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int FamilyId { get; set; }
        public virtual Family Family { get; set; }
        public virtual ICollection<Item> Items { get; set; }

    }
}
