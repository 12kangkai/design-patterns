namespace StateDemo.Simple;

public class ShippedState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("订单已发货 -> 完成流程");
    }
}
