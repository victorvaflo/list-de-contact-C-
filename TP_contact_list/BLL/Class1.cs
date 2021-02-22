using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class Manager
    {
        public static Compte compteEnMrche;
        public static void CreateAccount(string email, string prenom, string nom, string motPasse)
        {
            Compte cmpt = new Compte(email, prenom, nom, motPasse);

            Service.AddAcount(cmpt);
            Service.CreateContactList(cmpt);
            compteEnMrche = cmpt;
        }
        public static void LogAccount(string email, string pass)
        {
            compteEnMrche = Service.GetAccount(email, pass);

        }

        public static void CreateContact(string prenom, string nom, string telephone)
        {
            Contact contact = new Contact(prenom, nom, telephone);
            Service.AddContact(contact, compteEnMrche);
        }

        public static string[] GetContacts()
        {
            string[] list = Service.GetContactList(compteEnMrche);

            return list;
        }

        public static string GetFullName()
        {
            string fullName = compteEnMrche.Prenom + " " + compteEnMrche.Nom;

            return fullName;
        }

        public static void CreationListCompte()
        {
            Service.FileAccount();
        }

        public static void Verification(string email)
        {
            bool compteExist = Service.ExistingAccount(email);
            if (compteExist)
            {
                throw new EmailDejaUtiliseeExpetion();
            }
        }
        public static void EffacerContact(string prenom, string nom)
        {
            Service.DeleteContact(prenom, nom, compteEnMrche);
        }

    }
}
