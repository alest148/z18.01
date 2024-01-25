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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace z18._01
{
    /// <summary>
    /// Логика взаимодействия для Oplati.xaml
    /// </summary>
    public partial class Oplati : Page
    {
        public Oplati()
        {
            InitializeComponent();
            myDataGrid.ItemsSource = baseEntities.GetContext().Students.ToList();

        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить ?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var CurrentHouse = myDataGrid.SelectedItem as Oplata;
                Rages.db.Oplatas.Remove(CurrentHouse);
                Rages.db.SaveChanges();

                myDataGrid.ItemsSource = Rages.db.Oplatas.ToList();
                MessageBox.Show("Запись удаленна");
            }
        }

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }
    }
}
