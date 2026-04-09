namespace InterpreterDemo.Simple;

public class Context
{
    private readonly Dictionary<string, int> _variables = new Dictionary<string, int>();

    public void SetValue(string name, int value)
    {
        _variables[name] = value;
    }
    
    public int GetValue(string name)
    {
        if (!_variables.ContainsKey(name))
            throw new ArgumentException($"变量 {name} 不存在");
        
        return _variables[name];
    }
}
