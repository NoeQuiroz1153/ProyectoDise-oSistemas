using System.Data;

namespace Proyecto.Models
{
    internal class ConceptosModel
    {
        public int ID_CONCEPTO { get; set; }
        public string DESCRIPCION_CONCEPTO { get; set; }
        public bool ESTATUS { get; set; }
        public static DataTable GetConcepto { get; set; }

    }
}
