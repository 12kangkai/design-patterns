namespace StateDemo.Simple;

public class PaidState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("订单已支付 -> 开始发货");
        context.SetState(new ShippedState());
    }
}
