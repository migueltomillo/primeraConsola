using System;

namespace principal
{
    class Program
    {

        static void Main(string[] args)
        {
            ironMan(args);
            //naruto(args);
            //gtav(args);
            //counterstrike(args);
            //mariobros(args);

        }

        static void ironMan(string[] args)
        {
            IronMan m1 = new IronMan();

            Console.WriteLine("Bienvenido a esta encuesta de Iron man");
            Console.WriteLine("Que pelicula es tu favorita de esta saga: ");//1
            var name = Console.ReadLine();
            m1.setNombrePelicula(name);
            Console.WriteLine("Que pelicula no te gusta de esta saga: ");//2
            var names = Console.ReadLine();
            m1.setPeliculaMala(names);
            Console.Write("Cual crees que es el peso de la armadura de iron man: ");//3
            int peso1;
            while (true)
            {
                string peso = Console.ReadLine();
                if (!int.TryParse(peso, out peso1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };

            };
            m1.setPeso(peso1);
            Console.WriteLine("Cual villano te gusta mas de iron man: ");//4
            var enemigos = Console.ReadLine();
            m1.setEnemigo(enemigos);
            Console.WriteLine("¿Quien maneja a maquina de guerra?: ");//5
            var maquinaGuerra = Console.ReadLine();
            m1.setMaquinaGuerra(maquinaGuerra);
            Console.Write("Cual crees que es el peso de la armadura de maquina de guerra: ");//6
            int pesoGue;
            while (true)
            {
                string peso = Console.ReadLine();
                if (!int.TryParse(peso, out pesoGue))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };

            };
            m1.setPesoGuerra(pesoGue);
            Console.WriteLine("Como se llama el nucleo de energia de iron man: ");//7
            var nucleoIron = Console.ReadLine();
            m1.setNucleoIroj(nucleoIron);
            Console.WriteLine("Iron man es rico o pobre: ");//8
            var sociall = Console.ReadLine();
            m1.setIronManSocial(nucleoIron);
            Console.Write("Que significa Iron Man: ");//9
            var ironSig = Console.ReadLine();
            m1.setsignificadoIronMan(ironSig);
            Console.Write("Como se llamo el primer comic de iron man: ");//10
            var comicIro = Console.ReadLine();
            m1.setComicIron(comicIro);

            Console.WriteLine("Tus respuestas fueron");
            Console.WriteLine("Tu pelicula favorita es: " + m1.getDevuelvePelicula());//1
            Console.WriteLine("La pelicula que no te gusta es: " + m1.getDevPeliculaMala());//2
            Console.WriteLine("La armadura de iron man 1 pesa: " + m1.getPesoArmaduraIron() + "kg");//3
            Console.WriteLine("Tu villano favorita es: " + m1.getEnemigo());//4
            Console.WriteLine("Maquina de guerra lo maneja: " + m1.getMaquinaGuerra());//5
            Console.WriteLine("La armadura de maquina de guerra pesa: " + m1.getPesoGuerra() + "kg");//6
            Console.WriteLine("El nucleo se llama: " + m1.getNucleoIron());//7
            Console.WriteLine("Iron mas es: " + m1.getIronManSocial());//8
            Console.WriteLine("Iron man significa: " + m1.getsignificadoIronMan());//9
            Console.WriteLine("El primer comic de iron man se llama: " + m1.getComicIron());//10


        }
        static void naruto(string[] args)
        {
            Naruto h1 = new Naruto();
            Console.WriteLine("Bienvenido a esta encuesta de Iron man");
            Console.WriteLine("Nombre real de naruto: ");//1
            var nombre = Console.ReadLine();
            h1.setNombreReal(nombre);
            Console.Write("Cual es el peso de naruto: ");//2
            int peso1;
            while (true)
            {
                string peso = Console.ReadLine();
                if (!int.TryParse(peso, out peso1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };

            };
            h1.setPesoNarut(peso1);
            Console.WriteLine("Que saga te gusta mas de naruto: ");//3
            var nombreSaga = Console.ReadLine();
            h1.setSaga(nombreSaga);
            Console.WriteLine("Nombre real de naruto: ");//4
            var cap = Console.ReadLine();
            h1.setFavorito(cap);
            Console.WriteLine("Personaje favorito: ");//5
            var pers = Console.ReadLine();
            h1.setFavoritoPersonaje(pers);
            Console.WriteLine("Nombre de sensei de naruto: ");//6
            var sen = Console.ReadLine();
            h1.setSensei(sen);
            Console.WriteLine("Cual es el nombre del enemigo de naruto: ");//7
            var nombreEnemigo = Console.ReadLine();
            h1.setEnemigo(nombreEnemigo);
            Console.WriteLine("Como se llama la novia de naruto: ");//8
            var nombr = Console.ReadLine();
            h1.setNovia(nombr);
            Console.WriteLine("Nombre del amigo de naruto: ");//9
            var nombreAmigo = Console.ReadLine();
            h1.setAmigoNaruto(nombreAmigo);
            Console.WriteLine("Nombre del planeta donde esta naruto: ");//10
            var nombreTierra = Console.ReadLine();
            h1.setNnombreTierra(nombreTierra);

            Console.WriteLine("Tus respuestas fueron");
            Console.WriteLine("Nombre real es: " + h1.getNombreReal());
            Console.WriteLine("El peso de naruto es: " + h1.getPesoNarut() + "Kg");
            Console.WriteLine("La saga que mas te gusta es: " + h1.getSaga());
            Console.WriteLine("Su nombre real es: " + h1.getFavorito());
            Console.WriteLine("Tu personaje favorito es: " + h1.getFavoritoPersonaje());
            Console.WriteLine("El sensei de naruto se llama: " + h1.getSensei());
            Console.WriteLine("El enemigo de naruto es: " + h1.getEnemigo());
            Console.WriteLine("La novia de naruto es: " + h1.getNovia());
            Console.WriteLine("El amigo de naruto se llama: " + h1.getAmigoNaruto());
            Console.WriteLine("El planeta de naruto se llama: " + h1.getNombreTierra());




        }
        static void gtav(string[] args)
        {
            GtaV q1 = new GtaV();
            Console.WriteLine("Bienvenido a esta encuesta sobre el universo de GTA");
            Console.WriteLine("Como se llama el personaje principal de GTA V: ");//1
            var personaje = Console.ReadLine();
            q1.setPersonajeGTA(personaje);
            Console.WriteLine("cual es tu juego favorito de GTA: ");//2
            var juego = Console.ReadLine();
            q1.setJuegoFavorito(juego);
            Console.WriteLine("cuanto pesa el GTA 3: ");//3
            int peso1;
            while (true)
            {
                string peso = Console.ReadLine();
                if (!int.TryParse(peso, out peso1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };

            };
            q1.setPesoJuego(peso1);
            Console.WriteLine("Cual fue el primer GTA que jugaste: ");//4
            var enemigos = Console.ReadLine();
            q1.setJuegoComienzo(enemigos);
            Console.WriteLine("¿Cual es la primera mision de GTA 1?: ");//5
            var mision1 = Console.ReadLine();
            q1.setMision1(mision1);
            Console.Write("Cual es el peso de GTA V: ");//6
            int peso2;
            while (true)
            {
                string gtaVPeso = Console.ReadLine();
                if (!int.TryParse(gtaVPeso, out peso2))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };

            };
            q1.setPesoV(peso2);
            Console.WriteLine("Como se llama el amigo de GTA 1: ");//7
            var amigoPrincipal = Console.ReadLine();
            q1.setAmigo(amigoPrincipal);
            Console.WriteLine("Cual fue la ultima mision de GTA 1: ");//8
            var misionFinal = Console.ReadLine();
            q1.setUltimaMisiob(misionFinal);
            Console.Write("Que significa GTA: ");//9
            var significado = Console.ReadLine();
            q1.setSignificado(significado);
            Console.Write("Quien es el inventor de GTA: ");//10
            var gen = Console.ReadLine();
            q1.setGenio(gen);

            Console.WriteLine("Tus respuestas fueron");
            Console.WriteLine("El personaje se llama: " + q1.getPersonajeGTA());//1
            Console.WriteLine("Tu juego favorito es: " + q1.getJuegoFavorito());//2
            Console.Write("Cuanto pesa el GTA 3: " + q1.getPesoJuego() + "Gb");//3
            Console.Write("Desde que version de gta juegas: " + q1.getJuegoComienzo());//4
            Console.Write("La primera mision fue: " + q1.getMision1());//5
            Console.Write("El peso de gta v es: " + q1.getPesoV());//6
            Console.Write("El amigo de gta 1 se llama: " + q1.getAmigo());//7
            Console.Write("La ultima mision fue: " + q1.getUltimaMision());//8
            Console.Write("Que significa GTA: " + q1.getSignificado());//9
            Console.Write("El inventor de GTA es: " + q1.getGenio());//10




        }
        static void counterstrike(string[] args)
        {
            counterStrike b1 = new counterStrike();
            Console.WriteLine("Bienvenido a esta encuesta de counter strike");
            Console.WriteLine("Como se llama el creador de counter strike 3.16: ");//1
            var creador = Console.ReadLine();
            b1.setCreadorCounter(creador);
            Console.Write("Cuanto peso el counter strike 3.16: ");//2
            int peso1;
            while (true)
            {
                string peso = Console.ReadLine();
                if (!int.TryParse(peso, out peso1))
                {
                    Console.Write("Ingrese un valor numerico: ");
                }
                else
                {
                    break;
                };

            };
            b1.setPesoCounter(peso1);
            Console.WriteLine("Como se llaman los que desinstalan la bomba: ");//3
            var nombreSaga = Console.ReadLine();
            b1.setBuenosPlayers(nombreSaga);
            Console.WriteLine("Como se llaman los que ponen la bomba: ");//4
            var mal = Console.ReadLine();
            b1.setMalosPlayers(mal);
            Console.WriteLine("hay bots en counter strike contesta si-no: ");//5
            var bot = Console.ReadLine();
            b1.setBots(bot);
            Console.WriteLine("Cual fue el primer counter strike que salio: ");//6
            var fav = Console.ReadLine();
            b1.setFavorito(fav);
            Console.WriteLine("Cual fue el primer counter strike que jugaste: ");//7
            var juges = Console.ReadLine();
            b1.setJugasteTuPrimer(juges);
            Console.WriteLine("Como se llama el mapa mas emblematico de counter strike: ");//8
            var emb = Console.ReadLine();
            b1.setEmblematico(emb);
            Console.WriteLine("Se puede jugar counter strike con amigos: ");//9
            var amigoO = Console.ReadLine();
            b1.setAmigosOnline(amigoO);
            Console.WriteLine("Hasta la fecha cual es el ultimo counter strike que a salido: ");//10
            var fin = Console.ReadLine();
            b1.setUltimoCounter(fin);

            Console.WriteLine("Tus respuestas fueron");
            Console.WriteLine("El creador se llama: " + b1.getCreadorCounter());//1
            Console.WriteLine("El peso de counter strike es: " + b1.getPesoCounter() + "Gb");//2
            Console.WriteLine("Los buenos se llaman: " + b1.getBuenosPlayers());//3
            Console.WriteLine("Los malos se llaman: " + b1.getMalosPlayers());//4
            Console.WriteLine("Hay bots en counter strike: " + b1.getBots());//5
            Console.WriteLine("El primer counter fue: " + b1.getFavorito());//6
            Console.WriteLine("El primer counter que jugaste fue: " + b1.getJugasteTuPrimer());//7
            Console.WriteLine("El mapa emblematico es de: " + b1.getEmblematico());//8
            Console.WriteLine("Se puede jugar con amigos counter strike: " + b1.getAmigosOnline());//9
            Console.WriteLine("Ultimo counter strike: " + b1.getUltimoCounter());//10




        }
        static void mariobros(string[] args)
        {

        }
    }
}

