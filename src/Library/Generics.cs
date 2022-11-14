namespace Genericos

{
    public class Contenedor <T>
    {
        private IList<T> items = new List<T>();

        public void Add(T item)
        {
            this.items.Add(item);
        }
    }
}        
