using AppCrudWebAPi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppCrudWebAPi.Controllers
{
    public class EmpleadoController : ApiController
    {
        [HttpGet]
       public Reply Get()
        {
            Reply oR = new Reply();
            oR.Result = 0;
            try
            {
                MantenimientoEmpleado oEmpleado = new MantenimientoEmpleado();
                List<Empleado> lstEmpleado = new List<Empleado>();
                lstEmpleado= oEmpleado.listar();
               
                if (lstEmpleado.Count>0)
                {
                    oR.Result = 1;
                    oR.data = lstEmpleado;
                    oR.message = "Ejecución exitosa";
                }else
                {
                    oR.message = "No se encontró registro";
                } 
            }
            catch (Exception)
            {
                oR.message = "Ocurrio un error en el servidor, intenta más tarde";
            }
            return oR;
        }

    }
}
