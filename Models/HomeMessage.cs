using System.Text.Json.Serialization;

namespace razorpages_simple_app.Models {
    public class HomeMessage {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("imagesrc")]
        public string ImageSrc { get; set; }
        [JsonPropertyName("link")]
        public string Link { get; set; }
    }
}