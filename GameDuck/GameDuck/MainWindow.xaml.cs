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
        System.Timers.Timer timer = new System.Timers.Timer();
        System.Timers.Timer timer2 = new System.Timers.Timer();
        public MainWindow()
        {
            InitializeComponent();
            Animation.StartAnimation(DuckObject, MarginProperty);
            PlayMusic();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                timer.Enabled = true;
                timer.Interval = 1000;
                timer.Elapsed += Score;
                timer2.Enabled = true;
                timer2.Interval = 400;
                timer2.Elapsed += RandomMethod;
                timer.Start();
                timer2.Start();
            }

            if (e.Key == Key.Space)
            {
                OneDuck.jumping = true;
                Animation.JumpAnimation(DuckObject, MarginProperty);
            }
            
            if(e.Key == Key.R)
            {
                OneDuck.Life = false;
                timer.Stop();
                timer2.Stop();
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (OneDuck.jumping)
                OneDuck.jumping = false;
        }

        public void RandomMethod(Object source, System.Timers.ElapsedEventArgs e)
        {
                int ans = rnd.Next(1, 3);
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

        public void PlayMusic()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\Users\kira\Documents\Game\GameDuck\GameDuck\Resources\audio.wav";
            sp.Load();
            sp.PlayLooping();
        }

        public void Score(Object source, System.Timers.ElapsedEventArgs e)
        {
                int score = 0;
                ScoreLabel.Content = "Score: " + score;
                score++;
        }
        
    }
}
