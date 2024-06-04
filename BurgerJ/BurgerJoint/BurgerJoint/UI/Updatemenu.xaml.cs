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
    /// Interaction logic for Updatemenu.xaml
    /// </summary>
    public partial class Updatemenu : Page
    {
        public Item updateItem = new Item();
        public Updatemenu()
        {
            InitializeComponent();
            allClear();
            refreshList();
        }
        private void clrBtn_Click(object sender, RoutedEventArgs e)
        {
            allClear();
        }

        public void allClear()
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
            //delBtn.IsEnabled = false;
            updateItem.ItemId = 0;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                int itemId = (crudGrid.SelectedItem as Item).ItemId;
                Item updateItem = (from m in repository.Items where m.ItemId == itemId select m).Single();
                updateItem.ItemName = nametxtbox.Text;
                updateItem.UnitPrice = int.Parse(pricetxtbox.Text);
                updateItem.Imagepath = pathTxtbx.Text;
                updateItem.ItemPhoto = File.ReadAllBytes(pathTxtbx.Text);
                updateItem.Category = cattcombobox.Text;
                updateItem.Description = desctxtbox.Text;
                repository.SaveChanges();
                refreshList();
                MessageBox.Show("Successfully saved!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public void refreshList()
        {
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                List<Item> itemd = repository.Items.ToList();
                crudGrid.ItemsSource = itemd;
                crudGrid.Items.Refresh();
            }
        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {
            /*  if (MessageBox.Show("Delete?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
             {
                 using (DatabaseRepository repository = new DatabaseRepository())
                 {
                     if (MessageBox.Show("Delete?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                     {
                         repository.Items.Remove(updateItem);
                         repository.SaveChanges();
                         _ = updateItem == null;
                         refreshList();
                         MessageBox.Show("deleted");
                     }*/

            if (MessageBox.Show("Delete?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                using (DatabaseRepository repository = new DatabaseRepository())
                {
                    var entry = repository.Entry(updateItem);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        repository.Items.Attach(updateItem);
                    allClear();
                    repository.Items.Remove(updateItem);
                    repository.SaveChanges();
                    List<Item> itemd = repository.Items.ToList();
                    crudGrid.ItemsSource = itemd;
                    crudGrid.Items.Refresh();

                    MessageBox.Show("Successfully deleted");
                }

            }
        }

        private void slctBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentRowIndex = crudGrid.Items.IndexOf(crudGrid.CurrentItem);
            if (currentRowIndex != -1)
            {
                using (DatabaseRepository repository = new DatabaseRepository())
                {
                    // updateItem.ItemId = Convert.ToInt32(crudGrid.CurrentItem.Cell["ItemId"].Value);
                    Item item = crudGrid.SelectedItem as Item;
                    Item updateItem = (from m in repository.Items where m.ItemId == item.ItemId select m).SingleOrDefault();
                    updateItem = repository.Items.Where(x => x.ItemId == updateItem.ItemId).SingleOrDefault();
                    nametxtbox.Text = updateItem.ItemName;
                    pricetxtbox.Text = updateItem.UnitPrice.ToString();
                    cattcombobox.Text = updateItem.Category;
                    desctxtbox.Text = updateItem.Description;
                    pathTxtbx.Text = updateItem.Imagepath;
                    ImageSource imageSource = new BitmapImage(new Uri(updateItem.Imagepath));
                    image1.Source = imageSource;
                }
            }
        }

        private void brws_Click(object sender, RoutedEventArgs e)
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

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            DatabaseRepository repository = new DatabaseRepository();
            Item dltItem = crudGrid.SelectedItem as Item;
            Item updateItem = (from m in repository.Items where m.ItemId == dltItem.ItemId select m).SingleOrDefault();
            allClear();
            if (MessageBox.Show("Delete?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //currentItem - repository.Items.Where(c => c.ItemId == dltItem.ItemId).Single();
                repository.Items.Remove(updateItem);
                repository.SaveChanges();
                crudGrid.ItemsSource = repository.Items.ToList();
                crudGrid.Items.Refresh();
                MessageBox.Show("deleted");
            }
        }

        
    }
}

