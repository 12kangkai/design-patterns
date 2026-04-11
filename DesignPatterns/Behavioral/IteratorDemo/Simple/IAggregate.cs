namespace IteratorDemo.Simple;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
