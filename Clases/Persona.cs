using System;
using System.Collections.Generic;
using System.Text;

namespace LabClases4.Clases
{
    internal class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _dni;

        public Persona(string nom, string ape, int edad, int dni)
        {
            this._nombre = nom;
            this._apellido = ape;
            this._edad = edad;
            this._dni = dni;
        }

        ~Persona()
        {
            Console.WriteLine("Se ha eliminado la Persona");
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
 
        }

        public string Apellido
        {
            get => _apellido; 
            set => _apellido = value;

        }

        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }

        public int DNI
        {
            get => _dni;
            set => _dni = value;
        }

        public void GetFullName()
        {
            Console.WriteLine(this._nombre + " " + this._apellido);
        }

        public void GetAge()
        {
            Console.WriteLine(this._edad.ToString());
        }
    }
}
