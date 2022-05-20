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

namespace QuantumWorldPrototype1
{
    /// <summary>
    /// Logika interakcji dla klasy Buildings.xaml
    /// </summary>
    public partial class Buildings : Window
    {
        public Buildings()
        {
            InitializeComponent();
        }

        private void OverviewMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow overview = new MainWindow();
            overview.Show();
            this.Close();
        }

        private void BuildingsMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Buildings buildings = new Buildings();
            buildings.Show();
            this.Close();
        }
    }
}
