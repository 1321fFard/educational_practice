using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace LightingApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var gradientAnimation = new PointAnimation
            {
                From = new Point(0.3, -0.3),
                To = new Point(0, 1.5),
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

                        var brush = (RadialGradientBrush)ball.Fill;
            brush.BeginAnimation(RadialGradientBrush.GradientOriginProperty,
gradientAnimation);
        }
    }
}