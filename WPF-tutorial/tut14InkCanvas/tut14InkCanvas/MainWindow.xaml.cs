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

namespace tut14InkCanvas
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
        private void rectred_MouseDown(object sender, RoutedEventArgs e)
        {
             inkcanvas1.DefaultDrawingAttributes.Color = System.Windows.Media.Colors.Red;
        }
        private void rectBlue_MouseDown(object sender, RoutedEventArgs e)
        {
            inkcanvas1.DefaultDrawingAttributes.Color = System.Windows.Media.Colors.Blue;
        }
        private void rectGreen_MouseDown(object sender, RoutedEventArgs e)
        {
            inkcanvas1.DefaultDrawingAttributes.Color = System.Windows.Media.Colors.Green;
        }
        private void rectYellow_MouseDown(object sender, RoutedEventArgs e)
        {
            inkcanvas1.DefaultDrawingAttributes.Color = System.Windows.Media.Colors.Yellow;
        }
        private void btnselect_Click(object sender, RoutedEventArgs e)
        {
            inkcanvas1.EditingMode = InkCanvasEditingMode.Select;
        }
        private void btndraw_click(object sender, RoutedEventArgs e)
        {
            inkcanvas1.EditingMode = InkCanvasEditingMode.InkAndGesture;
        }
        private void btnerase_click(object sender, RoutedEventArgs e)
        {
            inkcanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
    }
}
