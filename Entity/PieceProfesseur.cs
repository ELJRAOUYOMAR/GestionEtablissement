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
    
    public partial class PieceProfesseur
    {
        public int IdPiece { get; set; }
        public string Chemin { get; set; }
        public byte[] Photo { get; set; }
        public string piece { get; set; }
        public Nullable<int> IdProfesseur { get; set; }
    
        public virtual Professeur Professeur { get; set; }
    }
}
