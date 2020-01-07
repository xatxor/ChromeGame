using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Imaging;

namespace GameDuck
{
    class LoadAnything
    {
        public Image LoadImage()
        {
            Image img = new Image();
            img.Margin = new Thickness(420,0,-80,89);
            img.Height = 90;
            img.Width = 70;
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(@"C:\Users\kira\Documents\Game\ChromeGame\GameDuck\GameDuck\Resources\1.png");
            bitmap.EndInit();
            img.Source = bitmap;
            return img;
        }
    }
}
