using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LabInvestigacion
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-3D7M2PMI ; database=Northwind ; integrated security = true");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, System.EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            
        }

        private void btnDesconecta_Click(object sender, System.EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
        }



        private void btnConsulta_Click(object sender, System.EventArgs e)
        {
            string strSQL = "SELECT * FROM dbo.Categories";
            SqlDataReader MiDataReader;
            DataTable MiDataTable = new DataTable();
            SqlCommand Comando = new SqlCommand(strSQL,conexion);
            MiDataReader = Comando.ExecuteReader();
            MiDataTable.Load(MiDataReader, LoadOption.OverwriteChanges);
            txtDatos.DataSource = MiDataTable;
        }
    }
}
