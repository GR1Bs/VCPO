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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VCPO
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
        }

        private void task_btn_Click(object sender, RoutedEventArgs e)
        {
            Variable(rez);
        }

        private void Variable(Func<double,double,double,double> eaqution)
        {
            try 
            {
             double x = double.Parse(variable_one.Text);
             double d = double.Parse(variable_two.Text);
             double c = double.Parse(variable_three.Text);

             double result = eaqution(x,d,c);
            
            MessageBox.Show(Convert.ToString(result)); 
            }
            catch  
            {
                MessageBox.Show("Возникла ошибка");
            }
                      
        }

        double rez(double x, double d, double c) {

            return (d + 2 * Math.Pow(c, -3)) / ((12 * Math.Cos(Math.Pow(x, -2))) + Math.Tan(d * x)) * Math.Log(x);
        
        }

        private void task2_batn_Click(object sender, RoutedEventArgs e)
        {
            Variable(rez2);
        }

        double rez2(double x, double d, double c) {

            return (1/5*x-Math.Pow(Math.Tan(d),2))+(Math.Sqrt(5*c*x)/Math.Pow(d,-4/3));
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
