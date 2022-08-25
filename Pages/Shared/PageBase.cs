using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.RegularExpressions;

namespace GlobalizationUseSettings3.Pages
{
    // public class IndexModel:PageModel
    public class PageBaseModel:PageModel
    {
        private readonly ILogger<PageBaseModel> _logger;
        private readonly ApplicationContext Context;

        // public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        public PageBaseModel(ILogger<PageBaseModel> logger, IConfiguration configuration, string language)
        {
            _logger = logger;
            Context = new ApplicationContext();
            configuration.GetSection(language).Bind(Context);
       }

        public void OnGet()
        {
            ViewData["Brand"] = Context.Brand;
            ViewData["Pages"] = Context.Pages;
            // var current = Context.Pages.Where(p => p.ActionKey == "Index").FirstOrDefault();
            // if(current != null){
            //     ViewData["Title"] = current.Title;
            // }
            var p = Request.HttpContext.GetRouteData()!.Values["Page"]!.ToString();
            var rx = new Regex(@"\w.*",RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var m = rx.Matches(p!).FirstOrDefault()!.Value;
            ViewData["Title"] = Context.Pages.Where(p => p.ActionKey == m).FirstOrDefault()!.Title;
        }
    }
}
