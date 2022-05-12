using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_personajes
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string name, int strength, int agility, int magic)
        {

            Nombre = name;
            Fuerza = strength;
            Agilidad = agility;
            Magia = magic;

        }

        public override int CalcularDanio()
        {
            return Fuerza / 2 * Agilidad * Magia / 2;
        }
    }
}
