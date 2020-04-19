using System.Text.Json.Serialization;

namespace razorpages_simple_app.Models {
    public class Paragraph {

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}