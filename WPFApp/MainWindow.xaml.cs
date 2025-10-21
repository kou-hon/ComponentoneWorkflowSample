using HogeLib;
using System.Windows;

namespace WPFApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        HogeClass hoge = new();
        this.hoge.Text = $"{hoge.Something(new Random().Next(1, 100))} {DateTimeOffset.Now.ToString("yyMMdd HHmmss zzz")}";
    }
}