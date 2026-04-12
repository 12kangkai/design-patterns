namespace MediatorDemo.Simple;

public class Button : UIControl
{
    public bool Enabled { get; private set; }
    
    public Button(IMediator mediator) : base(mediator)
    {
    }
    
    public void SetEnabled(bool enabled)
    {
        Enabled = enabled;
        Console.WriteLine($"提交按钮状态：{(Enabled ? "启用" : "禁用")}");
    }

    public void Click()
    {
        if (!Enabled)
        {
            Console.WriteLine("按钮不可点击");
            return;
        }

        Console.WriteLine("提交表单");
        _mediator.Notify(this, "Clicked");
    }
    
}
