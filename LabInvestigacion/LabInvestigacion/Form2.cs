using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabInvestigacion
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(LabInvestigacion.Properties.Settings.Default.LanguajesLab1ConnectionString);
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            Cliente DeleteClient = dc.Cliente.FirstOrDefault(clie => clie.Cedula.Equals(int.Parse(txtCedula.Text)));
            dc.Cliente.DeleteOnSubmit(DeleteClient);
            dc.SubmitChanges();
            MessageBox.Show("Se eliminó correctamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            Cliente cliente = new Cliente();
            cliente.Apellido = txtApellido.Text;
            cliente.Cedula = int.Parse(txtCedula.Text);
            cliente.Correo = txtCorreo.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.NumeroTelefono = txtTelefono.Text;
            dc.Cliente.InsertOnSubmit(cliente);
            dc.SubmitChanges();
            MessageBox.Show("Se insertó exitosamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext(con);
            Cliente cliente = dc.Cliente.FirstOrDefault(clie => clie.Cedula.Equals(int.Parse(txtCedula.Text)));
            cliente.Nombre = txtNombre.Text;
            dc.SubmitChanges();
            MessageBox.Show("Se actualizó correctamente");
        }
    }
}
