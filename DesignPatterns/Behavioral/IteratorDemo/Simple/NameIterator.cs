namespace IteratorDemo.Simple;

public class NameIterator : IIterator<string>
{
    private readonly NameCollection _collection;
    private int _position = -1;

    public NameIterator(NameCollection collection)
    {
        _collection = collection;
    }

    public bool MoveNext()
    {
        if (_position + 1 >= _collection.Count)
        {
            return false;
        }
        _position++;
        return true;
    }

    public string Current
    {
        get
        {
            if (_position < 0 || _position >= _collection.Count)
            {
                throw new InvalidOperationException("当前位置无效");
            }
            return _collection.GetItem(_position);
        }
    }

    public void Reset()
    {
        _position = -1;
    }
}
