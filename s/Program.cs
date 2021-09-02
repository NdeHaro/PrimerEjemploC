using System;
using System.Collections.Generic;

namespace s
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<IPersonable>();

            Persona persona = new Persona();
            Perro perro = new Perro();
            Elefante elefante = new Elefante();

            lista.Add(persona);
            lista.Add(perro);
            lista.Add(elefante);
            
            foreach(IPersonable ip in lista)
            {
                Console.WriteLine(ip.saludar());
            }
        }
    }


    interface IPersonable
    {
        string saludar();
    }

    class Persona : IPersonable
    {
        public String saludar()
        {
            return "Holiwis";
        }
    }

    class Elefante : IPersonable
    {
        public String saludar()
        {
            return "SONIDO DE ELEFANTE";
        }
    }

    class Perro : IPersonable
    {
        public String saludar()
        {
            return "wooof";
        }
    }
}
