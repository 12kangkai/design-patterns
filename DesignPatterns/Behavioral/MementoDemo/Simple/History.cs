namespace MementoDemo.Simple;

public class History
{
    private Stack<Memento> _stack = new Stack<Memento>();

    public void Push(Memento memento)
    {
        _stack.Push(memento);
    }

    public Memento Pop()
    {
        return _stack.Pop();
    }
}
