namespace AbstractFactoryDemo.Simple.Mac;

public class MacFactory : IGUIFactory
{
    public IButton CreateButton() => new MacButton();

    public ITextBox CreateTextBox() => new MacTextBox();
}
