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
    /// Логика взаимодействия для PageUsers.xaml
    /// </summary>
    public partial class PageUsers : Page
    {
        public PageUsers()
        {
            InitializeComponent();
            dgrUsers.ItemsSource = AuxClasses.DBClass.entObj.Users.ToList();

            cmbRole.DisplayMemberPath = "RoleName";
            cmbRole.SelectedValuePath = "RoleName";
            var roles = AuxClasses.DBClass.entObj.Roles.ToList();
            roles.Insert(0, new Roles { Id = 0, RoleName = "Все роли" });
            cmbRole.ItemsSource = roles;
            cmbRole.SelectedIndex = 0;

            if (string.IsNullOrEmpty(txbSearch.Text))
            {
                txbSearch.Text = "Введите имя для поиска";
                txbSearch.Foreground = Brushes.Gray;
                txbSearch.GotFocus += RemoveTextSearch;
                txbSearch.LostFocus += AddTextSearch;
            }
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageEditUser(dgrUsers.SelectedItem));
        }

        private void menuAdd_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageAddUser());
        }

        private void menuUpdate_Click(object sender, RoutedEventArgs e)
        {
            dgrUsers.ItemsSource = AuxClasses.DBClass.entObj.Users.ToList();
        }

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilters();
        }

        private void cmbRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbRole.SelectedItem != null)
                ApplyFilters();
        }

        private void rbAllRegistered_Checked(object sender, RoutedEventArgs e)
        {
            if (cmbRole.SelectedItem != null)
                ApplyFilters();
        }

        private void rbOnlyRegistered_Checked(object sender, RoutedEventArgs e)
        {
            ApplyFilters();
        }

        private void rbOnlyNotRegistered_Checked(object sender, RoutedEventArgs e)
        {
            ApplyFilters();
        }

        private void rbAllBlocked_Checked(object sender, RoutedEventArgs e)
        {
            if (cmbRole.SelectedItem != null)
                ApplyFilters();
        }

        private void rbOnlyBlocked_Checked(object sender, RoutedEventArgs e)
        {
            ApplyFilters();
        }

        private void rbOnlyNotBlocked_Checked(object sender, RoutedEventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            int rid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbRole.SelectedItem)["Id"].GetValue(cmbRole.SelectedItem));
            string searchText = txbSearch.Text.ToLower();

            var query = DBClass.entObj.Users.AsQueryable();

            if (txbSearch.Text != "Введите имя для поиска" && !string.IsNullOrEmpty(txbSearch.Text))
                query = query.Where(x => x.FullName.ToLower().Contains(searchText));

            if (rid != 0)
                query = query.Where(x => x.RoleId == rid);

            if (rbOnlyBlocked.IsChecked == true)
                query = query.Where(x => x.IsBlocked == true);

            if (rbOnlyNotBlocked.IsChecked == true)
                query = query.Where(x => x.IsBlocked == false);

            if (rbOnlyRegistered.IsChecked == true)
                query = query.Where(x => x.IsRegistered == true);

            if (rbOnlyNotRegistered.IsChecked == true)
                query = query.Where(x => x.IsRegistered == false);

            dgrUsers.ItemsSource = query.ToList();
        }

        private void RemoveTextSearch(object sender, EventArgs e)
        {
            if (txbSearch.Text == "Введите имя для поиска")
            {
                txbSearch.Text = "";
                txbSearch.Foreground = Brushes.Black;
            }
        }

        private void AddTextSearch(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbSearch.Text))
            {
                txbSearch.Text = "Введите имя для поиска";
                txbSearch.Foreground = Brushes.Gray;
            }
        }
    }
}
