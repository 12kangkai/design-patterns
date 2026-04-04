namespace PrototypeDemo.Simple;

public class DocumentTemplate : IPrototype<DocumentTemplate>
{
    public string Title { get; set; }
    public string Content { get; set; }

    public DocumentTemplate(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public DocumentTemplate Clone()
    {
        return new DocumentTemplate(Title, Content);
    }
}
