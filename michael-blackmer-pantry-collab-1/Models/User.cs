using System.ComponentModel.DataAnnotations.Schema;

namespace michael_blackmer_pantry_collab_1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string FamilyName { get; set; } = string.Empty;

        [ForeignKey("Family")]
        public int FamilyId { get; set; } 
        public Family? Family { get; set; }

    }
}
