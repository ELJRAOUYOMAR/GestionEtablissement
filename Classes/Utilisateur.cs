using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MyProjectInstitute.Entity;

namespace MyProjectInstitute.Classes
{
    class Utilisateur
    {
        EducationInstitute Education= new EducationInstitute();
        public  int ID { get; set; }
        public string NomComplet { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
        public string nomUtilisateur { get; set; }
        public Boolean Role { get; set; }
        public byte Photo { get; set; }

        public Utilisateur(string Email,string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
        public Utilisateur(string Email, string Password,string Code):this(Email,Password)
        {
            this.Code = Code;
        }

        public Utilisateur(int iD, string nomComplet, string email, string password, string code, string nomUtilisateur, bool role, byte photo)
        {
            ID = iD;
            NomComplet = nomComplet;
            Email = email;
            Password = password;
            Code = code;
            this.nomUtilisateur = nomUtilisateur;
            Role = role;
            Photo = photo;
        }

        public void Seconnecter(string email,string password)
        {
            
        }
    }
}
