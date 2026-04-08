namespace ChainOfResponsibilityDemo.Simple;

public class TeamLeader : Approver
{
    public override void HandleRequest(int amount)
    {
        if (amount <= 1000)
        {
            Console.WriteLine("组长审批通过");
        }
        else
        {
            _next?.HandleRequest(amount);
        }
    }
}
