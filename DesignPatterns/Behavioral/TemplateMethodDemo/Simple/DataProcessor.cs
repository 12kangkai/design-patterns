namespace TemplateMethodDemo.Simple;

public abstract class DataProcessor
{
    // 模版方法：定义固定流程
    public void Process()
    {
        ReadData();
        ProcessData();
        SaveData();

        if (NeedLog())
        {
            WriteLog();
        }
    }
    
    protected abstract void ReadData();
    protected abstract void ProcessData();
    protected abstract void SaveData();
    
    // 钩子方法：子类可以选择覆盖
    protected virtual bool NeedLog()
    {
        return false;
    }

    protected virtual void WriteLog()
    {
        Console.WriteLine("记录处理日志");
    }
    
    
}
