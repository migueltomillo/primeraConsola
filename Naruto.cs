using System;

namespace principal
{
    class Naruto
    {
        string naruto;
        int pesoNaruto;
        string sagaFavorita;
        string capituloFavorito;
        string personajeFavorito;
        string nombreSensei;
        string nombreEnemigo;
        string noviaNaruto;
        string amigoNaruto;
        string nombreTierra;

        public void setNombreReal(string real)
        {
            naruto = real;
        }
        public string getNombreReal()
        {
            return naruto;
        }
        public void setPesoNarut(int peso)//set
        {
            pesoNaruto = peso;
        }
        public int getPesoNarut()//get
        {
            return pesoNaruto;
        }
               public void setSaga(string saga)
        {
            sagaFavorita  = saga;
        }
        public string getSaga()
        {
            return sagaFavorita;
        }
           public void setFavoritoPersonaje(string personajeFav)
        {
            personajeFavorito = personajeFav;
        }
        public string getFavoritoPersonaje()
        {
            return personajeFavorito;
        }
        public void setSensei(string sensei)
        {
            nombreSensei = sensei;
        }
        public string getSensei()
        {
            return nombreSensei;
        }
        public void setFavorito(string capitulo)
        {
            capituloFavorito = capitulo;
        }
        public string getFavorito()
        {
            return capituloFavorito;
        }
         public void setEnemigo(string enemigo)
        {
            nombreEnemigo = enemigo;
        }
        public string getEnemigo()
        {
            return nombreEnemigo;
        }
         public void setNovia(string novia)
        {
            noviaNaruto = novia;
        }
        public string getNovia()
        {
            return noviaNaruto;
        }
           public void setAmigoNaruto(string amigo)
        {
            amigoNaruto = amigo;
        }
        public string getAmigoNaruto()
        {
            return amigoNaruto;
        }
           public void setNnombreTierra(string tierra)
        {
            nombreTierra = tierra;
        }
        public string getNombreTierra()
        {
            return nombreTierra;
        }
    
    }
}