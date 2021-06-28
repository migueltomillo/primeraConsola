using System;
using System.Collections.Generic;

namespace martes22
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pais pais1 = new Pais//la nomenclatura indica que debe estar en miniscula
            {
                PaisId = 1,
                Nombre = "Ecuador"//pais y su id datos generales
            };

            pais1.Provincias = new List<Provincia>();
            var provincia1 = new Provincia();
            provincia1.Nombre = "Guayas";// provincia 1 forma correcta de crear un dato string
            var provincia2 = new Provincia();
            provincia2.Nombre = "Pichincha";
            pais1.Provincias = new List<Provincia>(){//se declaran los valores de la lista
                    provincia1,
                    provincia2
                };
            var canton1 = new Canton();
            canton1.Nombre = "Mejia";//cantones añadidos nombres
            var canton2 = new Canton();
            canton2.Nombre = "Cayambe";
            provincia2.Cantones = new List<Canton>();
            provincia2.Cantones.Add(canton1);//añade los datos de provincias
            provincia2.Cantones.Add(canton2);
            var parroquia1 = new Parroquia();
            parroquia1.Nombre = "San Sebastian";//parroquias añadidas
            var parroquia2 = new Parroquia();
            parroquia2.Nombre = "Gonzales Suarez";
            parroquia1.Habitantes = 600;//numero de habitantes por parroquia
            parroquia2.Habitantes = 800;
            canton1.Parroquias = new List<Parroquia>();
            canton1.Parroquias.Add(parroquia1);
            canton1.Parroquias.Add(parroquia2);//add añade los datos

            Console.WriteLine($" El resultado final de habitanes del Ecuador es:{pais1.ObtenerNumeroDeHabitantes()}");
            //impresion de los resultados de la suma de habitantes
        }
    }
}
