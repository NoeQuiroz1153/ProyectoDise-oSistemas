using System.Data;

namespace Proyecto.Models
{
    internal class HorariosModel
    {
        public int ID_HORARIO { get; set; }
        public string TIPO_TURNO { get; set; }
        public bool ESTATUS { get; set; }
        public string JORNADA_LABORAL { get; set; }
        public double HORAS_SEMANALES { get; set; }

        public static DataTable GetHorarios { get; set; }

    }
}
