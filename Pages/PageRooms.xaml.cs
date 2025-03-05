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
    /// Логика взаимодействия для PageRooms.xaml
    /// </summary>
    public partial class PageRooms : Page
    {
        public PageRooms()
        {
            InitializeComponent();
            dgrRooms.ItemsSource = AuxClasses.DBClass.entObj.Rooms.ToList();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void menuAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
