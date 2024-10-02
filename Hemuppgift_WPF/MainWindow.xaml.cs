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

namespace Hemuppgift_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridButton_Click(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }

        private void StackPanelButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackPanelWindow = new StackPanelWindow();
            stackPanelWindow.Show();
        }

        private void WrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelWindow wrapPanelWindow = new WrapPanelWindow();
            wrapPanelWindow.Show();
        }

        private void DockPanelButton_Click(object sender, RoutedEventArgs e)
        {
            DockPanelWindow dockPanelWindow = new DockPanelWindow();
            dockPanelWindow.Show();
        }
    }
}