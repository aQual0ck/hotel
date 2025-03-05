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
using System.Windows.Threading;

namespace hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageRegister.xaml
    /// </summary>
    public partial class PageRegister : Page
    {
        public int incorrectCounter = 0;
        public AuxClasses.Users userObj;
        public PageRegister(object user)
        {
            InitializeComponent();
            DataContext = user;
            
            var id = TypeDescriptor.GetProperties(DataContext)["Id"].GetValue(DataContext);
            userObj = AuxClasses.DBClass.entObj.Users.FirstOrDefault(x => x.Id == (int)id);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if (psbCurrentPassword.Password != "" || psbNewPassword.Password != "" || psbNewPasswordConfirm.Password != "")
            {
                if (userObj.Password == psbCurrentPassword.Password && psbNewPassword.Password == psbNewPasswordConfirm.Password)
                {
                    userObj.Password = psbNewPassword.Password;
                    userObj.LastLoginDate = DateTime.Now;
                    AuxClasses.DBClass.entObj.SaveChanges();
                    MessageBox.Show("Пароль успешно изменен");
                    AuxClasses.FrameClass.frmObj.Navigate(new PageMain());
                }
                else
                {
                    if (incorrectCounter > 3)
                    {
                        userObj.IsBlocked = true;
                        AuxClasses.DBClass.entObj.SaveChanges();
                        AuxClasses.FrameClass.frmObj.Navigate(new PageBlocked());
                    }
                    else
                    {
                        tbWarning.Visibility = Visibility.Visible;
                        incorrectCounter++;
                    }
                }
            }
            else
            {
                tbNoText.Visibility = Visibility.Visible;
                var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
                timer.Start();
                timer.Tick += (sender1, args) =>
                {
                    timer.Stop();
                    tbNoText.Visibility = Visibility.Visible;
                };
            }
        }
    }
}
