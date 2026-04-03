namespace AbstractFactoryDemo.Simple;

public interface IGUIFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}
