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
    /// Логика взаимодействия для PageAddClient.xaml
    /// </summary>
    public partial class PageAddClient : Page
    {
        public PageAddClient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.Clients client = new AuxClasses.Clients()
            {
                ClientName = txbName.Text
            };
            AuxClasses.DBClass.entObj.Clients.Add(client);
            AuxClasses.DBClass.entObj.SaveChanges();
            MessageBox.Show("Добавлено");
        }

        private void menuBack_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }
    }
}
