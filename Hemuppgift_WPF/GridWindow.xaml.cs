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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int row = int.Parse(RowTextBox.Text);
            int column = int.Parse(ColumnTextBox.Text);

            if (row < 0 || row > 3 || column < 0 || column > 3)
            {
                MessageBox.Show("Row and column numbers must be between 0 and 3.");
                return;
            }

            Button newButton = new Button
            {
                Content = $"Row {row}, Column {column}",
                Background = new SolidColorBrush(Colors.LightGreen)
            };

            Grid.SetRow(newButton, row);
            Grid.SetColumn(newButton, column);
            GridPanel.Children.Add(newButton);
        }

     
    }
}
