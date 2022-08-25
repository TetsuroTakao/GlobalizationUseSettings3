using Microsoft.AspNetCore.Mvc.RazorPages;
public class LayoutModel:PageModel
{
    private readonly ApplicationContext Context;
    public LayoutModel(ILogger<LayoutModel> logger, IConfiguration configuration)
    {
        Context = new ApplicationContext();
        configuration.GetSection(ApplicationContext.English).Bind(Context);
        ViewData["Pages"] = new List<Page>();
    }

    public void OnGet()
    {
        // ViewData["Brand"] = Context.Brand;
        // ViewData["Pages"] = Context.Pages;
        // var current = Context.Pages.Where(p => p.ActionKey == "Search").FirstOrDefault();
        // if(current != null){
        //     ViewData["Title"] = current.Title;
        // }
    }
}