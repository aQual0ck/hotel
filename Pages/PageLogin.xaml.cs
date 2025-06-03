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
using System.Runtime;

namespace hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private int attempts = 0;
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbUsername.Text != "" && psbPassword.Password != "")
                {
                    var userObj = AuxClasses.DBClass.entObj.Users.FirstOrDefault(x => x.Username == txbUsername.Text);
                    if (userObj == null)
                    {
                        tbWarning.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (userObj.Password == psbPassword.Password)
                        {
                            if (userObj.IsBlocked == true)
                            {
                                AuxClasses.FrameClass.frmObj.Navigate(new PageBlocked());
                            }
                            else
                            {
                                if (userObj.IsRegistered == true)
                                {
                                    TimeSpan? s = DateTime.Now - userObj.LastLoginDate;
                                    double days = s?.TotalDays ?? 0;
                                    if (days < 30)
                                    {
                                        userObj.LastLoginDate = DateTime.Now;
                                        AuxClasses.DBClass.entObj.SaveChanges();
                                        MessageBox.Show("Вы успешно авторизовались");
                                        AuxClasses.FrameClass.frmObj.Navigate(new PageMain(userObj));
                                    }
                                    else
                                    {
                                        userObj.IsBlocked = true;
                                        AuxClasses.DBClass.entObj.SaveChanges();
                                        AuxClasses.FrameClass.frmObj.Navigate(new PageBlocked());
                                    }
                                }
                                else
                                {
                                    AuxClasses.FrameClass.frmObj.Navigate(new PageRegister(userObj));
                                }
                            }
                        }
                        else
                        {
                            tbWarning.Visibility = Visibility.Visible;
                            attempts++;
                            if (attempts > 3)
                            {
                                userObj.IsBlocked = true;
                                AuxClasses.DBClass.entObj.SaveChanges();
                                AuxClasses.FrameClass.frmObj.Navigate(new PageBlocked());
                            }
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
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
