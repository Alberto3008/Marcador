using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tenis
{
    class Marcador
    {
        Jugador Primero, Segundo;
        String ventaja = "";
        String ganador = "";

        public Marcador(Jugador A, Jugador B){
            Primero = A;
            Segundo = B;
        }
     

        public String puntuaciones()
        {
            String resultado="";
            if (isDeuce())
                resultado = "Deuce";
            else if (isGanador()!= null)
            {
                ganador = isGanador().getNombre();
                resultado = ganador+" gana";
            }
            else if (isVentaja() != null)
                resultado = "Ventaja " + isVentaja().getNombre();
            else
                resultado = Primero.getNombre()+": " + Primero.getPuntos().ToString() + ","+ Segundo.getNombre()+": " + Segundo.getPuntos().ToString();
            return resultado;
        }

        public String jugadorPuntua(Jugador H)
        {
            if (H.getPuntos() >= 40)
            {
                if (ventaja == H.getNombre())
                    ganador = H.getNombre();
                else
                {
                    if (ventaja != "")
                        ventaja = "";
                    else
                    {
                        ventaja = H.getNombre();
                        H.sumaPuntos();
                    }
                }
            }
            else
            {
                H.sumaPuntos();
            }
            return H.getNombre()+" puntua";
        }

        public bool finalPartido()
        {
            bool final = false;
            if (ganador != "")
            {
                final = true;
            }
            return final;
        }

        public bool isDeuce()
        {
            return (((Primero.getPuntos() >= 40) && (Segundo.getPuntos() >= 40)) && ventaja == "");
        }

        public Jugador isGanador()
        {
            if (((Primero.getPuntos() > 40) && (Segundo.getPuntos() < 40)) || ganador == Primero.getNombre())
                return Primero;
            else if (((Segundo.getPuntos() > 40) && (Primero.getPuntos() < 40)) || ganador == Segundo.getNombre())
                return Segundo;
            else
                return null;
        }

        public Jugador isVentaja()
        {
            if (ventaja == Primero.getNombre())
                return Primero;
            else if (ventaja == Segundo.getNombre())
                return Segundo;
            else
                return null;
        }
    }
}
