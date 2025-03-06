using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddUser.xaml
    /// </summary>
    public partial class PageAddUser : Page
    {
        public PageAddUser()
        {
            InitializeComponent();

            cmbRole.DisplayMemberPath = "RoleName";
            cmbRole.SelectedValuePath = "RoleName";
            cmbRole.ItemsSource = AuxClasses.DBClass.entObj.Roles.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int rid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbRole.SelectedItem)["Id"].GetValue(cmbRole.SelectedItem));

            AuxClasses.Users user = new AuxClasses.Users()
            {
                Username = txbUsername.Text,
                Password = txbPassword.Text,
                FullName = txbFullName.Text,
                RoleId = rid,
                IsRegistered = (bool)cbIsRegistered.IsChecked,
                IsBlocked = (bool)cbIsBlocked.IsChecked
            };

            AuxClasses.DBClass.entObj.Users.Add(user);
            AuxClasses.DBClass.entObj.SaveChanges();
            MessageBox.Show("Добавлено");
        }

        private void menuBack_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }
    }
}
