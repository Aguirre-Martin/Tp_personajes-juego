/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

namespace Tp_personajes
{
    public abstract class Personaje
    {
        public string Nombre = "";
        public int Fuerza;
        public int Agilidad;
        public int Magia;
        public int X;


        public int CalcularDanio(int Fuerza, int Agilidad, int Magia)
        {
            return X;
        }
        public string Atacar()
        { return $"{Nombre} hizo {X} de daño"; }
    }
}
