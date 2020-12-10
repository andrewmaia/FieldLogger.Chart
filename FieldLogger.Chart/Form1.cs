using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace FieldLogger.Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDataFiltro.Value = DateTime.Today;
            cbTag.SelectedIndex = 0;
            Carregar();
        }



        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Carregar();
        }



        private void Carregar()
        {
            try
            {

                string conn = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                string tag = cbTag.Text.Substring(0, cbTag.Text.IndexOf('-') - 1);
                string sql = $"SELECT * FROM Channel Where Tag = '{tag}' And Date Between '{dtpDataFiltro.Value:yyyy-MM-dd} 00:00:00' And '{dtpDataFiltro.Value:yyyy-MM-dd} 23:59:59'";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ChartPrincipal.DataSource = dt;
                ChartPrincipal.Series[0].Name = cbTag.Text;
                ChartPrincipal.Series[0].XValueMember = "Date";
                ChartPrincipal.Series[0].XValueType = ChartValueType.Time;
                ChartPrincipal.Series[0].YValueMembers = "Value";
                ChartPrincipal.Series[0].YValueType = ChartValueType.Double;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar carregar o gráfico:" + ex.Message);
            }

        }

    }
}
