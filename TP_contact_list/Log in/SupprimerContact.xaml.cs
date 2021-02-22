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
    /// Interaction logic for SupprimerContact.xaml
    /// </summary>
    public partial class SupprimerContact : Window
    {
        public SupprimerContact()
        {
            InitializeComponent();
        }

        private void CANCEL_CLICK(object sender, RoutedEventArgs e)
        {
            new ContacteCreer().Show();
            Close();
        }

        private void SUPPRIMER_CLICK(object sender, RoutedEventArgs e)
        {
            if (Preom.Text == string.Empty || Nom.Text == string.Empty)
            {

            }
            else
            {
                Manager.EffacerContact(Preom.Text, Nom.Text);
                new ContacteCreer().Show();
                Close();
            }
        }
    }
}
