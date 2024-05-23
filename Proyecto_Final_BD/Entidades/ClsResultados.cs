using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BD.Entides
{
    public class ClsResultados
    {
        public int id_Resultado { get; set; }
        public int id_Torneo { get; set; }
        public string Equipo_Local { get; set; }
        public string Equipo_Visitante { get; set; }
        public string Marcador { get; set; }
        public string Ganador { get; set; }
        public string Perdedor { get; set; }
        public string Empate { get; set; }
        public string EventoDestacado { get; set; }
        public bool Estado { get; set; }
    }

}
