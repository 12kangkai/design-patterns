namespace StateDemo.Simple;

public interface IOrderState
{
    void Handle(OrderContext context);
}
