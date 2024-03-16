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
using WpfPP1.bazadannihPPDataSetTableAdapters;

namespace WpfPP1 { 
    public partial class OknoDataGrid : Window
    {
        InformationCyberSportaTableAdapter InformationCyberSporta = new InformationCyberSportaTableAdapter();
        public OknoDataGrid()
        {
            InitializeComponent();
            CybersportDataGrid.ItemsSource = InformationCyberSporta.GetData();
        }

        private void CybersportDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Back_knopka_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
