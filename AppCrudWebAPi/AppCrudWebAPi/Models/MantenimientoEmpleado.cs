using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppCrudWebAPi.Models
{
    public class MantenimientoEmpleado:DBConexion
    {
        public List<Empleado> listar()
        {
            List<Empleado> listar = new List<Empleado>();
            using (SqlConnection cn = getconexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarEmpleado", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Empleado oEmpleado;
                while(dr.Read())
                {
                    oEmpleado = new Empleado()
                    {
                        IdEmpleado= int.Parse(dr[0].ToString()),
                        Apellidos=dr["Apellidos"].ToString(),
                        Nombre=dr["Nombre"].ToString(),
                        Cargo=dr["Cargo"].ToString(),
                        FechaContratación=DateTime.Parse(dr["FechaContratación"].ToString()),
                        Direccion=dr["Dirección"].ToString(),
                        Ciudad=dr["Ciudad"].ToString(),
                        Pais=dr["País"].ToString(),
                        TelDomicilio=dr["TelDomicilio"].ToString()
                    };
                    listar.Add(oEmpleado);
                }
            }
            return listar;
        }




        }
    }
