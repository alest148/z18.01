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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace z18._01
{
    /// <summary>
    /// Логика взаимодействия для dobFac.xaml
    /// </summary>
    public partial class dobFac : Window
    {
        public dobFac()
        {
            InitializeComponent();
        }

        private void tbFac_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            Faculty reges = new Faculty();
            reges.name_faculty = tbFac.Text;


            Rages.db.Faculties.Add(reges);
            Rages.db.SaveChanges();
            MessageBox.Show("Добавлено в базу");
        }
    }
}
