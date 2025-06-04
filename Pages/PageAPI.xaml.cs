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
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;

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

        private static readonly Regex _regex = new Regex(@"[\+@]");
        private const string path = "D:\\test\\ТестКейс.docx";
        //+:=@&?|;^/(*!)\#%
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "http://localhost:4444/TransferSimulator/fullName";

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_regex.IsMatch(txbResult.Text))
            {
                txbCheck.Text = "ФИО содержит запрещенные символы";
            }
            else
            {
                txbCheck.Text = "ФИО не содержит запрещенные символы";
                SaveResult(txbCheck.Text);
            }
        }

        private int _currentTest = 1;
        private void SaveResult(string result)
        {
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show($"Файл шаблона не найден:\n{path}", "Ошибка",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                using (WordprocessingDocument doc = WordprocessingDocument.Open(path, true))
                {
                    string bookmarkName = _currentTest == 1 ? "Test1" : "Test2";

                    BookmarkStart bookmark = doc.MainDocumentPart.Document.Body
                        .Descendants<BookmarkStart>()
                        .FirstOrDefault(b => b.Name == bookmarkName);

                    if (bookmark != null)
                    {
                        OpenXmlElement parent = bookmark.Parent;
                        Run newRun = new Run(new Text(result));
                        parent.InsertAfter(newRun, bookmark);

                        _currentTest = _currentTest == 1 ? 2 : 1;

                        MessageBox.Show($"Результат '{result}' сохранен в закладку '{bookmarkName}'!", "Успех",
                                        MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Закладка '{bookmarkName}' не найдена в документе!", "Ошибка",
                                        MessageBoxButton.OK, MessageBoxImage.Error);
                    }
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
