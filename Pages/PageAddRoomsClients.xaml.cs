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
    /// Логика взаимодействия для PageAddRoomsClients.xaml
    /// </summary>
    public partial class PageAddRoomsClients : Page
    {
        public PageAddRoomsClients()
        {
            InitializeComponent();

            cmbRoom.SelectedValuePath = "RoomNumber";
            cmbRoom.DisplayMemberPath = "RoomNumber";
            cmbRoom.ItemsSource = AuxClasses.DBClass.entObj.Rooms.ToList();

            cmbClient.SelectedValuePath = "ClientName";
            cmbClient.DisplayMemberPath = "ClientName";
            cmbClient.ItemsSource = AuxClasses.DBClass.entObj.Clients.ToList();
        }

        private void cmbRoom_TextChanged(object sender, TextChangedEventArgs e)
        {
            cmbRoom.IsDropDownOpen = true;
            cmbRoom.ItemsSource = AuxClasses.DBClass.entObj.Rooms.Where(r => r.RoomNumber.ToString().StartsWith(cmbRoom.Text)).ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int clid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbClient.SelectedItem)["Id"].GetValue(cmbClient.SelectedItem));
            int rid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbRoom.SelectedItem)["Id"].GetValue(cmbRoom.SelectedItem));

            AuxClasses.RoomsClients rc = new AuxClasses.RoomsClients()
            {
                ClientId = clid,
                RoomId = rid,
                MoveInDate = dpMoveIn.SelectedDate,
                MoveOutDate = dpMoveOut.SelectedDate
            };

            AuxClasses.DBClass.entObj.RoomsClients.Add(rc);
            AuxClasses.DBClass.entObj.SaveChanges();
            MessageBox.Show("Добавлено");
        }

        private void cmbClient_TextChanged(object sender, TextChangedEventArgs e)
        {
            cmbClient.IsDropDownOpen = true;
            cmbClient.ItemsSource = AuxClasses.DBClass.entObj.Clients.Where(c => c.ClientName.ToLower().Contains(cmbClient.Text.ToLower())).ToList();
        }

        private void menuBack_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }
    }
}
