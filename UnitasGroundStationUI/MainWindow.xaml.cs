
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UnitasGroundStationUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Location location = new Location();
        public MainWindow()
        {
            InitializeComponent();         
        }

        private void btnPointClick(object sender, RoutedEventArgs e)
        {
            // Monument Circle point = 39.768403, -86.158068

            var origin = new Pushpin();
            origin.Location = new Location(Convert.ToDouble(tbxLatitude.Text), Convert.ToDouble(tbxAttitude.Text));
            MapControl.Children.Add(origin);
            MapControl.SetView(origin.Location, 10);
            tbxAttitude.Text = origin.Location.Longitude.ToString();
            tbxLatitude.Text = origin.Location.Latitude.ToString();

        }
    }
}
