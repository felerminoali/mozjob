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
    
    public partial class Recrutador
    {
        public Recrutador()
        {
            this.Anuncios = new HashSet<Anuncio>();
            this.Anuncios1 = new HashSet<Anuncio>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public bool isSelected { get; set; }
    
        public virtual ICollection<Anuncio> Anuncios { get; set; }
        public virtual ICollection<Anuncio> Anuncios1 { get; set; }
    }
}
