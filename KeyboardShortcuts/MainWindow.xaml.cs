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

namespace KeyboardShortcuts
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

        private void RunTest(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test!");
        }
    }

    public static class Command
    {

        public static readonly RoutedUICommand DoSomething = new RoutedUICommand("Do something", "DoSomething", typeof(MainWindow));

    }
}
