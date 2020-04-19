using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Westwind.AspNetCore.Markdown;

using razorpages_simple_app.Helpers;
using razorpages_simple_app.Models;

namespace razorpages_simple_app.Pages
{
    public class WhereAreModel : BasePageModel
    {
        private readonly ILogger<WhereAreModel> _logger;
        private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _env;
        public List<Place> Places;
        public string MdHtml;
        public string MdText;
        public string JsonString;

        public WhereAreModel(
            Microsoft.AspNetCore.Hosting.IWebHostEnvironment env, 
            ILogger<WhereAreModel> logger
            ) {
            _env = env;
            _logger = logger;
        }

        public void OnGet()
        {
            string webRootPath = _env.WebRootPath;
            
            string json = System.IO.File.ReadAllText(webRootPath + "/data/places.json");
            Places = System.Text.Json.JsonSerializer.Deserialize<List<Place>>(json);

            string markdown = System.IO.File.ReadAllText(webRootPath + "/data/pages/whereare.md");
            MdHtml = Markdown.Parse(markdown, sanitizeHtml: true);
            
            /** For demonstration purpose **/
            MdText = markdown;
            JsonString = json;
        }
    }
}
