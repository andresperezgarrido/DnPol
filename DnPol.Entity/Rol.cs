//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DnPol.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rol
    {
        public Rol()
        {
            this.Usuarios = new HashSet<User>();
        }
    
        public int IdRol { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<User> Usuarios { get; set; }
    }
}