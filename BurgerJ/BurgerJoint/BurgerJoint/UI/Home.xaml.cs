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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BurgerJoint.UI
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            //procdtopay.Visibility = Visibility.Hidden;
            //Homewnd.Height = System.Windows.SystemParameters.PrimaryScreenHeight*0.8;
            //Homewnd.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.8);
        }
        private void logBtn_Click(object sender, RoutedEventArgs e)
        {
            Adminlogin adminlog = new Adminlogin();
            adminlog.Owner = Application.Current.MainWindow;
            adminlog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            adminlog.ShowDialog();
        }

        private void bjexit_Click(object sender, RoutedEventArgs e)
        {
            Home window = Application.Current.MainWindow as Home;
            window.Close();
        }

        private void bjburger_Click(object sender, RoutedEventArgs e)
        {
            Burger burger = new Burger();
            myFrame.Navigate(burger);
        }

        private void bjhome_Click(object sender, RoutedEventArgs e)
        {
            Welcome welcome = new Welcome();
            myFrame.Navigate(welcome);
        }

        private void bjbeve_Click(object sender, RoutedEventArgs e)
        {
            Beverage beverage = new Beverage();
            myFrame.Navigate(beverage);
        }

        private void bjside_Click(object sender, RoutedEventArgs e)
        {
            Sides sides = new Sides();
            myFrame.Navigate(sides);
        }

        private void bjabout_Click(object sender, RoutedEventArgs e)
        {
            Aboutus aboutus = new Aboutus();
            myFrame.Navigate(aboutus);
        }

        private void procdtopay_Click(object sender, RoutedEventArgs e)
        {
            int Total = Global.sub.Sum();
            Global.total = Total;


            Custorder custorder = new Custorder();
            custorder.Show();
        }
    }
}
