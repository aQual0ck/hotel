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
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public AuxClasses.Users userObj;
        public PageMain(object user)
        {
            InitializeComponent();
            DataContext = user;

            frmRooms.Navigate(new PageRooms());
            frmClients.Navigate(new PageClients());
            frmRoomsClients.Navigate(new PageRoomsClients());

            var id = TypeDescriptor.GetProperties(DataContext)["Id"].GetValue(DataContext);
            userObj = AuxClasses.DBClass.entObj.Users.FirstOrDefault(x => x.Id == (int)id);

            if(userObj.RoleId == 1) 
            {
                TabItem tabAdmin = new TabItem()
                {
                    Header = "Пользователи"
                };
                Frame frmUsers = new Frame();
                frmUsers.Navigate(new PageUsers());
                tabAdmin.Content = frmUsers;
                tcMain.Items.Add(tabAdmin);
            }
        }

        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageLogin());
        }
    }
}
