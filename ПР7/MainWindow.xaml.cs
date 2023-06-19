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

namespace ПР7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = ComBox1.SelectedIndex;
            Object selectedItem = ComBox1.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                            "Index: " + selectedIndex.ToString());
        }

        private void ComBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = ComBox1.SelectedIndex;

            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush();
            myLinearGradientBrush.StartPoint = new Point(0, 0);
            myLinearGradientBrush.EndPoint = new Point(1, 1);
            myLinearGradientBrush.GradientStops.Add( new GradientStop(Colors.Yellow, 0.0));
            myLinearGradientBrush.GradientStops.Add(new GradientStop(Colors.Red, 0.25));
            myLinearGradientBrush.GradientStops.Add(new GradientStop(Colors.Blue, 0.75));
            myLinearGradientBrush.GradientStops.Add(new GradientStop(Colors.LimeGreen, 1.0));

            if (selectedIndex == 0)
            {
                textBox1.Background = Brushes.White; textBox2.Background = Brushes.White;
            }
            if (selectedIndex == 1)
            {
                textBox1.Background = Brushes.Cyan; textBox2.Background = Brushes.Cyan;
            }
            if (selectedIndex == 2)
            {
                textBox1.Background = myLinearGradientBrush; textBox2.Background = myLinearGradientBrush;
            }


        }
    }
}
