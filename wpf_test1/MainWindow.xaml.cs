using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace wpf_test1
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

        private void btnCut_Click()
        {

        }

        private void rbMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
          e.Handled = true; // rbMenu_ContextMenuOpening bu metod quisc tablor bar da o`ng knoplani bosishni passivlashtiradi

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            load_list();
        }

        private void load_list()
        {
            string cn_string = Properties.Settings.Default.ConnectionString;

            SqlConnection cn_connection = new SqlConnection(cn_string);

            if (cn_connection.State != ConnectionState.Open) 
            {
                cn_connection.Open();
            }


        }
    }
}
