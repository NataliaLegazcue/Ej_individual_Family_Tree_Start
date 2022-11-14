using System.Text.Json;

namespace Person
{
    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        
        public Person(string name, string age)
        {
            this.Name = name;
            this.Age = age;
        }
        
    }
}
