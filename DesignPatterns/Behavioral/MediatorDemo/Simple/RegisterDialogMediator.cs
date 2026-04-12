namespace MediatorDemo.Simple;

public class RegisterDialogMediator : IMediator
{
    private CheckBox _checkBox;
    private Button _button;
    private TextBox _textBox;

    public void SetControls(CheckBox checkBox, Button button, TextBox textBox)
    {
        _checkBox = checkBox;
        _button = button;
        _textBox = textBox;
    }

    public void Notify(object sender, string eventCode)
    {
        if (sender == _checkBox)
        {
            _button.SetEnabled(_checkBox.IsChecked && !string.IsNullOrWhiteSpace(_textBox.Text));
        }
        else if (sender == _textBox)
        {
            _button.SetEnabled(_checkBox.IsChecked && string.IsNullOrWhiteSpace(_textBox.Text));
        }
        else if (sender == _button && eventCode == "Clicked")
        {
            Console.WriteLine("中介者：执行注册逻辑");
        }
    }
}
