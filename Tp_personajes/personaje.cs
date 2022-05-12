using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tp_personajes
{
    public abstract class Personaje : IMoverse
    {
        public string? Nombre;
        public int Fuerza;
        public int Agilidad;
        public int Magia;
   
        public virtual int CalcularDanio()
        {
            return 0;
        }
        
        public virtual string Atacar()
        { 
            return $"{Nombre} hizo {CalcularDanio()} de daño"; 
        }
        public string MoverseEjeX()
        {
            return $"{Nombre} moviéndose sobre X";
        }
        public string MoverseEjeY()
        {
            return $"{Nombre} moviéndose sobre Y";
        }
    }
}