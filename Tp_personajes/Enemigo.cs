using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_personajes
{
    public class Enemigo : IMoverse
    {
        public int Vida;
        public int Nivel;

        public Enemigo(int life, int level)
        {
            Vida = life;
            Nivel = level;
        }

        public string MoverseEjeX()
        {
            return "Enemigo moviéndose sobre X";
        }

        public string MoverseEjeY()
        {
            return "Enemigo moviéndose sobre Y";
        }
    }
}