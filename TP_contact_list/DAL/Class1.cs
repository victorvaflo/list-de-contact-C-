
using System.Collections.Generic;
using System.IO;
using Model;

namespace DAL
{
    public class Service
    {

        public static void FileAccount()
        {
            File.AppendAllText("../../Accounts", null);
        }
        public static void AddAcount(Compte cmpt)
        {
            File.AppendAllText("../../Accounts", cmpt.Email + "/" + cmpt.MotPasse + "/" + cmpt.Nom + "/" + cmpt.Prenom + "\n");

        }


        public static Compte GetAccount(string email, string pass)
        {
            string[] lignes = File.ReadAllLines("../../Accounts");


            for (int i = 0; i < lignes.Length; i++)
            {
                if (lignes[i].Contains(email + "/" + pass))
                {
                    string[] compte = lignes[i].Split('/');

                    Compte cmpt = new Compte(compte[0], compte[3], compte[2], compte[1]);
                    return cmpt;
                }
            }
            return null;

        }

        public static bool ExistingAccount(string email)
        {
            string[] lignes = File.ReadAllLines("../../Accounts");


            for (int i = 0; i < lignes.Length; i++)
            {
                if (lignes[i].Contains(email))
                {
                    return true;
                }
            }
            return false;
        }

        public static void CreateContactList(Compte cmpt)
        {
            File.AppendAllText("../../list Contact de " + cmpt.Nom + cmpt.Prenom + cmpt.Email, null);
        }
        public static void AddContact(Contact contact, Compte cmpt)
        {
            File.AppendAllText("../../list Contact de " + cmpt.Nom + cmpt.Prenom + cmpt.Email, contact.Prenom + "/" + contact.Nom + "/" + "(" + contact.Telephone + ")" + "\n");
        }



        public static string[] GetContactList(Compte cmpt)
        {
            string[] list = File.ReadAllLines("../../list Contact de " + cmpt.Nom + cmpt.Prenom + cmpt.Email);
            return list;
        }

        public static void DeleteContact(string prenom, string nom, Compte cmpt)
        {
            string[] lignes = File.ReadAllLines("../../list Contact de " + cmpt.Nom + cmpt.Prenom + cmpt.Email);
            File.Delete("../../list Contact de " + cmpt.Nom + cmpt.Prenom + cmpt.Email);


            for (int i = 0; i < lignes.Length; i++)
            {
                if (lignes[i].Contains(prenom + "/" + nom))
                {
                    File.AppendAllText("../../list Contact de " + cmpt.Nom + cmpt.Prenom + cmpt.Email, null);

                }
                else
                {
                    File.AppendAllText("../../list Contact de " + cmpt.Nom + cmpt.Prenom + cmpt.Email, lignes[i] + "\n");
                }
            }

        }


    }

}
