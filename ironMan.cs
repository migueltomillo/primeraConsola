using System;

namespace principal
{
    class IronMan
    {

        string nombrePelicula;//1
        string peliculaMala;//2
        int pesoArmadura;//3
        string EnemigoFavorito;//4
        string maquinaDeGuerra;//5

        int pesoMaquinaGuerra;//6

        string nucleo;//7
        string estadoSocial;//8
        string significado;//9

        string comicIronMan;//10

        public void setNombrePelicula(string nom)//set
        {
            nombrePelicula = nom;
        }
        public string getDevuelvePelicula()//get
        {
            return nombrePelicula;
        }
        public void setPeliculaMala(string person)//set
        {
            peliculaMala = person;
        }
        public string getDevPeliculaMala()//get
        {
            return peliculaMala;
        }
        public void setPeso(int peso)//set
        {
          pesoArmadura=peso;
        }
        public int getPesoArmaduraIron()//get
        {
          return pesoArmadura;
        }
          public void setEnemigo(string enemigo)//set
        {
          EnemigoFavorito=enemigo;
        }
        public string getEnemigo()//get
        {
          return EnemigoFavorito;
        }
          public void setMaquinaGuerra(string maquina)//set
        {
          maquinaDeGuerra=maquina;
        }
        public string getMaquinaGuerra()//get
        {
          return maquinaDeGuerra;
        }

         public void setPesoGuerra(int pesoGue)//set
        {
          pesoMaquinaGuerra=pesoGue;
        }
        public int getPesoGuerra()//get
        {
          return pesoMaquinaGuerra;
        }
      public void setNucleoIroj(string nucleos)//set
        {
          nucleo=nucleos;
        }
        public string getNucleoIron()//get
        {
          return nucleo;
        }
          public void setIronManSocial(string estado)//set
        {
          estadoSocial=estado;
        }
        public string getIronManSocial()//get
        {
          return estadoSocial;
        }
          public void setsignificadoIronMan(string sign)//set
        {
          significado=sign;
        }
        public string getsignificadoIronMan()//get
        {
          return significado;
        }
          public void setComicIron(string comic)//set
        {
          comicIronMan=comic;
        }
        public string getComicIron()//get
        {
          return comicIronMan;
        }
        
    }
}