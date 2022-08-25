using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GlobalizationUseSettings3.Pages;

public class SearchModel : PageModel
{
    private readonly ApplicationContext Context;
    private readonly ILogger<SearchModel> _logger;

    public SearchModel(ILogger<SearchModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        Context = new ApplicationContext();
        configuration.GetSection(ApplicationContext.English).Bind(Context);
    }

    public void OnGet()
    {
        ViewData["Brand"] = Context.Brand;
        ViewData["Pages"] = Context.Pages;
        var current = Context.Pages.Where(p => p.ActionKey == "Search").FirstOrDefault();
        if(current != null){
            ViewData["Title"] = current.Title;
        }
    }
}
