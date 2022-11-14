using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Genericos
{
    public class Node : Person

    {
        public Node(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        public string Name { get; set; }

        public int Age { get; set; }

        public Node Izquierda { get; set; }

        public Node Derecha { get; set; }

        public void Accept(Visitor visitor)
        {
           visitor.Visit(this);
        }
    }
}
