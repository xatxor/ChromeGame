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
    class AllAnimation
    {
        ThicknessAnimation animation = new ThicknessAnimation();

        public void StartAnimation(Image img, DependencyProperty property)
        {
            animation.From = new Thickness(-70, 260, 0, 0);
            animation.To = new Thickness(130, 260, 0, 0);
            img.BeginAnimation(property, animation);
        }

        public void JumpAnimation(Image img, DependencyProperty property)
        {
            animation.From = new Thickness(130, 260, 0, 0);
            animation.To = new Thickness(130, 150, 0, 0);
            animation.AutoReverse = true;
            animation.SpeedRatio = 3;
            animation.AccelerationRatio = 0.4;
            img.BeginAnimation(property, animation);
        }

        public void MoveAnimation(Image img, DependencyProperty property)
        {
            animation.From = new Thickness(39, 260, 0, 0);
            animation.To = new Thickness(39, 150, 0, 0);
            animation.AutoReverse = true;
            animation.SpeedRatio = 3;
            img.BeginAnimation(property, animation);
        }

        public void BarrierAnimation(Image img, DependencyProperty property)
        {
            animation.From = new Thickness(420, 0, -80, 89);
            animation.To = new Thickness(-300, 0, -80, 89);
            animation.AutoReverse = false;
            animation.SpeedRatio = 0.5;
            img.BeginAnimation(property, animation);
        }


    }
}
