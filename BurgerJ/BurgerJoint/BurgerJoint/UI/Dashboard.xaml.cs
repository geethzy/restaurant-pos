using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BurgerJoint.UI
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void rpt_Click(object sender, RoutedEventArgs e)
        {
            Viewreport viewreport = new Viewreport();
            adminFrame.Navigate(viewreport);
        }

        private void updt_Click(object sender, RoutedEventArgs e)
        {
            Updatemenu update = new Updatemenu();
            adminFrame.Navigate(update);
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Addmenu add = new Addmenu();
            adminFrame.Navigate(add);
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
