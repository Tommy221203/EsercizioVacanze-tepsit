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

namespace EsercizioVacanze_tepsit
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

        private void btncalcola_Click(object sender, RoutedEventArgs e)
        {
            if(cmbnumero.SelectedIndex==0)
            {
                int a = int.Parse(txtnumero.Text);
                string binary = Convert.ToString(a, 2);
                txtresult.Text = $"{binary}";
            }
            if (cmbnumero.SelectedIndex == 1)
            {
                string a = txtnumero.Text;
                string output = Convert.ToInt32(a,2).ToString();
                txtresult.Text = $"{output}";
            }
        }
    }
}
