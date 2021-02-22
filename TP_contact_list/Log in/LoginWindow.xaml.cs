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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

        }

        private void BouttonInscription_Click(object sender, RoutedEventArgs e)
        {
            new Contact().Show();
            this.Close();
        }


        private void Connect_click(object sender, RoutedEventArgs e)
        {
            if (Email.Text == string.Empty || Pass.Password == string.Empty)
            {

            }
            else
            {
                try
                {
                    Manager.LogAccount(Email.Text, Pass.Password);
                    new ContacteCreer().Show();
                    this.Close();

                }
                catch (NullReferenceException)
                {
                    MgsErr.Text = "ce compte n'existe pas essayer un autre";

                }
                catch (System.IO.FileNotFoundException)
                {
                    MgsErr.Text = "ce compte n'existe pas essayer un autre";
                    Manager.CreationListCompte();
                }
            }

        }
    }
}
