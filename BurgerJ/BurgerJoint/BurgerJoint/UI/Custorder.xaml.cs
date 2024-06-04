using BurgerJoint.Database;
using BurgerJoint.Models;
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
    /// Interaction logic for Custorder.xaml
    /// </summary>
    public partial class Custorder : Window
    {
        public Custorder()
        {
            InitializeComponent();
            loadlist();
            Calculation();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // burgerlist.ItemsSource = Global.orderedItems;
        }

        private void Calculation()
        {
            int total1 = Global.total;
            int total = total1;
            var nsg = total.ToString();
            DisplayTotal.Text = nsg;

            loadlist();

        }

        private void loadlist()
        {
            lvDataBinding.ItemsSource = Global.ListItem;
            lvQuntityBinding.ItemsSource = Global.ListQuantity;
            lvPriceBinding.ItemsSource = Global.Listprice;
            lvSubtotleBinding.ItemsSource = Global.sub;

            //listbox.DataContext = Global.ListItem;
            //txtName.Text = Global.ListItem.ToString();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DatabaseRepository repositoryDb = new DatabaseRepository();


            Payment newPayment = new Payment();


            newPayment.TotalPrice = Global.total;
            newPayment.PayDate = DateTime.Today;
            repositoryDb.Payments.Add(newPayment);
            repositoryDb.SaveChanges();
            // MessageBox.Show(thisDay.ToString("f"));




        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Global.ListItem.Clear();
            Global.sub.Clear();
            Global.ListQuantity.Clear();
            Global.Listprice.Clear();
            Global.ListSub.Clear();

            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            DatabaseRepository repositoryDb = new DatabaseRepository();

            Bill bill = new Bill();
            bill.TotalPrice = Global.total;
            bill.PayDate = DateTime.Today;
            bill.PayTime = DateTime.Now;
            repositoryDb.Bills.Add(bill);
            repositoryDb.SaveChanges();

            DateTime thisDay = DateTime.Today;
            Global.date = thisDay.ToString("f");
            Showinvoice();
            
        }

        private void Showinvoice()
        {
            Invoice invoice = new Invoice();
            invoice.Show();
            this.Hide();
        }
    }
}
