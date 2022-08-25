public class ApplicationContext {
    public const string Japanese = "Japanese";
    public const string English = "English";
    public string Brand{ get; set; } = String.Empty;
    public List<Page> Pages{ get; set; } = new List<Page>();
}
public class Page {
    public string ActionKey { get; set; } = String.Empty;
    public string Title { get; set; } = String.Empty;
}
