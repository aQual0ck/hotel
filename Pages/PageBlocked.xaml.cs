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
using System.Windows.Threading;

namespace hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageBlocked.xaml
    /// </summary>
    public partial class PageBlocked : Page
    {
        public PageBlocked()
        {
            InitializeComponent();
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
            timer.Start();
            timer.Tick += (sender1, args) =>
            {
                timer.Stop();
                AuxClasses.FrameClass.frmObj.Navigate(new PageLogin());
            };
        }
    }
}
