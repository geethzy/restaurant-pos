using BurgerJoint.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Adminlogin.xaml
    /// </summary>
    public partial class Adminlogin : Window
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string AdminPwd { get; set; }
        public Adminlogin()
        {
            InitializeComponent();

        }

        private void adminlog_Click(object sender, RoutedEventArgs e)
        {
            DatabaseRepository repository = new DatabaseRepository();
            UserName = mailText.Text;
            AdminPwd = pwdText1.Password;
            AdminPwd = pwdText2.Password;

            
            foreach (var admin in repository.Admins)
            {
                if (mailText.Text.Length == 0)
                {
                    errormessage.Text = "Enter the email.";
                    mailText.Focus();
                }
            else if (!Regex.IsMatch(mailText.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                mailText.Select(0, mailText.Text.Length);
                mailText.Focus();
            }

            else if (pwdText1.Password.Length == 0)
            {
                errormessage.Text = "Enter the password.";
                pwdText1.Focus();
            }
            else if (pwdText2.Password.Length == 0)
            {
                errormessage.Text = "Enter Confirm password.";
                pwdText2.Focus();
            }
            else if (pwdText1.Password != pwdText2.Password)
            {
                errormessage.Text = "Confirm password must be same as password.";
                    pwdText1.Focus();
            }
            else if (mailText.Text == admin.UserName)
                {
                    if (pwdText1.Password == admin.AdminPwd)
                    {
                        if (pwdText2.Password == admin.AdminPwd)
                        {
                            Dashboard dash = new Dashboard();
                            dash.Show();
                            this.Hide();
                        }
                    }
                }
            else
                {
                    //errormessage.Text = "";
                   // MessageBox.Show("Invalid Login");
                }
            }

            /*var admin = repository.Admins.Where(i => i.AdminId == this.AdminId).FirstOrDefault();

             if (admin == null)
             {
                 MessageBox.Show("Unable to Login, incorrect credentials.");

             }
             else if (mailText.Text == admin.UserName || pwdText.Password == admin.AdminPwd)
             {
                 MessageBox.Show("Successfully Logged in, ");
             }
             else
             {
                 MessageBox.Show("Unable to Login, incorrect credentials.");
             }
         }*/
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Adminlogin log = new Adminlogin();
            log.Hide();
        }
    }
}