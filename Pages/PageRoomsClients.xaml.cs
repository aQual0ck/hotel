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
    /// Логика взаимодействия для PageRoomsClients.xaml
    /// </summary>
    public partial class PageRoomsClients : Page
    {
        public PageRoomsClients()
        {
            InitializeComponent();
            dgrRoomsClients.ItemsSource = AuxClasses.DBClass.entObj.RoomsClients.ToList();
        }

        private void menuAdd_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageAddRoomsClients());
        }

        private void menuUpdate_Click(object sender, RoutedEventArgs e)
        {
            dgrRoomsClients.ItemsSource = AuxClasses.DBClass.entObj.RoomsClients.ToList();
        }
    }
}
