namespace BuilderDemo.Simple;

public class OfficeComputerBuilder : IComputerBuilder
{
    private readonly Computer _computer = new Computer();
    
    public void BuildCPU()
    {
        _computer.CPU = "Intel i5";
    }

    public void BuildMemory()
    {
        _computer.Memory = "16GB DDR4";
    }

    public void BuildDisk()
    {
        _computer.Disk = "512GB SSD";
    }

    public void BuildOS()
    {
        _computer.OS = "Windows 11 Pro";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}
