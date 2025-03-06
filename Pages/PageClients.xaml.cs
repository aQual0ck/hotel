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

namespace hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageClients.xaml
    /// </summary>
    public partial class PageClients : Page
    {
        public PageClients()
        {
            InitializeComponent();
            dgrClients.ItemsSource = AuxClasses.DBClass.entObj.Clients.ToList();

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
            AuxClasses.FrameClass.frmObj.Navigate(new PageEditClient(dgrClients.SelectedItem));
        }

        private void menuAdd_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageAddClient());
        }

        private void menuUpdate_Click(object sender, RoutedEventArgs e)
        {
            dgrClients.ItemsSource = AuxClasses.DBClass.entObj.Clients.ToList();
        }

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbSearch.Text != "Введите имя для поиска" && !string.IsNullOrEmpty(txbSearch.Text))
                dgrClients.ItemsSource = AuxClasses.DBClass.entObj.Clients.Where(x => x.ClientName.ToLower().Contains(txbSearch.Text.ToLower())).ToList();
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
