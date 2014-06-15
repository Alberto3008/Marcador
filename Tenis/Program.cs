using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenis
{
   
    class Program
    {

        static void Main(string[] args)
        {
            string cadena,nombre;
            Console.WriteLine("------- BIENVENIDO AL PARTIDO --------");
            Console.WriteLine("Introduzca el Nombre del Jugador 1 :");
            nombre = Console.ReadLine();
            Jugador A = new Jugador(nombre);
            Console.WriteLine("Introduzca el Nombre del Jugador 2 :");
            nombre = Console.ReadLine();
            Jugador B = new Jugador(nombre);
            Console.WriteLine("Se introducira por teclado que jugador gana punto(1, 2) hasta que gane uno de ellos");
            Marcador M = new Marcador(A, B);
            do
            {
                Console.WriteLine("Introducir que jugador puntua:"+ A.getNombre()+" [1],"+B.getNombre() +" [2]");
                cadena = Console.ReadLine();
                switch (cadena)
                {
                    case "1":
                        Console.WriteLine(M.jugadorPuntua(A));
                        Console.WriteLine(M.puntuaciones());
                        break;
                    case "2":
                        Console.WriteLine(M.jugadorPuntua(B));
                        Console.WriteLine(M.puntuaciones());
                        break;
                    default:
                        Console.WriteLine("Jugador erroneo repita");
                        break;
                }
            } while (!M.finalPartido());
            cadena = Console.ReadLine();
        }
    }
}
