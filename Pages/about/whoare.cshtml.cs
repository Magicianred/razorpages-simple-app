using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Westwind.AspNetCore.Markdown;

using razorpages_simple_app.Helpers;
using razorpages_simple_app.Models;

namespace razorpages_simple_app.Pages
{
    public class WhoAreModel : BasePageModel
    {
        private readonly ILogger<WhoAreModel> _logger;
        private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _env;
        public List<Person> People;
        public string MdHtml;
        public string MdText;
        public string JsonString;

        public WhoAreModel(
            Microsoft.AspNetCore.Hosting.IWebHostEnvironment env, 
            ILogger<WhoAreModel> logger
            ) {
            _env = env;
            _logger = logger;
        }

        public void OnGet()
        {
            string webRootPath = _env.WebRootPath;
            
            string json = System.IO.File.ReadAllText(webRootPath + "/data/people.json");
            People = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(json);

            string markdown = System.IO.File.ReadAllText(webRootPath + "/data/pages/whoare.md");
            MdHtml = Markdown.Parse(markdown, sanitizeHtml: true);
            
            /** For demonstration purpose **/
            MdText = markdown;
            JsonString = json;
        }
    }
}
