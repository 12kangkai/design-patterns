namespace StateDemo.Simple;

public class PendingState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("订单待支付 -> 用户完成支付");
        context.SetState(new PaidState());
    }
}
