//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalEmprego_Wth_MemberShip_And_mvc5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatusVaga
    {
        public StatusVaga()
        {
            this.Anuncios = new HashSet<Anuncio>();
        }
    
        public int Id { get; set; }
        public string Status { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<Anuncio> Anuncios { get; set; }
    }
}
