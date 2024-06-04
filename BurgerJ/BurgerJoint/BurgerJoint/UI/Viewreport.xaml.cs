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
    /// Interaction logic for Viewreport.xaml
    /// </summary>
    public partial class Viewreport : Page
    {
        DatabaseRepository repository = new DatabaseRepository();
        OrderItem saleList = new OrderItem();
        public Viewreport()
        {
            InitializeComponent();
            loadList();
        }
        public void loadList()
        {
            OrderItem saleList = new OrderItem();
            reportGrid.ItemsSource = saleList.getOrderItemdetails();
            reportGrid.Items.Refresh();
        }

        private void refrshBtn_Click(object sender, RoutedEventArgs e)
        {
            loadList();
            selectCatgry.Text = "";
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var txtName = sender as TextBox;
            if (txtName.Text != "")
            {
                var filterList = saleList.getOrderItemdetails().Where(a => a.ItemName.Contains(txtName.Text));
                reportGrid.ItemsSource = null;
                reportGrid.ItemsSource = filterList;
            }
        }

        private void selectCatgry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectCatgry = sender as ComboBox;
            if (selectCatgry.Text != "")
            {
                if (selectCatgry.Text == "Burger")
                {
                    var filterList1 = saleList.getOrderItemdetails().Where(b => b.Category == "Burger").ToList();
                    reportGrid.ItemsSource = null;
                    reportGrid.ItemsSource = filterList1;
                }
                else if (selectCatgry.Text == "Beverage")
                {
                    var filterList2 = saleList.getOrderItemdetails().Where(a => a.Category == "Beverage").ToList();
                    reportGrid.ItemsSource = null;
                    reportGrid.ItemsSource = filterList2;
                }
                else if (selectCatgry.Text == "Sides")
                {
                    var filterList3 = saleList.getOrderItemdetails().Where(a => a.Category == "Sides").ToList();
                    reportGrid.ItemsSource = null;
                    reportGrid.ItemsSource = filterList3;
                }
            }
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (selectCatgry.Text == "Burger")
            {
                var filterList = saleList.getOrderItemdetails().Where(b => b.Category == "Burger").ToList();
                reportGrid.ItemsSource = null;
                reportGrid.ItemsSource = filterList;
            }
            else if (selectCatgry.Text == "Beverage")
            {
                var filterList = saleList.getOrderItemdetails().Where(a => a.Category == "Beverage").ToList();
                reportGrid.ItemsSource = null;
                reportGrid.ItemsSource = filterList;
            }
            else if (selectCatgry.Text == "Sides")
            {
                var filterList = saleList.getOrderItemdetails().Where(a => a.Category == "Sides").ToList();
                reportGrid.ItemsSource = null;
                reportGrid.ItemsSource = filterList;
            }
            else
            {
                loadList();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = true;
                PrintDialog print = new PrintDialog();
                if (print.ShowDialog() == true)
                {
                    PrintDialog print1 = print;
                   // PrintDialog.PrintVisual(PrintDialog, "Viewreport.xaml");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }

        private void selectDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            OrderItem saleList = new OrderItem();
            var filterList = saleList.getOrderItemdetails().Where(b => b.orderDate == selectDate.SelectedDate).ToList();
            reportGrid.ItemsSource = null;
            reportGrid.ItemsSource = filterList;
           // List<Order> saleList = repository.Orders.ToList();
            //reportGrid.ItemsSource = saleList;
            //reportGrid.Items.Refresh();    
        }

        private void txtName_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
