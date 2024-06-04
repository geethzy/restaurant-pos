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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BurgerJoint.UI
{
    /// <summary>
    /// Interaction logic for Beverage.xaml
    /// </summary>
    public partial class Beverage : Page
    {
        public Beverage()
        {
            InitializeComponent();
            loadlist();
            Calculation();
        }
        private void loadlist()
        {
            DatabaseRepository foodtitem = new DatabaseRepository();

            burgerlist.ItemsSource = foodtitem.Items.Where(a => a.Category == "Beverage").ToList();

        }
        public void Calculation()
        {
            int total1 = Global.total;
            int total = total1;
            var nsg = total.ToString();
            //DispalyTotal.Text = nsg;


        }

        public void Add_to_oder(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var DataObj = btn.DataContext as Item;
            int Itemprice = DataObj.UnitPrice;
            string itemprice1 = Itemprice.ToString();
            String ItemName = DataObj.ItemName;
            Global.itemName = ItemName;
            Global.itemprice = Itemprice;
            Global.ListItem.Add(ItemName);
            Global.Listprice.Add(itemprice1);

            int Quantity = Global.Quantity;
            int Subtotal = Itemprice * Quantity;
            string covertsubtotle = Subtotal.ToString();
            Global.ListSub.Add(covertsubtotle);
            Global.sub.Add(Subtotal);

            addtoOder();



            MessageBox.Show("Successfully added to the cart!", "Info", MessageBoxButton.OK);
        }

        private void addtoOder()
        {
            DatabaseRepository foodtitem = new DatabaseRepository();

            Order newOrder = new Order();
            {
                newOrder.ItemName = Global.itemName;
                newOrder.UnitPrice = Global.itemprice;
                newOrder.Quantity = Global.Quantity;
                newOrder.orderDate = DateTime.Today;
                foodtitem.Orders.Add(newOrder);
                foodtitem.SaveChanges();

            }

        }
    }
}

