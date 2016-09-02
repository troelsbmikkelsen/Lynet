using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Lynet {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btn_Calc_Click(object sender, RoutedEventArgs e) {
            // Get string from selected comboboxitem
            string km_str = (cmbbox_Km.SelectedItem as ComboBoxItem).Content.ToString();
            // Remove end and convert string to double
            double km = double.Parse(km_str.Substring(0, km_str.Length - 2));

            try {

                // Get pace from CalcPace method
                DateTime pace = Calculations.CalcPace(km, (int.Parse(txtbox_Hours.Text)), (int.Parse(txtbox_Minutes.Text)));

                // Set label content to formatted text
                lbl_Result.Content = $"{pace.Minute} minut(ter) og {pace.Second} sekund(er)";
            } catch (Exception ex) {
                MessageBox.Show("Indtastningsfejl. Sørg for at du kun skriver hele tal i kasserne\n\n" + ex.Message);
            }
        }
    }
}
