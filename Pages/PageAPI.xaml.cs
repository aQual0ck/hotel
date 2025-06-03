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
using System.Net.Http;
using Newtonsoft.Json;

namespace hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAPI.xaml
    /// </summary>
    public partial class PageAPI : Page
    {
        public PageAPI()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "http://prb.sylas.ru/TransferSimulator/fullName";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    var template = new
                    {
                        value = ""
                    };
                    var get = JsonConvert.DeserializeAnonymousType(json, template);

                    txbResult.Text = get.value;
                }
                catch (Exception ex)
                {
                    txbResult.Text = ex.Message;
                }
            }
        }
    }
}
