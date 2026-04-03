namespace AbstractFactoryDemo.Simple;

public class Application
{
    private IButton _button;
    private ITextBox _textBox;

    public Application(IGUIFactory factory)
    {
        _button = factory.CreateButton();
        _textBox = factory.CreateTextBox();
    }
    
    public void RenderUI()
    {
        _button.Render();
        _textBox.Render();
    }
    
}
