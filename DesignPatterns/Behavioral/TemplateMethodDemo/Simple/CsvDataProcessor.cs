namespace TemplateMethodDemo.Simple;

public class CsvDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("读取 CSV 数据");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("处理 CSV 数据");
    }

    protected override void SaveData()
    {
        Console.WriteLine("保存 CSV 处理结果");
    }

    protected override bool NeedLog()
    {
        return true;
    }
}
