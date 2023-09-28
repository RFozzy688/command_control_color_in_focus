using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace command_control_color_in_focus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void PaintControl(SolidColorBrush color)
        {
            var focusedControl = FocusManager.GetFocusedElement(this);

            var control = focusedControl as Control;

            if (control != null)
            {
                control.Background = color;
            }
        }
        private void RedCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PaintControl(Brushes.Red);
        }
        private void GreenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PaintControl(Brushes.Green);
        }
        private void BlueCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            PaintControl(Brushes.Blue);
        }
    }
    public class ColorCommands
    {
        public static RoutedCommand RedCommand { get; set; }
        public static RoutedCommand GreenCommand { get; set; }
        public static RoutedCommand BlueCommand { get; set; }
        static ColorCommands()
        {
            RedCommand = new RoutedCommand("RedCommand", typeof(ColorCommands));
            GreenCommand = new RoutedCommand("GreenCommand", typeof(ColorCommands));
            BlueCommand = new RoutedCommand("BlueCommand", typeof(ColorCommands));
        }
    }
}
