using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BLL;

namespace Log_in
{

    public partial class ContacteCreer : Window
    {
        public ContacteCreer()
        {
            InitializeComponent();
            lblNom_Utilisateur.Content = Manager.GetFullName();

            string[] listContact = Manager.GetContacts();

            if (listContact == null)
            {

            }
            else
            {

                foreach (String contact in listContact)
                {
                    string[] listPropre = contact.Split('/');
                    for (int i = 0; i < listPropre.Length; i++)
                    {
                        lblListe.Content += listPropre[i] + " ";

                    }
                    lblListe.Content += "\n";
                }
            }
        }

        private void AJOUTER_Click(object sender, RoutedEventArgs e)
        {
            new NewContact().Show();
            Close();
        }

        private void SUPPRIMER_Click_1(object sender, RoutedEventArgs e)
        {
            new SupprimerContact().Show();
            Close();
        }
    }
}
