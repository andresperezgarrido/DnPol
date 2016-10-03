using DnPol.Entity;
using System.Collections.Generic;
using System.Linq;

namespace DnPol.Data
{
    public class Datos
    {
        public Rol CrearRol(Rol rol)
        {
            var contexto = new DnPolContexto();
            rol = contexto.Roles.Add(rol);
            contexto.SaveChanges();
            return rol;
        }

        public ICollection<Rol> ListarRoles()
        {
            var contexto = new DnPolContexto();
            return contexto.Roles.ToList();
        }
    }
}
