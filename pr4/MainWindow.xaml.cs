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

namespace pr4
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
        private void Rez_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Преобразуем текст в числа
                int a = int.Parse(TxtA.Text);
                int b = int.Parse(TxtB.Text);
                int c = int.Parse(TxtC.Text);
                int d = int.Parse(TxtD.Text);
                
                // Проверяем на четность ююю
                if (a % 2 != 0 || b % 2 != 0 || c % 2 != 0 || d % 2 != 0)
                {
                    MessageBox.Show("Все числа должны быть четными!");
                    return;
                }
                // Создаем пары
                Pair p1 = new Pair(a, b);
                Pair p2 = new Pair(c, d);
                // Считаем произведения
                int prod1 = p1.Product();
                Pair p3 = Pair.Product(p1, p2);
                // Выводим результат
                TxtOutput.Text =
                    "Пара 1: " + p1.Show() + "\n" +
                    "Пара 2: " + p2.Show() + "\n" +
                    "Произведение первой пары: " + prod1 + "\n" +
                    "Произведение двух пар: " + p3.Show();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работа №4\n" +
                            "Задание: Создать класс Pair (пара четных чисел). " +
                            "Создать методы и свойства. Определить метод вычисления произведения чисел. " +
                            "Создать перегруженный метод для вычисления произведения двух пар (a, b)*(c, d)=(a*c, b*d).",
                            "О программе");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}