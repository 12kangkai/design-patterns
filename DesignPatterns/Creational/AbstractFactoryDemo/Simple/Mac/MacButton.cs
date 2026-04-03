namespace AbstractFactoryDemo.Simple.Mac;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("MacButton Render");
    }
}
