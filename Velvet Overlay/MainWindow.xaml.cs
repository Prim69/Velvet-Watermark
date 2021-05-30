using System.Windows;

namespace Velvet_Overlay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Width = SystemParameters.PrimaryScreenWidth;
            Left = 0;
            Top = (SystemParameters.PrimaryScreenHeight / 2) - MainPanel.Height;
            MainPanel.Width = SystemParameters.PrimaryScreenWidth;
            MainText.Width = MainPanel.Width / 2;
        }

    }
}
