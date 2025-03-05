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
    /// Логика взаимодействия для PageEditClient.xaml
    /// </summary>
    public partial class PageEditClient : Page
    {
        public AuxClasses.Clients client;
        public PageEditClient(object c)
        {
            InitializeComponent();
            DataContext = c;
            
            var id = TypeDescriptor.GetProperties(DataContext)["Id"].GetValue(DataContext);
            client = AuxClasses.DBClass.entObj.Clients.FirstOrDefault(x => x.Id == (int)id);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            client.ClientName = txbName.Text;
            AuxClasses.DBClass.entObj.SaveChanges();
            MessageBox.Show("Сохранено");
        }

        private void menuBack_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }
    }
}
