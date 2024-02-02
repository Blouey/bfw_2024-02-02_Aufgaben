using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _2024_02_02_WpfApp1;

public partial class Task2 : Window
{
    public Task2()
    {
        InitializeComponent();
        
        MessageBox.Show("Eine Berechnung des Windchill erfolgt nur bei Windgeschwindigkeiten " +
                        ">= 10km/h und bei \nLufttemperaturen <=10\u00b0C. Bitte geben Sie die Werte in den " +
                        "entsprechenden Feldern ein und klicken Sie auf 'Berechnen'.",
            "Please read before you start", MessageBoxButton.OK, MessageBoxImage.Warning);
    }
    
    private void BtnClose_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void BtnClear_OnClick(object sender, RoutedEventArgs e)
    {
        WindSpeedField.Text = "";
        AirTempField.Text = "";
        WindChillField.Text = "";
        TempWarn.Visibility = Visibility.Hidden;
        WindWarn.Visibility = Visibility.Hidden;
    }
    
    private void BtnCalc_OnClick(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(WindSpeedField.Text) 
            || string.IsNullOrEmpty(AirTempField.Text)
            || !double.TryParse(WindSpeedField.Text, out double windSpeed) 
            || !double.TryParse(AirTempField.Text, out double airTemp)) return;
        
        TempWarn.Visibility = airTemp > 10 ? Visibility.Visible : Visibility.Hidden;
        WindWarn.Visibility = windSpeed < 10 ? Visibility.Visible : Visibility.Hidden;
        if (windSpeed < 10) return;
        if (airTemp > 10) return; 
        
        double windChill = 13.12 + 0.6215 * airTemp - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * airTemp * Math.Pow(windSpeed, 0.16);
        WindChillField.Text = $"{windChill,0:F2} \u00b0C";
    }
    
}

