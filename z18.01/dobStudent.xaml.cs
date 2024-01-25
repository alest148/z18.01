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
    /// Логика взаимодействия для dobStudent.xaml
    /// </summary>
    public partial class dobStudent : Window
    {
        public dobStudent()
        {
            InitializeComponent();
            bind();
        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {
            Student reges = new Student();
            reges.FIO = tbObraz.Text;
            reges.data_birth = data.SelectedDate;
            reges.Obrazovanie = tbAdres.Text; 
            reges.Telephone =Convert.ToInt32( tbPhone.Text);
            reges.NBileta = Convert.ToInt32(tbNum.Text);
            reges.other_info = tbDop.Text;





        }


        public List<Student> Stud { get; set; }

        private void bind()
        {
            baseEntities db = new baseEntities();
            var item = db.Students.ToList();
            Stud = item;
            DataContext = Stud;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
