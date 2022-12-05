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

namespace RandomEnglish
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> _images;
        List<string> _labels;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            setupData();

            nextLabel();
        }

        private void setupData()
        {
            _labels = new List<string>{
            "map(n) /mæp/: Bản đồ",
            "people(n) /ˈpiːpəl/: Người",
            "television(n) /teləˌvɪʒən/: Tivi",
            "paper(n) /ˈpeɪpər/: Giấy",
            "news(n) /nuːz/: Tin tức",
            "teacher(n) /ˈtiːʧər/: Giáo viên",
            "chemistry(n) /ˈkemɪstriː/: Hóa học",
            "success(n) /səkˈses/: Sự thành công",
            "wood(n) /wʊd/: Gỗ",
            "lake(n) /leɪk/: Hồ",
            };

            _images = new List<string>
            {
                "/Images/map.jpg",
                "/Images/people.jpg",
                "/Images/television.jpg",
                "/Images/paper.jpg",
                "/Images/news.jpg",
                "/Images/teacher.jpg",
                "/Images/chemistry.jpg",
                "/Images/success.jpg",
                "/Images/wood.jpg",
                "/Images/lake.jpg",
            };
        }

        private void helloButton_Click(object sender, RoutedEventArgs e)
        {
            nextLabel();
        }
        private void nextLabel()
        {
            int i = new Random().Next(0, _labels.Count);
            string label = _labels[i];
            labelLabel.Content = label;

            var bitmap = new BitmapImage(new Uri(_images[i], UriKind.Relative));

            labelImage.Source = bitmap;
        }
    }
}
