namespace VisitorDemo.Simple;

public interface IVisitor
{
    void Visit(Book book);
    void Visit(Fruit fruit);
}
