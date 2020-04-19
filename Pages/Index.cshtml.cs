using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Westwind.AspNetCore.Markdown;

using razorpages_simple_app.Helpers;
using razorpages_simple_app.Models;

namespace razorpages_simple_app.Pages
{
    public class IndexModel : BasePageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _env;
        public List<HomeMessage> HomeMessages;
        public string MdHtml;
        public string MdText;
        public string JsonString;

        public IndexModel(
            Microsoft.AspNetCore.Hosting.IWebHostEnvironment env, 
            ILogger<IndexModel> logger
            ) {
            _env = env;
            _logger = logger;
        }

        public void OnGet()
        {
            // string contentRootPath = _env.ContentRootPath;
            string webRootPath = _env.WebRootPath;
            
            string json = System.IO.File.ReadAllText(webRootPath + "/data/home_messages.json");
            HomeMessages = System.Text.Json.JsonSerializer.Deserialize<List<HomeMessage>>(json);

            // HomeMessages = new List<HomeMessage>() {
            //     new HomeMessage {
            //         Id = "1",
            //         Title = "Welcome to razorpages-base-info-site!",
            //         Text = "<p>This is a <b>Demo webapp</b> meant to show you this digital product.</p>",
            //         ImageSrc = "https://picsum.photos/400/200",
            //         Link = "https://magicianred.altervista.org/gigs/php-base-info-site/",
            //     },
            // };
            string markdown = System.IO.File.ReadAllText(webRootPath + "/data/pages/home.md");
            MdHtml = Markdown.Parse(markdown, sanitizeHtml: true);
            
            /** For demonstration purpose **/
            MdText = markdown;
            JsonString = json;
        }
    }
}
