using DashStack_Dashboard.Views.Pages.Window;
using System.Windows;
using System.Windows.Input;

namespace DashStack_Dashboard.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Window.Content = new Main();
        }

        private void mouse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                DragMove();
            }

            if(e.ClickCount == 2)
            {
                WindowState = WindowState.Minimized;
            }
        }
    }
}