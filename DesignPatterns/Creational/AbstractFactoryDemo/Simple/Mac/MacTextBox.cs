namespace AbstractFactoryDemo.Simple.Mac;

public class MacTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("MacTextBox Render");
    }
}
