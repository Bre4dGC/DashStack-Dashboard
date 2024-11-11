using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace DashStack_Dashboard.Views.Styles.Components
{
    /// <summary>
    /// Логика взаимодействия для NavigationButton.xaml
    /// </summary>
    public partial class NavButton : UserControl
    {
        public NavButton()
        {
            InitializeComponent();
        }

        public PathGeometry Icon
        {
            get => (PathGeometry)GetValue(SvgPathProperty);
            set => SetValue(SvgPathProperty, value);
        }

        public static readonly DependencyProperty SvgPathProperty = 
            DependencyProperty.Register(nameof(Icon), typeof(PathGeometry), typeof(NavButton));


        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(NavButton) );
        
        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            HighlightX.BeginAnimation(TranslateTransform.XProperty,
               new DoubleAnimation
               {
                   To = 0,
                   Duration = TimeSpan.FromSeconds(0.15),
                   EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseInOut }
               });
        }

        private void Button_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            HighlightX.BeginAnimation(TranslateTransform.XProperty,
               new DoubleAnimation
               {
                   To = -5,
                   Duration = TimeSpan.FromSeconds(0.15),
                   EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseInOut }
               });
        }
    }
}
