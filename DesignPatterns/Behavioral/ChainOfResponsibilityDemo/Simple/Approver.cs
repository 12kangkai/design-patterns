namespace ChainOfResponsibilityDemo.Simple;

public abstract class Approver
{
    protected Approver _next;

    public void SetNext(Approver next)
    {
        _next = next;
    }
    
    public abstract void HandleRequest(int amount);
}
