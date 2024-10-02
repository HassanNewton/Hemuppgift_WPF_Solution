using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hemuppgift_WPF
{
    /// <summary>
    /// Interaction logic for DockPanelWindow.xaml
    /// </summary>
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }

        private void CenterButton_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image
            {
                Source = new BitmapImage(new Uri("C:\\Users\\ha200\\Desktop\\C#_Projects\\Hemuppgift_WPF\\Hemuppgift_WPF\\TrophyImage.jpg")),
                Width = 300,
                Height = 300
            };

            Grid.SetRow(image, Grid.GetRow(CenterButton));
            Grid.SetColumn(image, Grid.GetColumn(CenterButton));

            // Hämta DockPanel
            var dockPanel = this.Content as DockPanel;

            if (dockPanel != null)
            {
                // Ta bort knappen från DockPanel
                dockPanel.Children.Remove(CenterButton);

                // Lägg till bilden i DockPanel
                dockPanel.Children.Add(image);
            }
        }
    }
}
