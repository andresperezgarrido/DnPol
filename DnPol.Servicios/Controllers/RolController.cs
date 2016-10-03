using DnPol.Business;
using DnPol.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DnPol.Servicios.Controllers
{
    public class RolController : ApiController
    {
        [HttpPost]
        public void CrearRol([FromBody] Rol rol)
        {
            var logica = new Logica();
            logica.CrearRol(rol);
        }

        [HttpGet]
        public ICollection<Rol> Get()
        {
            var logica = new Logica();
            return logica.ListarRoles();
        }

        [HttpGet]
        public Rol Get(int id)
        {
            var logica = new Logica();
            return logica.ListarRol(id);
        }
    }
}
