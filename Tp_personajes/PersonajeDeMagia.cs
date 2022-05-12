using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_personajes
{
    public class PersonajeDeMagia : Personaje
    {


        public PersonajeDeMagia(string name, int strength, int agility)
        {
            Nombre = name;
            Fuerza = strength;
            Agilidad = agility;
            Magia = 60;
        }

        public PersonajeDeMagia(string name, int strength, int agility, int magic)
        {
            {
                Nombre = name;
                Fuerza = strength;
                Agilidad = agility;
                Magia = magic;
            }
        }

        public override string Atacar()
        {
            return $"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia";
        }

        public override int CalcularDanio()
        {
            return Fuerza * Agilidad + Magia * 4;
        }
    }
}