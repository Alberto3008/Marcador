using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenis
{
    class Jugador
    {

        private int puntos;
        private String nombre;
       
        public Jugador(String nom)
        {
            nombre = nom;
            puntos = 0;
        }

        public void sumaPuntos()
        {
            if (puntos == 30)
                puntos = 40;
            else
                puntos = puntos + 15;
        }

        public int getPuntos()
        {
            return puntos;
        }

        public String getNombre()
        {
            return nombre;
        }

    }
}
