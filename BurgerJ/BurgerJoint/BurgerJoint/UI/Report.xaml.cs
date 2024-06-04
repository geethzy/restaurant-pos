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
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        DatabaseRepository repository = new DatabaseRepository();
        OrderItem saleList = new OrderItem();
        public Report()
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
        }

        private void selectCatgry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {         
            var selectCatgry = sender as ComboBox;
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
           /* var txtName = sender as TextBox;
            if (txtName.Text != "")
            {
                //burgerlist.ItemsSource = foodtitem.Items.Where(a => a.Category == "Burger").ToList();
               // reportGrid.ItemsSource = OrderItem.Where(a => a.ItemName.Contains(txtName.Text).ToList();
                var filterList = saleList(a => a.ItemName.Contains(txtName.Text).ToList();
                reportGrid.ItemsSource = null;
                reportGrid.ItemsSource = filterList;
            }
           */
        }
        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
          /*  OrderItem saleList = new OrderItem();
            reportGrid.ItemsSource = saleList.getOrderItemdetails();
            reportGrid.Items.Refresh();
            if (selectCatgry.Text == "Burger")
            {
                var filterList = reportGrid.(b => b.Category == "Burger").ToList();
                reportGrid.ItemsSource = null;
                reportGrid.ItemsSource = filterList;
            }
            else if (selectCatgry.Text == "Beverage")
            {
                var filterList = saleList.(a => a.Category == "Beverage").ToList();
                reportGrid.ItemsSource = null;
                reportGrid.ItemsSource = filterList;
            }
            else if (selectCatgry.Text == "Sides")
            {
                var filterList = saleList.(a => a.Category == "Sides").ToList();
                reportGrid.ItemsSource = null;
                reportGrid.ItemsSource = filterList;
            }
            else
            {
                loadList();
            }*/
        
        }
        private void clrBtn_Click(object sender, RoutedEventArgs e)
        {
            selectCatgry.Text = "";
            txtName.Text = "";
            loadList();
        }

        private void Tabs1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /* private void selectDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
         {
              SelectedDateTextBox.Text = selectDate.SelectedDate.ToString();
         List<Order> saleList = repository.Orders.ToList();
         reportGrid.ItemsSource = saleList;
         reportGrid.Items.Refresh();

          var picker = sender as DatePicker;  
      DateTime? date = picker.SelectedDate;

      if (date == null) { 
         this.Title = "No date"; 
      } 
      else { 
         this.Title = date.Value.ToShortDateString(); 
      } 
          */
    }
    }

