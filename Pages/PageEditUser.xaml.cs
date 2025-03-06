using hotel.AuxClasses;
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
    /// Логика взаимодействия для PageEditUser.xaml
    /// </summary>
    public partial class PageEditUser : Page
    {
        public AuxClasses.Users user;
        public AuxClasses.Roles role;
        public PageEditUser(object u)
        {
            InitializeComponent();
            DataContext = u;

            var id = TypeDescriptor.GetProperties(DataContext)["Id"].GetValue(DataContext);
            user = AuxClasses.DBClass.entObj.Users.FirstOrDefault(x => x.Id == (int)id);

            var rid = TypeDescriptor.GetProperties(DataContext)["RoleId"].GetValue(DataContext);
            role = AuxClasses.DBClass.entObj.Roles.FirstOrDefault(x => x.Id == (int)rid);

            cmbRole.DisplayMemberPath = "RoleName";
            cmbRole.SelectedValuePath = "RoleName";
            cmbRole.ItemsSource = AuxClasses.DBClass.entObj.Roles.ToList();
            cmbRole.SelectedValue = role.RoleName;
        }

        private void menuBack_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            int rid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbRole.SelectedItem)["Id"].GetValue(cmbRole.SelectedItem));

            user.Username = txbUsername.Text;
            user.Password = txbPassword.Text;
            user.FullName = txbFullName.Text;
            user.RoleId = rid;
            user.IsRegistered = (bool)cbIsRegistered.IsChecked;
            user.IsBlocked = (bool)cbIsBlocked.IsChecked;

            AuxClasses.DBClass.entObj.SaveChanges();
            MessageBox.Show("Сохранено");
        }

        private void menuDel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Удаление пользователя", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                AuxClasses.DBClass.entObj.Users.Remove(user);
                AuxClasses.DBClass.entObj.SaveChanges();
                MessageBox.Show("Удалено");
                AuxClasses.FrameClass.frmObj.GoBack();
            }
        }
    }
}
