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
using System.ComponentModel;

namespace hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddRoom.xaml
    /// </summary>
    public partial class PageAddRoom : Page
    {
        public PageAddRoom()
        {
            InitializeComponent();

            cmbCategory.SelectedValuePath = "CategoryName";
            cmbCategory.DisplayMemberPath = "CategoryName";
            cmbCategory.ItemsSource = AuxClasses.DBClass.entObj.Categories.ToList();

            cmbStatus.SelectedValuePath = "StatusName";
            cmbStatus.DisplayMemberPath = "StatusName";
            cmbStatus.ItemsSource = AuxClasses.DBClass.entObj.Statuses.ToList();
        }

        private void menuBack_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int catid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbCategory.SelectionBoxItem)["Id"].GetValue(cmbCategory.SelectionBoxItem));
            int statid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbStatus.SelectionBoxItem)["Id"].GetValue(cmbStatus.SelectionBoxItem));

            AuxClasses.Rooms room = new AuxClasses.Rooms()
            {
                RoomNumber = Convert.ToInt32(txbRoomNumber.Text),
                Floor = Convert.ToInt32(txbFloor.Text),
                CategoryId = catid,
                StatusId = statid
            };

            AuxClasses.DBClass.entObj.Rooms.Add(room);
            AuxClasses.DBClass.entObj.SaveChanges();
            MessageBox.Show("Добавлено");
        }
    }
}
