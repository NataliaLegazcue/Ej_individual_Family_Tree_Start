using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        public string Name { get; set; }
        public Node Izquierda { get; set; }

        public Node Derecha { get; set; }
    }
}
