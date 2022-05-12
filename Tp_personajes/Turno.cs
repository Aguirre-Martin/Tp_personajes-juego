using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_personajes
{
    public static class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {
            personajes.Select(personaje => personaje.Atacar());
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();
        }
    }
}