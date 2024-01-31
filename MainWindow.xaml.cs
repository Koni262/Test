using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace Test
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

        private void myImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            myImage.Source = new BitmapImage(
                new Uri("/Test;component/Images/niggawaat.jpg", UriKind.Relative));
        }
    }

/*    class Person
    {
        public string Name { get; set;}

        [EmailAddress]
        public string Email { get; set;}

        [DataType(DataType.Password)]
        public string Password { get; set;}

        [Compare("Password")]
        public string ConfrimPassword { get; set;}

        [JsonIgnore]
        public string Token { get; set;}

        [JsonIgnore]
        public string RefreshToken { get; set;}
    }*/

}
