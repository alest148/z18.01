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
    /// Логика взаимодействия для dobPeriod.xaml
    /// </summary>
    public partial class dobPeriod : Window
    {
        public dobPeriod()
        {
            InitializeComponent();
        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            Period reges = new Period();
            reges.nazvanie_period = tb.Text;
            reges.nachalo_per = date1.SelectedDate;
            reges.konec_per = date2.SelectedDate;



            Rages.db.Periods.Add(reges);
            Rages.db.SaveChanges();
            MessageBox.Show("Добавлено в базу"); ;
        }
    }
}
