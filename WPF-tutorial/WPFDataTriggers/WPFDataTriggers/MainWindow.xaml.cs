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
using System.Collections.ObjectModel;


namespace WPFDataTriggers
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
    }
    public class user
    {
        public string Name { get; set; }
        public string Role { get; set; }
     }
    //ObservableCollection --Represents a dynamic data collection that provides notifications when items get added, removed, or when the whole list is refreshed.
    //To inherit the OC we need to add the namespace system.collection.objectmodel
    public class Users : ObservableCollection<user>
    {
      public Users()
      {
        this.Add(new user{Name="Susmitha", Role="Developer"});
            this.Add(new user{Name="Swathi" ,Role="Manager"});
                this.Add(new user{Name="Alekhya" ,Role="Tester"});
                    this.Add(new user{Name="Swati", Role="Admin"});
      }
      }
    }

