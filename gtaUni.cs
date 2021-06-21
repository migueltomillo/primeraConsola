using System;

namespace principal
{
    class GtaV
    {
        string gtaPersonaje;//1
        string juegoFavorito;//2
        int pesoJuego;//3
        string juegoInicio;//4
        string gtaMision1;//5
        int pesoGTAV;//6
        string amigoLeal;//7
        string ultimaMision;//8
        string significadoGTA;//9
        string genio;//10

        public void setPersonajeGTA(string personaje)//set
        {
            gtaPersonaje = personaje;//1
        }
        public string getPersonajeGTA()//get
        {
            return gtaPersonaje;//1
        }
        public void setJuegoFavorito(string game)//set
        {
            juegoFavorito = game;//2
        }
        public string getJuegoFavorito()//get
        {
            return juegoFavorito;//2
        }
        public void setPesoJuego(int peso)//set
        {
            pesoJuego = peso;//3
        }
        public int getPesoJuego()//get
        {
            return pesoJuego;//3
        }
        public void setJuegoComienzo(string inicio)//set
        {
            juegoInicio = inicio;//4
        }
        public string getJuegoComienzo()//get
        {
            return juegoInicio;//4
        }
        public void setMision1(string mision1)//set
        {
            gtaMision1 = mision1;//5
        }
        public string getMision1()//get
        {
            return gtaMision1;//5
        }

        public void setPesoV(int gtaVPeso)//set
        {
            pesoGTAV = gtaVPeso;//6
        }
        public int getPesoV()//get
        {
            return pesoGTAV;//6
        }
        public void setAmigo(string amigo)//set
        {
            amigoLeal = amigo;//7
        }
        public string getAmigo()//get
        {
            return amigoLeal;//7
        }
        
          public void setUltimaMisiob(string ultima)//set
        {
          ultimaMision=ultima;//8
        }
        public string getUltimaMision()//get
        {
          return ultimaMision;//8
        }
          public void setSignificado(string sign)//set
        {
          significadoGTA=sign;//9
        }
        public string getSignificado()//get
        {
          return significadoGTA;//9
        }
          public void setGenio(string genio1)//set
        {
          genio=genio1;//10
        }
        public string getGenio()//get
        {
          return genio;//10
        }
    }
}
