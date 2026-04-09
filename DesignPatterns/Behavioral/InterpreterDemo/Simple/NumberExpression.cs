namespace InterpreterDemo.Simple;

public class NumberExpression : IExpression
{
    private readonly int _value;

    public NumberExpression(int value)
    {
        _value = value;
    }

    public int Interpret(Context context)
    {
        return _value;
    }
    
}
