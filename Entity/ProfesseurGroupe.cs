//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProjectInstitute.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfesseurGroupe
    {
        public int IdGroupe { get; set; }
        public int IdProfesseur { get; set; }
        public string Look { get; set; }
    
        public virtual Groupe Groupe { get; set; }
        public virtual Professeur Professeur { get; set; }
    }
}
