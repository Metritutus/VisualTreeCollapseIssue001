using System.Windows;
using System.Windows.Media;

namespace VisualTreeCollapseIssue001
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateRow1DescendantBoundsButton_Click(object sender, RoutedEventArgs e)
        {
            CalculateRow1Bounds();
        }

        private void RefreshDataGridItemsButton_Click(object sender, RoutedEventArgs e)
        {
            ExampleDataGrid.Items.Refresh();
        }

        private void CalculateRow1Bounds()
        {
            var row = ExampleDataGrid.ItemContainerGenerator.ContainerFromItem(ExampleDataGrid.Items[0]);
            var descendantBounds = VisualTreeHelper.GetDescendantBounds(row as Visual);
            var workaroundBounds = VisualTreeDescendantBoundsHelper.GetVisibleDescendantBounds(row as Visual);
            Row1Bounds.Text = $"Bounds: {descendantBounds}, Workaround Bounds: {workaroundBounds}";
        }
    }
}