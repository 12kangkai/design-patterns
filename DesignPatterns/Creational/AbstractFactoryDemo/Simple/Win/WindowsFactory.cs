namespace AbstractFactoryDemo.Simple.Win;

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton() => new WinButton();

    public ITextBox CreateTextBox() => new WinTextBox();
}
