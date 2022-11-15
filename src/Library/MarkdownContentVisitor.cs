using System.Text;

namespace Genericos
{
    public class MarkdownContentVisitor : Visitor
    {
        this.ContentBuilder.Append($"{node.Name}|${node.Age}|\n");
    }
}