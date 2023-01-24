using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace michael_blackmer_pantry_collab_1.Models
{
    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Pantry { get; set; } = string.Empty;

        public List<User> Users { get; set; } = new List<User>();

        public List<Recipe> Recipes { get; set; }  = new List<Recipe>();

    }

}
