using System.Data;

namespace Proyecto.Models
{
    internal class TipoSalarioModel
    {


        public int ID_TIPO_SALARIO { get; set; }
        public string DESCRIPCION_TIPO_SALARIO { get; set; }
        public bool ESTATUS { get; set; }
        public static DataTable GetTipoSalario { get; set; }
    }
}
