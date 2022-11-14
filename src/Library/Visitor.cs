using System.Text;

namespace Genericos
{
    public abstract class Visitor
    {
        public string Content
        {
            get
            {
                return this.ContentBuilder.ToString();
            }
        }
        public abstract void Visit(Node node);
    }
}
