namespace ChainOfResponsibilityDemo.Simple;

public class Director : Approver
{
    public override void HandleRequest(int amount)
    {
        if (amount <= 10000)
        {
            Console.WriteLine("总监审批通过");
        }
        else
        {
            Console.WriteLine("金额过大，拒绝审批");
        }
    }
}
