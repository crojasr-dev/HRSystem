using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Cors;
using WenApi.Entidades;
//using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WenApi.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("v1")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmpleadosController : ApiController
    {
        // GET: api/Empleados
        [Route("getEmpleados")]
        public Empleado Get()
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Salvador";
            emp.Rut = "27003843-3";
            emp.Cargo = "Estudiante";
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
