using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_BD.Entides
{
    public class ClsTorneo
    {
        public int Id_Torneo { get; set; }
        public string Nombre_torneo { get; set; }
        public string Categoria { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Final { get; set; }
        public string Ubicacion_T { get; set; }
        public string Reglas_Especificas { get; set; }
        public bool Estado { get; set; }



    }
}
