using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tut2Mediaplayer
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

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.AddExtension =true;
            ofd.DefaultExt= "*.*";
            ofd.Filter="media(*.*)|*.*";
            ofd.ShowDialog();
            mediaElement1.Source=new Uri(ofd.FileName);

            //If you want any file name to be displayed during loading the video you can create event  and call this event in created label
            mediaElement1.MediaOpened+=new RoutedEventHandler(mediaElement1_MediaOpened);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Play();


        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Stop();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.Pause();
        }
         
        void mediaElement1_MediaOpened(object sender,RoutedEventArgs e)
        {
            label1.Content = mediaElement1.Source.ToString();
            
        }

    }
}
