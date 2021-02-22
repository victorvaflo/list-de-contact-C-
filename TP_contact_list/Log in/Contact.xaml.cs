using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Windows;
using BLL;

namespace Log_in
{
    /// <summary>
    /// Interaction logic for Contact.xaml
    /// </summary>
    public partial class Contact : Window
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            new LoginWindow().Show();
            this.Close();
        }

        private void Inscription_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Manager.Verification(Email.Text);
                if (Nom.Text == string.Empty || Prenom.Text == string.Empty || MotPass.Password == string.Empty || Email.Text == string.Empty)
                {
                    MsgErr.Text = "rentre tous les information ";
                }
                else if (MotPass.Password != ConfigPass.Password)
                {
                    MsgErr.Text = "le mot de passe n'est pas le meme";
                }
                else
                {
                    Manager.CreateAccount(Email.Text, Prenom.Text, Nom.Text, MotPass.Password);
                    new ContacteCreer().Show();
                    this.Close();
                }
            }
            catch (EmailDejaUtiliseeExpetion)
            {
                MsgErr.Text = "ce Email a deja etait utilise saisir un autre";
            }

        }

    }
}
