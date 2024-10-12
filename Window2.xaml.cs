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

namespace VCPO
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private double[] a;
        private int[] b;
        private double[] c;

        public Window2()
        {
            InitializeComponent();
        }



        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n1 = int.Parse(inputN1.Text);
                int n2 = int.Parse(inputN2.Text);
                int n3 = int.Parse(inputN3.Text);

                if (n1!=n2 || n1!=n3 || n2!=n3)
                {
                    // Генерация и заполнение массивов
                    GenerateA(n1);
                    GenerateB(n2);
                    GenerateC(n3);

                    // Привязка массивов к DataGrid
                    dataGridA.ItemsSource = a.Select(x => new {  Массив_n1 = x }).ToList();
                  
                    dataGridB.ItemsSource = b.Select(x => new {  Массив_n2 = x }).ToList();
                    dataGridC.ItemsSource = c.Select(x => new {  Массив_n3 = Math.Round(x, 4) }).ToList();

                  

                }
                else
                {
                    MessageBox.Show("Размеры массива должны быть разные");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        // Заполнение массива a
        private void GenerateA(int n1)
        {
           ;
            double lower_bound = -2.0;
            double upper_bound = 4.0;
            double step = 0.3;
            a = new double[n1];

            int i = 0;
            for (double x = lower_bound; x <= upper_bound && i < n1; x += step, ++i)
            {
                try
                {
                    a[i] = Math.Log(1 / x + 1);

                    if (double.IsNaN(a[i]))
                    {
                        a[i] = 0;
                    }
                }
                catch 
                {
                    a[i] = 0;
                }
            }
        }

        // Заполнение массива b случайными числами
        private void GenerateB(int n2)
        {
            Random rand = new Random();
            b = new int[n2];
            for (int i = 0; i < n2; ++i)
            {
                b[i] = rand.Next(-100, 110);
            }
        }

        // Заполнение массива c с обработкой исключений
        private void GenerateC(int n3)
        {
            c = new double[n3];
            for (int i = 0; i < n3; ++i)
            {
                try
                {
                    if (i == 0 || b[i - 1] == 0) { 
                        throw new DivideByZeroException();
                    }

                    if (double.IsNaN(a[i]))
                    {
                        a[i] = 0;
                    }
                    c[i] = a[i] / b[i + 1];

                }
                catch
                {
                    c[i] = 0;
                }
            }
        }
    }
}

    

