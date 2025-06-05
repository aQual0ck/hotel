using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.IO;
using Newtonsoft.Json.Linq;
using Microsoft.Office.Interop.Word;
using Page = System.Windows.Controls.Page;
using Application = Microsoft.Office.Interop.Word.Application;

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
            string url = "http://localhost:4444/TransferSimulator/fullName";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(url);
                    if (response != null)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        
                        JObject obj = JObject.Parse(data);
                        txbResult.Text = obj["value"].ToString();
                    }
                    else
                    {
                        txbResult.Text = $"Ошибка {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    txbResult.Text = ex.Message;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string data = txbResult.Text;

            if (data.Contains('/'))
            {
                txbCheck.Text = "Данные содержат запрещенный символ /";
                SaveResult("Не успешно", 2);
                SaveResult("Успешно", 1);
            }
            else if (data.Contains('*'))
            {
                txbCheck.Text = "Данные содержат запрещенный символ *";
                SaveResult("Не успешно", 1);
                SaveResult("Успешно", 2);
            }
        }

        private const string path = "D:\\test\\ТестКейс.docx";
        private void SaveResult(string result, int testNumber)
        {
            string bookmarkName = $"test{testNumber}";
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show($"Файл шаблона не найден:\n{path}", "Ошибка",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                Application word = new Application();
                Document doc = null;

                try
                {
                    doc = word.Documents.Open(path);
                    var bookmark = doc.Bookmarks[bookmarkName];
                    bookmark.Range.Text = result;
                    doc.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка {ex.Message}");
                }
                finally
                {
                    if (doc != null)
                        doc.Close();
                    word.Quit();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
