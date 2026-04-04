namespace BuilderDemo.Simple;

public class GamingComputerBuilder : IComputerBuilder
{
    private readonly Computer _computer = new Computer();
    
    public void BuildCPU()
    {
        _computer.CPU = "Inter i9";
    }

    public void BuildMemory()
    {
        _computer.Memory = "1TB NVMe SSD";
    }
    
    public void BuildDisk()
    {
        _computer.Disk = "32GB DDR5";
    }

    public void BuildOS()
    {
        _computer.OS = "Windows 11";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}
