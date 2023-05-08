using LabClases4.Clases;
using System;

namespace LabClases4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Pepe", "Perez", 24, 32552465);

            p.GetFullName();
            p.GetAge();
        }
    }
}
