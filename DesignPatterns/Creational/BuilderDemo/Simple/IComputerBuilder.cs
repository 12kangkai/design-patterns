namespace BuilderDemo.Simple;

public interface IComputerBuilder
{
    void BuildCPU();
    void BuildMemory();
    void BuildDisk();
    void BuildOS();
    Computer GetComputer();
}
