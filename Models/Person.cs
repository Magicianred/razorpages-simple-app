using System.Text.Json.Serialization;

namespace razorpages_simple_app.Models {
    public class Person {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("surname")]
        public string Surname { get; set; }

        [JsonPropertyName("shortbio")]
        public string ShortBio { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("profilesrc")]
        public string ProfileSrc { get; set; }
    }
}