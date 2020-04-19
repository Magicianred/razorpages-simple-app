using Microsoft.Extensions.Logging;
using Westwind.AspNetCore.Markdown;

using razorpages_simple_app.Helpers;

namespace razorpages_simple_app.Pages
{
    public class ContactModel : BasePageModel
    {
        private readonly ILogger<ContactModel> _logger;
        private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _env;
        public string MdHtml;
        public string MdText;

        public ContactModel(
            Microsoft.AspNetCore.Hosting.IWebHostEnvironment env, 
            ILogger<ContactModel> logger
            ) {
            _env = env;
            _logger = logger;
        }

        public void OnGet()
        {
            string webRootPath = _env.WebRootPath;

            string markdown = System.IO.File.ReadAllText(webRootPath + "/data/pages/contact.md");
            MdHtml = Markdown.Parse(markdown, sanitizeHtml: true);
            
            /** For demonstration purpose **/
            MdText = markdown;
        }
    }
}
