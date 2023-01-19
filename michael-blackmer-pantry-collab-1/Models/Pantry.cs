using Microsoft.AspNetCore.Http.Features;

namespace michael_blackmer_pantry_collab_1.Models
{
    public class Pantry
    {
        public int Id { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
