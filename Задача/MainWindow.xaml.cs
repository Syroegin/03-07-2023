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

namespace syroegin
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
        private void Go_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(number.Text);
            if (a==1)
            {
                MessageBox.Show("1) Физическая культура\n2) Русский язык\n3) Математика\n4) Физика", "Понедельник");  
            }
            if (a == 2)
            {
                MessageBox.Show("1) Иностранный язык\n2) Русский язык\n3) История\n4) Геометрия\n5) Алгебра", "Вторник");
            }
            if (a == 3)
            {
                MessageBox.Show("1) Химия\n2) Физическая культура\n3) Биология\n4) Обществознание", "Среда");
            }
            if (a == 4)
            {
                MessageBox.Show("1) Труд\n2) Русский язык\n3) Русский язык\n4) Изо\n5)Музыка", "Четверг");
            }
            if (a == 5)
            {
                MessageBox.Show("1) Физическая культура\n2) Математика\n3) Математика\n4) Физика\n5)История", "Пятница");
            }
            if (a == 6)
            {
                MessageBox.Show("Отдых", "Суббота");
            }
            if (a == 7)
            {
                MessageBox.Show("Завтра на учебу", "Воскресенье");
            }
        }
    }
}
