using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WenApi.Entidades;
namespace WenApi.Controllers
{
    public class EmpleadosController : ApiController
    {
        // GET: api/Empleados
        public Empleado Get()
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Salvador";
            emp.Rut = "27003843-3";
            emp.Cargo = "Bebé de la casa";
            return emp;
            
        }

        // GET: api/Empleados/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Empleados
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Empleados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Empleados/5
        public void Delete(int id)
        {
        }
    }
}
