using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
//using System.Threading;
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
using System.Timers;

namespace GameDuck
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Duck OneDuck = new Duck();
        AllAnimation Animation = new AllAnimation();
        Random rnd = new Random();
        LoadAnything Load = new LoadAnything();
        int score = 0;
        Grid gridd = new Grid();
        public MainWindow()
        {
            InitializeComponent();
            Animation.StartAnimation(DuckObject, MarginProperty);
            //PlayMusic();
        }

        async private void Window_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                while (OneDuck.Life)
                {
                    await Task.Delay(1000);
                    gridd.Children.Add(Load.LoadImage());
                    BarrierLoadMethod();
                    Score();
                }
            }

            if (e.Key == Key.Space)
            {
                OneDuck.jumping = true;
                Animation.JumpAnimation(DuckObject, MarginProperty);
            }
            
            if(e.Key == Key.R)
            {
                OneDuck.Life = false;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (OneDuck.jumping)
                OneDuck.jumping = false;
        }

        public void RandomMethod()
        {
            int ans = rnd.Next(1, 4);
            if (ans == 1)
            {
                Animation.BarrierAnimation(Barrier1, MarginProperty);
            }
            else if (ans == 2)
            {
                Animation.BarrierAnimation(Barrier2, MarginProperty);
            }
            else if (ans == 3)
            {
                Animation.BarrierAnimation(Barrier3, MarginProperty);
            }
        }

        public void BarrierLoadMethod()
        {
            Animation.BarrierAnimation(Load.LoadImage(), MarginProperty);
        }

        public void PlayMusic()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\kira\Documents\Game\ChromeGame\GameDuck\GameDuck\Resources\audio.wav";
            sp.Load();
            sp.PlayLooping();
        }

        public void Score()
        {
                ScoreLabel.Content = "Score: " + score;
                score++;
        }
        
    }
}
