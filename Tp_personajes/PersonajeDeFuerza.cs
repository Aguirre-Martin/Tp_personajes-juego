using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_personajes
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string name, int agility, int magic)
        {
            Nombre = name;
            Agilidad = agility;
            Magia = magic;
            Fuerza = 100;
        }

        public override int CalcularDanio()
        {
            return ((Fuerza * 3) + (Agilidad * 2) + (Magia * 3)) * 2;
        }
    }
}
