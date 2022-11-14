using System;
using Library;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Node raiz = new Node();
            raiz.Name = "A";
            raiz.Izquierda = new Node();
            raiz.Izquierda.Name = "B";
            raiz.Derecha = new Node();
            raiz.Derecha.Name = "C";
            raiz.Izquierda.Izquierda = new Node();
            raiz.Izquierda.Izquierda.Name = "D";
            raiz.Izquierda.Derecha = new Node();
            raiz.Izquierda.Derecha.Name = "E";
            raiz.Derecha.Izquierda = new Node();
            raiz.Derecha.Izquierda.Name = "F";
            raiz.Derecha.Derecha = new Node();
            raiz.Derecha.Derecha.Name = "G";
            raiz.Derecha.Derecha.Derecha = new Node();
            raiz.Derecha.Derecha.Derecha.Name = "H";

        }
    }
}
