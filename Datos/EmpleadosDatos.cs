using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EmpleadosDatos
    {
        public static List<Empleado> Get(Empleado e)
        {
            List<Empleado> list = new List<Empleado>();

            string conString = System.Configuration.ConfigurationManager
                .ConnectionStrings["ConexionDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("empleadosGet", connection);
                command.CommandType = CommandType.StoredProcedure;
                if (e.id != null)
                    command.Parameters.AddWithValue("@id", e.id);
                if (e.nombre != null)
                    command.Parameters.AddWithValue("@nombre_apellido", e.nombre);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Empleado emp = new Empleado();
                        emp.id = Convert.ToInt32(reader["id"]);
                        emp.nombre = Convert.ToString(reader["nombre_apellido"]);
                        emp.dni = Convert.ToString(reader["dni"]);
                        if (reader["direccion"].GetType() != typeof(DBNull))
                        {
                            emp.direccion = Convert.ToString(reader["direccion"]);
                        }
                        if (reader["fecha_ingreso"].GetType() != typeof(DBNull))
                        {
                            emp.FechaDeIngreso = Convert.ToDateTime(reader["fecha_ingreso"]);
                        }
                        if (reader["salario"].GetType() != typeof(DBNull))
                        {
                            emp.salario = Convert.ToDecimal(reader["salario"]);
                        }

                        if (reader["nombre_dpto"].GetType() != typeof(DBNull))
                        {
                            Departamento dep = new Departamento();
                            dep.Id = 0;
                            dep.nombre = Convert.ToString(reader["nombre_dpto"]);
                            emp.Departamento = dep;
                        }
                        list.Add(emp);
                    }
                    reader.Close();
                }
                catch (Exception)
                {

                    throw;
                }
                return list;
            }
        }
        public static int Insert(Empleado e)
        {
            int idEmpleadoCreado = 0;
            string conString = System.Configuration.ConfigurationManager
                .ConnectionStrings["ConexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("empleadosInsert", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (e.dni != null)
                    command.Parameters.AddWithValue("@dni", e.dni);
                if (e.nombre != null)
                    command.Parameters.AddWithValue("@nombre_apellido", e.nombre);
                if (e.direccion != null)
                    command.Parameters.AddWithValue("@direccion", e.direccion);
                if (e.FechaDeIngreso != null)
                    command.Parameters.AddWithValue("@fecha_ingreso", e.FechaDeIngreso);
                if (e.salario != null)
                    command.Parameters.AddWithValue("@salario", e.salario);
                if (e.Departamento != null)
                   command.Parameters.AddWithValue("@nombre_dpto", e.Departamento);
                try
                {
                    connection.Open();
                    //Realizo el insert y obtengo el ID generado de la BD
                    idEmpleadoCreado = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception)
                {
                    throw;
                }
                return idEmpleadoCreado;
            }

        }
        public static bool Update(Empleado e)
        {
            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("empleadosModificar", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (e.id != null)
                    command.Parameters.AddWithValue("@id", e.id);
                if (e.dni != null)
                    command.Parameters.AddWithValue("@dni", e.dni);
                if (e.nombre != null)
                    command.Parameters.AddWithValue("@nombre_apellido", e.nombre);
                if (e.direccion != null)
                    command.Parameters.AddWithValue("@direccion", e.direccion);
                if (e.FechaDeIngreso != null)
                    command.Parameters.AddWithValue("@fecha_ingreso", e.FechaDeIngreso);
                if (e.salario != null)
                    command.Parameters.AddWithValue("@salario", e.salario);
                try
                {
                    connection.Open();
                    //Realizo el update
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return true;
        }


    }
}



