namespace IteratorDemo.Simple;

public interface IIterator<T>
{
    bool MoveNext();
    T Current { get; }
    void Reset();
}
