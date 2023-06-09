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

namespace ПР4
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



        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа создана для учебной практики");
        }

        private void Mi_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Mi_colorRandom_Click(object sender, RoutedEventArgs e)
        {
            menu.Background = new SolidColorBrush(Colors.Coral);
            status.Background = new SolidColorBrush(Colors.Coral);
            tool.Background = new SolidColorBrush(Colors.Coral);


        }

        private void SlColorB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
            this.Background = new SolidColorBrush(color);

            

            inkCanvas1.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.Strokes.Clear();
        }


    }
}
