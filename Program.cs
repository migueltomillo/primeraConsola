using System;

namespace primeraApp

{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese su nombre; ");
            var nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };

            };
            Console.Write("Ingrese su peso");
            float peso = float.Parse(Console.ReadLine());
            var persona = new Persona();

            persona.nombre = nombre;
            persona.edad = edad1;
            persona.peso = peso;

            Console.WriteLine("Usted ingreso lo siguiente: ");
            Console.Write($"Nombre: {persona.nombre} " + "");
            Console.Write("Edad: " + persona.edad);
            Console.Write("peso: " + persona.peso);
            Console.Write("Muchas gracias : digite cualquier tecla para terminar.");
            Console.ReadKey();
        }
        public void metodo(string[] args)
        {
            if (args.Length > 0)
                Console.WriteLine("Hola {0}" + args[0]);
            else
            {
                Console.WriteLine("Hola desconocido no hay argumentos");

            }
            Console.WriteLine("¿Como estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmm entiendo");
            var date = new DateTime();
            Console.WriteLine(date);
        }
    }
}