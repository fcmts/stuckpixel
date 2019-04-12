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
using System.Windows.Media.Animation;

namespace stuckpixel
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Color> colors = new List<Color>(new Color[] { Colors.Black, Colors.White, Colors.Red, Colors.Green, Colors.Blue, Colors.Magenta, Colors.Cyan, Colors.Yellow });
        int iColor=0;

        public MainWindow()
        {
            InitializeComponent();
            MyCanvas.SizeChanged += new SizeChangedEventHandler(MyCanvas_SizeChanged);
            this.Cursor = Cursors.None;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            double x=System.Windows.SystemParameters.PrimaryScreenHeight;
            double y=System.Windows.SystemParameters.PrimaryScreenWidth;

        }

        void MyCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Canvas.SetLeft(text01, (MyCanvas.ActualWidth - text01.ActualWidth) / 2);
            Canvas.SetTop(text01, (MyCanvas.ActualHeight - text01.ActualHeight) / 2);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState != WindowState.Maximized)
            {
                WindowState = WindowState.Maximized;
                WindowStyle = WindowStyle.None;
            }
            else
            {
                WindowState = WindowState.Normal;
                WindowStyle = WindowStyle.SingleBorderWindow;
           }
        }
        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            // This is the key down event linked to the canvas
            if (e.Key == Key.Down && Canvas.GetTop(rec1) + rec1.Height < MyCanvas.ActualHeight)
            {
                // in this if statement we are checking if the down key is pressed
                // AND the rec1 objects top plus the height is less than 420 pixels
                Canvas.SetTop(rec1, Canvas.GetTop(rec1) + 1);
                // if these conditions match then we move the object down 10 pixels
            }
            else if (e.Key == Key.Up && Canvas.GetTop(rec1) > 0)
            {
                // in this if statement we are checking if they up key is pressed
                // and rec1s top is greater than 10 pixels
                Canvas.SetTop(rec1, Canvas.GetTop(rec1) - 1);
                // if these conditions are met then we move the object up 10 pixels
            }
            else if (e.Key == Key.Left && Canvas.GetLeft(rec1) > 0)
            {
                // in this if statement we are checking if they left key is pressed
                // and rec1s left is greater than 0 pixels
                Canvas.SetLeft(rec1, Canvas.GetLeft(rec1) - 1);
                // if these conditions are met then we move the object left 10 pixels
            }
            else if (e.Key == Key.Right && Canvas.GetLeft(rec1) + rec1.Width < MyCanvas.ActualWidth)
            {
                // in this if statement we are checking if the right key is pressed
                // and rec1s right and rec1s width is less than 790 pixels
                Canvas.SetLeft(rec1, Canvas.GetLeft(rec1) + 1);
                // if these conditions are met then we move the object 10 pixels to the right
            }
            else if (e.Key == Key.C)
            {
                text01.Text = (Canvas.GetLeft(rec1) + 1).ToString() + "," + (Canvas.GetTop(rec1) + 1).ToString();
            }
            else if (e.Key == Key.Space)
            {
                ColorAnimation animation;
                animation = new ColorAnimation();
                animation.From = colors[iColor];
                MyCanvas.Background = new SolidColorBrush(colors[iColor]);
                text01.Background = new SolidColorBrush(colors[iColor]);
                if (++iColor > colors.Count() - 1)
                    iColor = 0;
                animation.To = colors[iColor];
                animation.Duration = new Duration(TimeSpan.FromSeconds(0.1));
                MyCanvas.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                text01.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
            }
            /*
            if (e.IsRepeat)
            {
                text01.Text = (Canvas.GetLeft(rec1) + 1).ToString() + "," + (Canvas.GetTop(rec1) + 1).ToString();
            }
            */
        }
    }
}
