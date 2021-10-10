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

namespace Exercise1
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
        private bool buttonWasClicked = false;
        private bool button1WasClicked = false;
        public int[] array = new int[10];

        private void button_Click(object sender, RoutedEventArgs e)
        {
            buttonWasClicked = true;
            if (buttonWasClicked) {
                textBox.Clear();
                var rand = new Random();
                for (int i = 0; i < array.Length; i++)
                    array[i] = rand.Next(0, 100); //заполнение массива случайными числами от 0 до 100
                foreach (int a in array) //цикл для обхода всего массива и вывода его элементов
                    textBox.Text += " " + a;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1WasClicked = true;
            if (button1WasClicked) {
                textBox1.Clear();
                int tmp = 0; //переменная для временного хранения значений
                for (int i = 0; i < array.Length / 2; ++i) //перестановка элементов массива
                {
                    tmp = array[i];
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = tmp;
                }
                foreach (int b in array) //цикл для обхода всего массива и вывода его элементов
                    textBox1.Text += " " + b;
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
