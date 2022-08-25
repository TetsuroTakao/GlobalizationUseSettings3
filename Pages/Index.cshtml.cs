using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GlobalizationUseSettings3.Pages;

// public class IndexModel : PageModel
public class IndexModel : PageBaseModel
{
    // private readonly ILogger<IndexModel> _logger;
    // private readonly ApplicationContext Context;

    // public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
    public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration):base(logger, configuration, ApplicationContext.English)
    {
        // _logger = logger;
        // Context = new ApplicationContext();
        // configuration.GetSection(ApplicationContext.English).Bind(Context);
    }

    // public void OnGet()
    // {
    //     ViewData["Brand"] = Context.Brand;
    //     ViewData["Pages"] = Context.Pages;
    //     var current = Context.Pages.Where(p => p.ActionKey == "Index").FirstOrDefault();
    //     if(current != null){
    //         ViewData["Title"] = current.Title;
    //     }
    // }
}
