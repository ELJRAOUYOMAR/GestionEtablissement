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
    
    public partial class Seance
    {
        public int IdSeance { get; set; }
        public Nullable<int> Année_de_seance { get; set; }
        public string Mois_de_seance { get; set; }
        public string Jour_de_seance { get; set; }
        public string Heure_Debut { get; set; }
        public string Heure_Fin { get; set; }
        public string Etat { get; set; }
        public Nullable<int> Id_Professeur { get; set; }
        public Nullable<int> Id_Group { get; set; }
        public Nullable<int> Id_Formation { get; set; }
        public string Salle { get; set; }
    
        public virtual Formation Formation { get; set; }
        public virtual Groupe Groupe { get; set; }
        public virtual Professeur Professeur { get; set; }
    }
}
