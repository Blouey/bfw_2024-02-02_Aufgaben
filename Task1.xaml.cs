using static _2024_02_02_WpfApp1.App;
using System.Windows;
using System.Windows.Input;

namespace _2024_02_02_WpfApp1;

public partial class Task1 : Window
{
    public Task1()
    {
        InitializeComponent();
    }
    
    private void BtnClose_OnClick(object sender, EventArgs e)
    {
        Close();
    }

    private void BtnCalc_OnClick(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(BruttoField.Text)) return;
        if (BruttoField.Text.Contains('€'))
        {
            BruttoField.Text = BruttoField.Text.Replace("€", "");
        }
        if(!double.TryParse(BruttoField.Text, out double brutto)) return; 
        double netto = brutto * 0.81;
        double tax = brutto * 0.19;
        
        NettoField.Text = $"{netto,0:C2}";
        SteuerField.Text = $"{tax,0:C2}";
    }

}