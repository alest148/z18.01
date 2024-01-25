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
using System.Windows.Shapes;

namespace z18._01
{
    /// <summary>
    /// Логика взаимодействия для dobGroup.xaml
    /// </summary>
    public partial class dobGroup : Window
    {
        public dobGroup()
        {
            InitializeComponent();
            cb.ItemsSource = baseEntities.GetContext().Students.ToList();

        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void tbFac_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
