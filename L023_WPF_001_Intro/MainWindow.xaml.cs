using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace L023_WPF_001_Intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    //partial = You can write parts of the class in one file, and parts of the class in the other, but they will still be one class.
    //WPF uses this. MainWindow for example is partly generated from xaml file and in part from the .cs code.
    public partial class MainWindow : Window
    {
        private int counter = 1;
        //MainWindow is a class for the code behind. It calls the method InitializaComponent()
        public MainWindow()
        {

            InitializeComponent();
            // You can do the same things that you do in xaml directly in code behind.
            // Button button = new Button() { Content = "MyButton" }; => Creates a button

            // myButton.Content = "Hello";

            //var stackpanel = new StackPanel();
            //stackpanel.Children.Add(new Button());
            //stackpanel.Children.Add(new Label());
        }

        //Methods created to button clicks
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);
            MessageBox.Show($"You pressed the button '{button.Content}'!");
            button.HorizontalAlignment = button.HorizontalAlignment == HorizontalAlignment.Right
                ? HorizontalAlignment.Left
                : HorizontalAlignment.Right;

            //Make new button with click method.
            Button newButton = new Button();
            newButton.Content = counter++;
            myStackPanel.Children.Add(newButton);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);
            button.Width = 300;
            button1.IsEnabled = !button1.IsEnabled;
        }
    }
}