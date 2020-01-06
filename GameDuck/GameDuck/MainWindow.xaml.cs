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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameDuck
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Duck OneDuck = new Duck();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            var animation = new ThicknessAnimation();
            animation.From = new Thickness(39, 260, 0, 0);
            animation.To = new Thickness(39, 150, 0, 0);
            animation.AutoReverse = true;
            animation.SpeedRatio = 3;
            if (e.Key == Key.Space)
            {
                OneDuck.jumping = true;
                DuckObject.BeginAnimation(MarginProperty, animation);
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (OneDuck.jumping)
                OneDuck.jumping = false;
        }
    }
}
