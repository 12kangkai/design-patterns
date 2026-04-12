namespace MediatorDemo.Simple;

public class TextBox : UIControl
{
    public string Text { get; private set; } = string.Empty;
    
    public TextBox(IMediator mediator) : base(mediator)
    {
    }
    
    public void Input(string text)
    {
        Text = text;
        Console.WriteLine($"输入内容：{Text}");
        _mediator.Notify(this, "Input");
    }

    public void Clear()
    {
        Text = string.Empty;
        Console.WriteLine("清空输入框");
        _mediator.Notify(this, "Cleared");
    }
    
}
