using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab8
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["myDrush"] = new SolidColorBrush(Colors.Aquamarine);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var path = Environment.CurrentDirectory + @"\Dictionary1.xaml";

            using var stream = new FileStream(path, FileMode.Open);

            var content = XamlReader.Load(stream);

            this.Resources.MergedDictionaries.Add((ResourceDictionary)content);
        }
    }
}
