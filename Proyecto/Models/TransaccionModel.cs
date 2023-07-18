using System.Data;

namespace Proyecto.Models
{
    internal class TransaccionModel
    {
        public int ID_TRANSACCION { get; set; }
        public int ID_EMPLEADO { get; set; }
        public int ID_DEDUCCIONES { get; set; }
        public int ID_TIPO_SALARIO { get; set; }
        public int ID_TIPO_EMPLEADO { get; set; }
        public int ID_PERMISOS { get; set; }
        public int ID_HORARIOS { get; set; }
        public int ID_ASISTENCIA { get; set; }
        public int ID_CONCEPTO { get; set; }

        public int ID_HORAS_EXTRAS { get; set; }

        public double TOTAL_PAGAR { get; set; }

        public static DataTable GetTransaccion { get; set; }



    }
}
