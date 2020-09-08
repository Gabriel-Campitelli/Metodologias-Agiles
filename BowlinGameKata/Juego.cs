using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlinGameKata
{
    public class Juego
    {
        private int puntos =0;
        private int posicion = 0;
        private bool spare = false;
        private bool strike = false;


        private int[] posiciones = new int[21];

        public int Score()
        {
            return puntos;
        }

        public void Tirar(int pinos_tirados)
        {
            puntos += pinos_tirados;
            posicion += 1;
            posiciones[posicion] = pinos_tirados;
            int acum = 0;

            if (spare)
            {                
                //aca sumar los puntos
                puntos += posiciones[posicion];
                spare = false;
            }

            if (strike)
            {
                acum += 1;
                posiciones[posicion] = 0;

                //aca sumar los puntos
                puntos += posiciones[posicion];  
                if(acum == 2) 
                { 
                    strike = false;
                    acum = 0;
                }
            }

            if (posicion % 2 == 0 ) { 
                if(posiciones[posicion-1]+posiciones[posicion] == 10)
                    {
                        //es un spare
                        spare = true;
                    }
            }
            else
            {
                if(posiciones[posicion] == 10)
                {
                    strike = true;
                }
            }


            Console.Write(posiciones[posicion]);
            Console.WriteLine("Acumulado: " + puntos);
        }



    }
}
