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

namespace _2024_02_02_WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnTask1_OnClick(object sender, RoutedEventArgs e)
    {
        if (Helpers.IsWindowOpen<Task1>(""))
        {
            MessageBox.Show("The window is already open");
        }
        else
        {
            Task1 task1Window = new Task1();
            task1Window.Show();
        }
    }

    private void BtnTask2_OnClick(object sender, RoutedEventArgs e)
    {
        if (Helpers.IsWindowOpen<Task2>(""))
        {
            MessageBox.Show("The window is already open");
        }
        else
        {
            Task2 task2Window = new Task2();
            task2Window.Show();
        }
    }

    private void BtnTask3_OnClick(object sender, RoutedEventArgs e)
    {
        if (Helpers.IsWindowOpen<Task3>(""))
        {
            MessageBox.Show("The window is already open");
        }
        else
        {
            Task3 task3Window = new Task3();
            task3Window.Show();
        }
    }
    
    private void BtnClose_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}