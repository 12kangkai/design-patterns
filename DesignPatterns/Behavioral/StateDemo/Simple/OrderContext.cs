namespace StateDemo.Simple;

public class OrderContext
{
    private IOrderState _state;

    public OrderContext(IOrderState state)
    {
        _state = state;
    }
    
    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public void Request()
    {
        _state.Handle(this);
    }
    
}
