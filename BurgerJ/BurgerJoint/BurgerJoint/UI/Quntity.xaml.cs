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
    /// Interaction logic for Quntity.xaml
    /// </summary>
    public partial class Quntity : UserControl
    {
        public Quntity()
        {
            InitializeComponent();
        }

     /*   private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            // YesButton Clicked! Let's hide our InputBox and handle the input text.
            InputBox.Visibility = System.Windows.Visibility.Collapsed;

            // Do something with the Input
            String input = InputTextBox.Text;
            int Quantity = Int32.Parse(input);
            Global.Quantity = Quantity;
            Global.ListQuantity.Add(input);
            int Itemprice = Global.Itemprice;
            string convertprice = Itemprice.ToString();
            Global.Listprice.Add(convertprice);
            int Subtotal = Itemprice * Quantity;
            string covertsubtotle = Subtotal.ToString();
            Global.ListSub.Add(covertsubtotle);
            Global.sub.Add(Subtotal);
            int Total = Global.sub.Sum();
            Global.total = Total;
            addtoOder();

        }*/

       

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // YesButton Clicked! Let's hide our InputBox and handle the input text.
            //InputBox.Visibility = System.Windows.Visibility.Collapsed;

            // Do something with the Input
            String input = InputTextBox.Text;
            int Quantity = Int32.Parse(input);
            Global.Quantity = Quantity;
            Global.ListQuantity.Add(input);
            int Itemprice = Global.Itemprice;
            string convertprice = Itemprice.ToString();
            //Global.Listprice.Add(convertprice);
            int Subtotal = Itemprice * Quantity;
            string covertsubtotle = Subtotal.ToString();
           // Global.ListSub.Add(covertsubtotle);
          //  Global.sub.Add(Subtotal);
            int Total = Global.sub.Sum();
           // Global.total = Total;
            
        }
    }
}
