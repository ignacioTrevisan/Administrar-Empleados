using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class EmpleadosNegocios
    {
        public static List<Empleado> Get(Empleado e)
        {
            return EmpleadosDatos.Get(e);
        }
        public static int Insertar(Empleado e)
        {
            if (String.IsNullOrEmpty(e.nombre))
            {
                return 0;
            }
            if (String.IsNullOrEmpty(e.dni))
            {
                return 0;
            }
            if (e.FechaDeIngreso == null)
            {
                e.FechaDeIngreso = DateTime.Now;
            }
            try
            {
                return EmpleadosDatos.Insert(e);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static bool Update(Empleado e)
        {
            if (String.IsNullOrEmpty(e.nombre))
            {
                return false;
            }
            if (String.IsNullOrEmpty(e.dni))
            {
                return false;
            }
            if (e.FechaDeIngreso == null)
            {
                e.FechaDeIngreso = DateTime.Now;
            }
            try
            {
                return EmpleadosDatos.Update(e);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }


    

}

