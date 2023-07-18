using System.Data;

namespace Proyecto.Models
{
    internal class DeduccionesModel
    {
        public int ID_EMPLEADO { get; set; }
        public int ID_DEDUCCIONES { get; set; }
        public string DESCRIPCION_DEDUCCION { get; set; }
        public bool ESTATUS { get; set; }

        public static DataTable GetDeducciones { get; set; }

    }
}
