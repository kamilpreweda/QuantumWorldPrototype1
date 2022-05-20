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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuantumWorldPrototype1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResourceModel carbonFiber = new ResourceModel() { Name = "Carbon Fiber", StartingValue = 500};
            ShowResource(carbonFiber, carbonFiber.Name, carbonFiber.StartingValue);
        }

        private void BuildingsMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Buildings buildings = new Buildings();
            buildings.Show();
            this.Close();
        }

        private void OverviewMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow overview = new MainWindow();
            overview.Show();
            this.Close();
        }

        private void ShowResource(ResourceModel resourceModel, string name, int value)
        {
            
           //  ResourcesListBox.Items.Add(resourceModel);
        }
    }
}
