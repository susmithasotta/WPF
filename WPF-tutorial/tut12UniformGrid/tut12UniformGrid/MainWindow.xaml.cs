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

namespace tut12UniformGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            checkerBoard.Rows = 7;
            checkerBoard.Columns = 7;
            for (int i = 0; i <= 24; i++)
            {
                checkerBoard.Children.Add(new Rectangle { Fill = Brushes.Black });
                checkerBoard.Children.Add(new Rectangle { Fill = Brushes.Red });
            }
        }
    }
}