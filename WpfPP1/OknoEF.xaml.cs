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

namespace WpfPP1
{
    public partial class OknoEF : Window
    {
        private bazadannihPPEntities2 context = new bazadannihPPEntities2();
        public OknoEF()
        {
            InitializeComponent();
            CybersportDataGrid.ItemsSource = context.InformationCyberSporta.ToList();
        }

        private void Back_knopka_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
