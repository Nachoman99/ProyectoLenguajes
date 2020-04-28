using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using LabInvestigacion.Logica;

namespace LabInvestigacion
{
    public partial class Form1 : Form
    {
        LecturaArchivos lectura = new LecturaArchivos();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, System.EventArgs e)
        {
            
            string server = lectura.leerServer();
            string database = lectura.leerDatabase();
            string security = lectura.leerSecurity();
            SqlConnection conexion = new SqlConnection(@"server=" + server + "; " + "database=" + database + "; " + "integrated security =" + security);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
        }

        private void btnDesconecta_Click(object sender, System.EventArgs e)
        {
            string server = lectura.leerServer();
            string database = lectura.leerDatabase();
            string security = lectura.leerSecurity();
            SqlConnection conexion = new SqlConnection(@"server=" + server + "; " + "database=" + database + "; " + "integrated security =" + security);
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
        }

        private void btnConsulta_Click(object sender, System.EventArgs e)
        {
            string server = lectura.leerServer();
            string database = lectura.leerDatabase();
            string security = lectura.leerSecurity();
            SqlConnection conexion = new SqlConnection(@"server=" + server + "; " + "database=" + database + "; " + "integrated security =" + security);
            string strSQL = "SELECT * FROM dbo.Categories";
            SqlDataReader MiDataReader;
            DataTable MiDataTable = new DataTable();
            SqlCommand Comando = new SqlCommand(strSQL,conexion);
            MiDataReader = Comando.ExecuteReader();
            MiDataTable.Load(MiDataReader, LoadOption.OverwriteChanges);
            txtDatos.DataSource = MiDataTable;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
