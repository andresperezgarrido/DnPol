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
    
    public partial class User
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public Nullable<int> IdRol { get; set; }
    
        public virtual Rol Roles { get; set; }
    }
}
