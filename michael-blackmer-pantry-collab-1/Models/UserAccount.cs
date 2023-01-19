using System.Text.Json.Serialization;

namespace michael_blackmer_pantry_collab_1.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public FamilyAccount FamilyAccount { get; set; }

        public int FamilyId { get; set; }

    }
}
