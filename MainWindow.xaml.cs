using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VCPO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

       
       

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            double windowWidth = ActualWidth;
            double windowHeight = ActualHeight;
            double buttonWidth = close_btn.ActualWidth;
            double buttonHeight = close_btn.ActualHeight;

            // Генерация случайных координат с учетом размеров окна
            double xx = random.Next(0, (int)(windowWidth - buttonWidth));
            double yy = random.Next(0, (int)(windowHeight - buttonHeight));

            // Анимация по оси X
            DoubleAnimation animX = new DoubleAnimation();
            animX.To = xx;
            animX.Duration = TimeSpan.FromSeconds(0.5); // Длительность анимации в секундах

            // Анимация по оси Y
            DoubleAnimation animY = new DoubleAnimation();
            animY.To = yy;
            animY.Duration = TimeSpan.FromSeconds(0.5); // Длительность анимации в секундах

            // Запуск анимации для кнопки
            close_btn.BeginAnimation(Canvas.LeftProperty, animX);
            close_btn.BeginAnimation(Canvas.TopProperty, animY);

        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void task1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Close();
        }

        private void task2_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show(); 
            Close();
        }

        private void laba3_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            Close();
        }
    }
}