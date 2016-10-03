using DnPol.Data;
using DnPol.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DnPol.Business
{
    public class Logica
    {
        public Rol CrearRol(Rol rol)
        {
            var datos = new Datos();
            rol = datos.CrearRol(rol);
            return rol;
        }

        public Rol ListarRol(int idRol)
        {
            var datos = new Datos();
            var roles = datos.ListarRoles();
            Rol rol = null;

            if (idRol > 0)
            {
                rol = roles.Where(x => x.IdRol == idRol).FirstOrDefault();
            }

            return rol;
        }

        public ICollection<Rol> ListarRoles()
        {
            var datos = new Datos();
            var roles = datos.ListarRoles();
            return roles;
        }
    }
}
