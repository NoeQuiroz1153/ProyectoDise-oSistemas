using System;
using System.Data;

namespace Proyecto.Models
{
    internal class EmpleadosModel
    {
        public int ID_EMPLEADO { get; set; }
        public string PRIMER_NOMBRE { get; set; }

        public string SEGUNDO_NOMBRE { get; set; }
        public string PRIMER_APELLIDO { get; set; }

        public string SEGUNDO_APELLIDO { get; set; }

        public int DNI { get; set; }
        public string DIRECCION { get; set; }

        public int TELEFONO { get; set; }
        public DateTime FECHA_NACIMIENTO { get; set; }
        public string GENERO { get; set; }

        public DateTime FECHA_INGRESO { get; set; }
        public int ID_CARGO { get; set; }
        public int ID_HORARIO { get; set; }
        public int ID_USUARIO { get; set; }
        public int SALARIO_BASE { get; set; }
        public int ID_TIPO_EMPLEADO { get; set; }
        public int ID_TIPO_SALARIO { get; set; }
        public string NUMERO_CUENTA { get; set; }
        public byte[] FOTO_EMPLEADO { get; set; }

        public static DataTable GetEmpleado { get; set; }

    }
}
