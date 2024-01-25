using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace z18._01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btSanatoriy_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new sanatoriy();

        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new stud();
        }

        private void btOplati_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new Oplati();

        }
        private void Otchet_Click(object sender, RoutedEventArgs e)
        {

        }
        private void dob1_Click(object sender, RoutedEventArgs e)
        {
            dobStudent mainWindow = new dobStudent();
            mainWindow.Show();

        }
        private void dob2_Click(object sender, RoutedEventArgs e)
        {
            dobFac mainWindow = new dobFac();
            mainWindow.Show();
        }
        private void dob3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void dob4_Click(object sender, RoutedEventArgs e)
        {

            
                dobPeriod mainWindow = new dobPeriod();
                mainWindow.Show();
            }
        private void dob5_Click(object sender, RoutedEventArgs e)
        {
            dobFac mainWindow = new dobFac();
            mainWindow.Show();
        }
        private void dob6_Click(object sender, RoutedEventArgs e)
        {
            dobGroup mainWindow = new dobGroup();
            mainWindow.Show();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
