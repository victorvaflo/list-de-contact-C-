using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BLL;

namespace Log_in
{
    /// <summary>
    /// Interaction logic for NewContact.xaml
    /// </summary>
    public partial class NewContact : Window
    {
        public NewContact()
        {
            InitializeComponent();
        }




        private void CANCEL_Click_(object sender, RoutedEventArgs e)
        {
            new ContacteCreer().Show();
            Close();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            if (Prenom.Text == string.Empty && Nom.Text == string.Empty && Telephone.Text == string.Empty)
            {

            }
            else
            {
                Manager.CreateContact(Prenom.Text, Nom.Text, Telephone.Text);
                new ContacteCreer().Show();
                Close();
            }
        }
    }
}
