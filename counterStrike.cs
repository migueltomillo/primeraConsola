using System;

namespace principal
{
    class counterStrike
    {
        string creadorCounter;//1
        int pesoCounter;//2
        string losBuenos;//3
        string losMalos;//4
        string bots;//5
        string primerCounter;//6
        string jugastePrimero;//7
        string mapaEmblematico;//8
        string amigosOnline;//9
        string fechaUltimo;//10s

        public void setCreadorCounter(string creador)//set
        {
            creadorCounter = creador;//1
        }
        public string getCreadorCounter()//get
        {
            return creadorCounter;//1
        }
        public void setPesoCounter(int peso)//set
        {
            pesoCounter = peso;//2
        }
        public int getPesoCounter()//get
        {
            return pesoCounter;//2
        }
        public void setBuenosPlayers(string buenos)
        {
            losBuenos = buenos;//3
        }
        public string getBuenosPlayers()
        {
            return losBuenos;//3
        }
        public void setMalosPlayers(string malos)
        {
            losMalos = malos;//4
        }
        public string getMalosPlayers()
        {
            return losMalos;//4
        }
        public void setBots(string sensei)
        {
            bots = sensei;//5
        }
        public string getBots()
        {
            return bots;//5
        }
        public void setFavorito(string prCounter)
        {
            primerCounter = prCounter;//6
        }
        public string getFavorito()
        {
            return primerCounter;//6
        }
        public void setJugasteTuPrimer(string juge)
        {
            jugastePrimero = juge;//7
        }
        public string getJugasteTuPrimer()
        {
            return jugastePrimero;//7
        }
        public void setEmblematico(string emblematico)
        {
            mapaEmblematico = emblematico;//8
        }
        public string getEmblematico()
        {
            return mapaEmblematico;//8
        }
        public void setAmigosOnline(string amigos)
        {
            amigosOnline = amigos;//9
        }
        public string getAmigosOnline()
        {
            return amigosOnline;//9
        }
        public void setUltimoCounter(string ultimo)
        {
            fechaUltimo = ultimo;//10
        }
        public string getUltimoCounter()
        {
            return fechaUltimo;//10
        }
    }
}