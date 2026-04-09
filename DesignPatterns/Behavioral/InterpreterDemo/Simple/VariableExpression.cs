namespace InterpreterDemo.Simple;

public class VariableExpression : IExpression
{
    private readonly string _name;

    public VariableExpression(string name)
    {
        _name = name;
    }

    public int Interpret(Context context)
    {
        return context.GetValue(_name);
    }
}
