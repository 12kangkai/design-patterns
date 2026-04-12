namespace MediatorDemo.Simple;

public abstract class UIControl
{
    protected readonly IMediator _mediator;

    protected UIControl(IMediator mediator)
    {
        _mediator = mediator;
    }
}
