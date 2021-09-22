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
using System.Configuration;

namespace wpf_test1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window


    {
        SqlCommand  cmd;
        SqlDataAdapter da;
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

        public void kullanici_ekle()
        {
            SqlConnection cn_connection = new SqlConnection();
            cn_connection.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            if (cn_connection.State != ConnectionState.Open)
            {
                cn_connection.Open();
            }

        }

        
        


        private void load_list()
        {
            //string cn_string = Properties.Settings.Default.ConnectionString;

            SqlConnection cn_connection = new SqlConnection();
            cn_connection.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

            if (cn_connection.State != ConnectionState.Open) 
            {
                cn_connection.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [tblUsers]";
            cmd.Connection = cn_connection;
            SqlDataReader dr = cmd.ExecuteReader();
            dtUsers.ItemsSource = dr;

            
            
            
            
            
            
            
            
            
            
            
            /*da = new SqlDataAdapter("select *from tbl_Users", cn_connection);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dtUsers.ItemsSource= tablo.DefaultView;
            cn_connection.Close();*/

        }
    }
}
