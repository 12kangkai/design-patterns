namespace MediatorDemo.Simple;

public class CheckBox : UIControl
{
    public bool IsChecked { get; private set; }
    
    public CheckBox(IMediator mediator) : base(mediator)
    {
    }

    public void Check()
    {
        IsChecked = true;
        Console.WriteLine("勾选同意协议");
        _mediator.Notify(this,"checked");
    }
    
    public void Uncheck()
    {
        IsChecked = false;
        Console.WriteLine("取消勾选同意协议");
        _mediator.Notify(this, "unchecked");
    }
    
    
}
