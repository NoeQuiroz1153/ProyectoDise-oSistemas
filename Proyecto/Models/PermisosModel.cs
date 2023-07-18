using System;
using System.Data;

namespace Proyecto.Models
{
    internal class PermisosModel
    {
        public int ID_EMPLEADO { get; set; }
        public string TIPO_PERMISO { get; set; }
        public DateTime DIA { get; set; }
        public DateTime HORAS { get; set; }
        public bool JUSTIFICADO { get; set; }
        public int ID_PERMISOS { get; set; }

        public static DataTable GetPermisos { get; set; }


    }
}
