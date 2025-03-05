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
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageEditClient(dgrClients.SelectedItem));
        }

        private void menuAdd_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageAddClient());
        }
    }
}
