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
using hotel.AuxClasses;

namespace hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEditRoom.xaml
    /// </summary>
    public partial class PageEditRoom : Page
    {
        public AuxClasses.Rooms room;
        public AuxClasses.Categories cat;
        public AuxClasses.Statuses stat;
        public PageEditRoom(object r)
        {
            InitializeComponent();
            DataContext = r;

            var id = TypeDescriptor.GetProperties(DataContext)["Id"].GetValue(DataContext);
            room = AuxClasses.DBClass.entObj.Rooms.FirstOrDefault(x => x.Id == (int)id);

            var catid = TypeDescriptor.GetProperties(DataContext)["CategoryId"].GetValue(DataContext);
            cat = AuxClasses.DBClass.entObj.Categories.FirstOrDefault(x => x.Id == (int)catid);

            var statid = TypeDescriptor.GetProperties(DataContext)["StatusId"].GetValue(DataContext);
            stat = AuxClasses.DBClass.entObj.Statuses.FirstOrDefault(x => x.Id == (int)statid);

            cmbCategory.SelectedValuePath = "CategoryName";
            cmbCategory.DisplayMemberPath = "CategoryName";
            cmbCategory.ItemsSource = AuxClasses.DBClass.entObj.Categories.ToList();
            cmbCategory.SelectedValue = cat.CategoryName;

            cmbStatus.SelectedValuePath = "StatusName";
            cmbStatus.DisplayMemberPath = "StatusName";
            cmbStatus.ItemsSource = AuxClasses.DBClass.entObj.Statuses.ToList();
            cmbStatus.SelectedValue = stat.StatusName;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            int catid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbCategory.SelectionBoxItem)["Id"].GetValue(cmbCategory.SelectionBoxItem));
            int statid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbStatus.SelectionBoxItem)["Id"].GetValue(cmbStatus.SelectionBoxItem));

            room.RoomNumber = Convert.ToInt32(txbRoomNumber.Text);
            room.Floor = Convert.ToInt32(txbFloor.Text);
            room.CategoryId = catid;
            room.StatusId = statid;

            AuxClasses.DBClass.entObj.SaveChanges();
            MessageBox.Show("Сохранено");
        }

        private void menuBack_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }

        private void menuDel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Удаление комнаты", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                AuxClasses.DBClass.entObj.Rooms.Remove(room);
                AuxClasses.DBClass.entObj.SaveChanges();
                MessageBox.Show("Удалено");
                AuxClasses.FrameClass.frmObj.GoBack();
            }
        }
    }
}
