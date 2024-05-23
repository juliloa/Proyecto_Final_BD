using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BD.Entides
{
    public class ClsHistorial
    {
        public int id_Historial { get; set; }
        public int id_Torneo { get; set; }
        public DateTime Fecha { get; set; }
        public string Equipo_local { get; set; }
        public string VS { get; set; }
        public string Equipo_visitante { get; set; }
        public string Marcador { get; set; }
        public string Evento_Destacado { get; set; }

    }
}
