using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Custom_WindowBorder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const int wm_mousedown=0xa1;
        public const int caption=0x2;
        //[dllimportattribute("user32.dll")]



        public MainWindow()
        {
            InitializeComponent();
        }

        private void window_loaded(object sender, RoutedEventArgs e)
        {

        }
        private void btnmin_click(object sender, RoutedEventArgs e)
        {

        }
        private void btnmax_click(object sender,RoutedEventArgs e)
        {
        }
        private void btnclose_click(object sender, RoutedEventArgs e)
        {
        }
    

    }
}
