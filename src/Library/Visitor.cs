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

        protected StringBuilder ContentBuilder { get; } = new StringBuilder();

        public abstract void Visit(Node node);
    }
}
