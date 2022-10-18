using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public int? id { get; set; }
        public string? dni { get; set; }
        public string? nombre { get; set; }
        public string? direccion { get; set; }
        public DateTime? FechaDeIngreso { get; set; }
        public decimal? salario { get; set; }
        public Departamento? Departamento { get; set; }
        //public int? Departamento_id { get; set; }
        public string? NombreDeDepartamento
        {
            get
            {
                if (Departamento != null)
                {
                    return Departamento.nombre;
                }
                else
                {
                    return null;
                }
            }
        }



    }
}

