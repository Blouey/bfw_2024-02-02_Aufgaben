using System.Windows;

namespace _2024_02_02_WpfApp1;

public class Helpers
{
    public static bool IsWindowOpen<T>(string name = "") where T : Window
    {
        return string.IsNullOrEmpty(name)
            ? Application.Current.Windows.OfType<T>().Any()
            : Application.Current.Windows.OfType<T>().Any(w => w.Name.Equals(name));
    }
}