namespace ChainOfResponsibilityDemo.Simple;

public class Manager : Approver
{
    public override void HandleRequest(int amount)
    {
        if (amount <= 5000)
        {
            Console.WriteLine("经理审批通过");
        }
        else
        {
            _next?.HandleRequest(amount);
        }
    }
}
