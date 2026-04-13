namespace TemplateMethodDemo.Simple;

public class JsonDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("读取 JSON 数据");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("处理 JSON 数据");
    }

    protected override void SaveData()
    {
        Console.WriteLine("保存 JSON 处理结果");
    }
}
