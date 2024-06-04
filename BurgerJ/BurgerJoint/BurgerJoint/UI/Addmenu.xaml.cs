using BurgerJoint.Database;
using BurgerJoint.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Addmenu.xaml
    /// </summary>
    public partial class Addmenu : Page
    {
        DatabaseRepository repository = new DatabaseRepository();
        public Addmenu()
        {
            InitializeComponent();
            get_count();
        }
        public void get_count()
        {
            List<Item> itemlist = repository.Items.ToList();
            var burg = itemlist.Where(Item => Item.Category == "Burger");
            var burg_cnt = burg.Count();
            burgCount.Text = burg_cnt.ToString();

            var drnk = itemlist.Where(Item => Item.Category == "Beverage");
            var drnk_cnt = drnk.Count();
            drnkCount.Text = drnk_cnt.ToString();

            var side = itemlist.Where(Item => Item.Category == "Sides");
            var side_cnt = side.Count();
            sideCount.Text = side_cnt.ToString();
        }

        private void brws_Click_1(object sender, RoutedEventArgs e)
        {
            Item images = new Item();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
             "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
             "Portable Network Graphic (*.png)|*.png";
            openFileDialog1.DefaultExt = ".jpeg";
            pathTxtbx.Text = openFileDialog1.FileName;
            ImageSource imageSource = new BitmapImage(new Uri(pathTxtbx.Text));
            image1.Source = imageSource;
        }

        private void AddBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Item newitem = new Item();

            if (nametxtbox.Text == "")
            {
                MessageBox.Show("Please enter the name of the new menu", "Info", MessageBoxButton.OK);
            }
            else if (pricetxtbox.Text == "")
            {
                MessageBox.Show("Please enter the price of the new menu", "Info", MessageBoxButton.OK);
            }
            else if (cattcombobox.Text == "")
            {
                MessageBox.Show("Please select the category of the new menu", "Info", MessageBoxButton.OK);
            }
            else if (desctxtbox.Text == "")
            {
                MessageBox.Show("Please enter the descriptioin of the new menu", "Info", MessageBoxButton.OK);
            }
            else if (pathTxtbx.Text == "")
            {
                MessageBox.Show("Please select a photo to the new menu", "Info", MessageBoxButton.OK);
            }
            else
            {
                newitem.ItemName = nametxtbox.Text;
                newitem.UnitPrice = int.Parse(pricetxtbox.Text);
                newitem.Imagepath = pathTxtbx.Text;
                newitem.ItemPhoto = File.ReadAllBytes(pathTxtbx.Text);
                newitem.Category = cattcombobox.Text;
                newitem.Description = desctxtbox.Text;
                repository.Items.Add(newitem);
                repository.SaveChanges();
                MessageBox.Show("Successfully saved!", "Info", MessageBoxButton.OK,MessageBoxImage.Information);
            }
            get_count();
            if (cattcombobox.Text == "Burger")
            {
                burgLaunch.Text = "NEW Launch!";
            }
            else if (cattcombobox.Text == "Beverage")
            {
                drnkLaunch.Text = "NEW Launch!";
            }
            else if (cattcombobox.Text == "Sides")
            {
                sideLaunch.Text = "NEW Launch!";
            }
        }

        private void clrBtn_Click_1(object sender, RoutedEventArgs e)
        {
            nametxtbox.Text = "";
            pricetxtbox.Text = "";
            cattcombobox.Text = "";
            desctxtbox.Text = "";
            pathTxtbx.Text = "";
            if (pathTxtbx.Text == "")
            {
                image1.Source = null;
            }
            burgLaunch.Text = "";
            drnkLaunch.Text = "";
            sideLaunch.Text = "";
        }
    }
}
