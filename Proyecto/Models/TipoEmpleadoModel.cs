using System.Data;

namespace Proyecto.Models
{
    internal class TipoEmpleadoModel
    {
        public int ID_TIPO_EMPLEADO { get; set; }
        public string DESCRIPCION_TIPOEMPLEADO { get; set; }
        public bool HORAS_EXTRAS { get; set; }
        public static DataTable GetTipoEmpleado { get; set; }

    }
}
