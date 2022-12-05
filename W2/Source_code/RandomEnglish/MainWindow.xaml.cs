using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.RightsManagement;
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
    public partial class MainWindow : Window
    {

        List<English> english = new List<English>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            setupData();

            nextLabel();
        }

        private void helloButton_Click(object sender, RoutedEventArgs e)
        {
            nextLabel();
        }

        class English
        { 
            public string _images { get; set; }
            public string _labels { get; set; }

            public English()
            {
                _images = "";
                _labels = "";
            }
        }
        private void setupData()
        {
            string[] filename = { "data.txt", "NameImages.txt" };
            string[] linesVoc = File.ReadAllLines(filename[0]);
            string[] linesImg = File.ReadAllLines(filename[1]);

            for(int i = 1; i < linesVoc.Length; i++)
            {
                string label = linesVoc[i];
                string image = linesImg[i];

                var eng = new English() 
                { 
                    _labels = label, _images= image
                };
                english.Add(eng);
            }

        }
        private void nextLabel()
        {
            int i = new Random().Next(0, english.Count);
            string label = english[i]._labels;
            labelLabel.Content = label;

            var bitmap = new BitmapImage(new Uri(english[i]._images, UriKind.Relative));

            labelImage.Source = bitmap;
        }
    }
}
