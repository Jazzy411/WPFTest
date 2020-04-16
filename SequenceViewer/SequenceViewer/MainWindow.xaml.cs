using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;

namespace SequenceViewer
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
            List<Person> l_dataTest = new List<Person>();
            l_dataTest.Add(new Person("Zhang San","23"));
            l_dataTest.Add(new Person("Li Si", "25"));
            l_dataTest.Add(new Person("唐冬梅", "96"));

            lv_data.ItemsSource = l_dataTest;
        }
    }
}
