using System.Text.Json.Serialization;

namespace michael_blackmer_pantry_collab_1.Models
{
    public class FamilyAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UserAccount> UserAccounts { get; set; }

        public Pantry Pantry { get; set; }

        public List<Recipe> Recipes { get; set; }

    }
}
