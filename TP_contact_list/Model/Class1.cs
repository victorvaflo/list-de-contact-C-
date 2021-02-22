using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    public class EmailDejaUtiliseeExpetion : Exception
    {
        public EmailDejaUtiliseeExpetion()
        {
        }

        public EmailDejaUtiliseeExpetion(string message)
            : base(message)
        {
        }

        public EmailDejaUtiliseeExpetion(string message, Exception inner)
            : base(message, inner)
        {
        }

    }

    public class Compte
    {
        public String Email { get; private set; }
        public string Prenom { get; set; }
        public String Nom { get; set; }
        public string MotPasse { get; private set; }

        public Compte(string email, string prenom, string nom, string motPasse)
        {
            Email = email;
            Prenom = prenom;
            Nom = nom;
            MotPasse = motPasse;
        }


    }
    public class Contact
    {
        public string Prenom { get; set; }
        public String Nom { get; set; }
        public String Telephone { get; private set; }


        public Contact(string prenom, string nom, string telephone)
        {
            Prenom = prenom;
            Nom = nom;
            Telephone = telephone;

        }

    }
}
