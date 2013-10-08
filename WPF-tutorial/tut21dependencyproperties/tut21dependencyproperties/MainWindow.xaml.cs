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

namespace tut21dependencyproperties
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

       //All dp are to be registered...and last parameter of dp register function is by default false or 0,if it is true
        //passed with propertychange function name is passed as paramter...and it is enabled
        //all functions related to dp are static(in C#) and shared in VB

        public string NumberValue
        {
            get { return (string)GetValue(NumberValueProperty);}
            set { SetValue(NumberValueProperty,value);}
        
        }
//name of the property,type of property,name of the class as owner and metadata(0 or 1)
        public static readonly DependencyProperty NumberValueProperty = DependencyProperty.Register("NumberValue", typeof(string), typeof(MainWindow), new FrameworkPropertyMetadata("0"), new ValidateValueCallback(IsValidNumber));
         //To validate the entered number write a private function

        private static bool IsValidNumber(object value)
        {

            return IsNumeric(value);

        }

        private static bool IsNumeric(object value)
        {
            throw new NotImplementedException();
        }

        private void ChkForceInteger_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private static string CoercetoInteger(DependencyObject d,object value)
        {
            if(tryparse(value.ToString)!=null)
            { 
                return Math.Ceiling(c(value,decimal)).ToString;
                
            }
        }

        public Boolean ForceInteger
        {
            get { return this.GetValue(ForceIntegerProperty) as Boolean; }
            set { SetValue(ForceIntegerProperty, (bool)value); }

        }
        //name of the property,type of property,name of the class as owner and metadata(0 or 1)
        public static readonly DependencyProperty ForceIntegerProperty = DependencyProperty.Register("ForceInteger", typeof(Boolean), typeof(MainWindow), new FrameworkPropertyMetadata(false), new ValidateValueCallback(IsValidNumber));
        //To validate the entered number write a private function
    }
}
