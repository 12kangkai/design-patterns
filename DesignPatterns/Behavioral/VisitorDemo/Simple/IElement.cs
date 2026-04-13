namespace VisitorDemo.Simple;

public interface IElement
{
    void Accept(IVisitor visitor);
}
