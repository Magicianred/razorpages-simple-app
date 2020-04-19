using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorpages_simple_app.Helpers {
    public class BasePageModel : PageModel {
        public string AppName { get; set; } = "razorpages-simple-app";
        public string AppVersion { get; set; } = "1.0.0";
        public string PublicUrl { get; set; } = "/";
        public string ExtFile { get; set; } = "";
        
    }
}