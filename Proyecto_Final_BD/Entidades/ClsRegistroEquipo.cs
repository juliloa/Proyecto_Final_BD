using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BD.Entides
{
    public class ClsRegistroEquipo
    {
        public int id_Equipo { get; set; }
        public int id_Torneo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Cantidad_Jugadores { get; set; }
        public bool Estado { get; set; }
    }
}
