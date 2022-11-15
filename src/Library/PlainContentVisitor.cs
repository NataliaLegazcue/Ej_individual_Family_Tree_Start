namespace Genericos
{
    public class PlainContentVisitor : Visitor
    {
        public override void Visit(Node node)
        {
            this.ContentBuilder.Append($"'{node.Name}' a ${node.Age}\n");
        }
    }
}