using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ScrollBarTest.ViewModels;

namespace ScrollBarTest.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
}