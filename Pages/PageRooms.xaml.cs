using hotel.AuxClasses;
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
    /// Логика взаимодействия для PageRooms.xaml
    /// </summary>
    public partial class PageRooms : Page
    {
        public int catid = 0;
        public int statid = 0;
        public PageRooms()
        {
            InitializeComponent();
            dgrRooms.ItemsSource = AuxClasses.DBClass.entObj.Rooms.ToList();

            cmbCategory.DisplayMemberPath = "CategoryName";
            cmbCategory.SelectedValuePath = "CategoryName";
            var cat = AuxClasses.DBClass.entObj.Categories.ToList();
            cat.Insert(0, new Categories { Id = 0, CategoryName = "Все категории" });
            cmbCategory.ItemsSource = cat;
            cmbCategory.SelectedIndex = 0;

            cmbStatus.DisplayMemberPath = "StatusName";
            cmbStatus.SelectedValuePath = "StatusName";
            var stat = AuxClasses.DBClass.entObj.Statuses.ToList();
            stat.Insert(0, new Statuses { Id = 0, StatusName = "Все статусы" });
            cmbStatus.ItemsSource = stat;
            cmbStatus.SelectedIndex = 0;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageEditRoom(dgrRooms.SelectedItem));
        }

        private void menuAdd_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageAddRoom());
        }

        private void menuUpdate_Click(object sender, RoutedEventArgs e)
        {
            dgrRooms.ItemsSource = AuxClasses.DBClass.entObj.Rooms.ToList();
        }

        private void cmbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCategory.SelectedItem != null && cmbStatus.SelectedItem != null)
                ApplyFilters();
        }

        private void cmbStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbCategory.SelectedItem != null && cmbStatus.SelectedItem != null)
                ApplyFilters();
        }

        private void ApplyFilters()
        {
            catid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbCategory.SelectedItem)["Id"].GetValue(cmbCategory.SelectedItem));
            statid = Convert.ToInt32(TypeDescriptor.GetProperties(cmbStatus.SelectedItem)["Id"].GetValue(cmbStatus.SelectedItem));

            var query = DBClass.entObj.Rooms.AsQueryable();

            if (catid != 0)
                query = query.Where(x => x.CategoryId == catid);

            if (statid != 0)
                query = query.Where(x => x.StatusId == statid);

            dgrRooms.ItemsSource = query.ToList();
        }
    }
}
