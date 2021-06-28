using System.Collections.Generic;
using System;
namespace martes22
{
    class Provincia
    {
        public int ProvinciaId
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }

         public List<Canton> Cantones
        {
            get; set;
        } = new List<Canton>();
        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            foreach (Canton actual in Cantones)
            {
                acumulador = acumulador + actual.ObtenerNumeroDeHabitantes();//siempre comenzar con mayuscula
            }
            return acumulador;
        }

    }


}
