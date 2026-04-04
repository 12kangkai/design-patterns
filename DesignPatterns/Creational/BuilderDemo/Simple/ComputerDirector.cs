namespace BuilderDemo.Simple;

public class ComputerDirector
{
    public void Construct(IComputerBuilder builder)
    {
        builder.BuildCPU();
        builder.BuildMemory();
        builder.BuildDisk();
        builder.BuildOS();
    }
}
