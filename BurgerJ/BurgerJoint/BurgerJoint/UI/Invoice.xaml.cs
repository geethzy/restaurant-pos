using BurgerJoint.Database;
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
    /// Interaction logic for Invoice.xaml
    /// </summary>
    public partial class Invoice : Window
    {
        public Invoice()
        {
            InitializeComponent();
            DatabaseRepository foodtitem = new DatabaseRepository();


           

            displayDate.Text = Global.date;
            displayTotal.Text = Global.total.ToString();
            displayItemName.ItemsSource = Global.ListItem;
            displayUnitPrice.ItemsSource = Global.Listprice;
            displaySubTotal.ItemsSource = Global.ListSub;
            displayQuntity.ItemsSource = Global.ListQuantity;
        }
    }
}
