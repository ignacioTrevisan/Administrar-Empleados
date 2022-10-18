using Entidades;
using FrontWinForms;
using Negocio;

namespace empresa
{
    public partial class Form1 : Form
    {
        List <Empleado> empleadosList = new List <Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscarEmpleados();
        }

        public void buscarEmpleados() 
        {
            string nombreBuscar = txt_buscar.Text.Trim().ToUpper();
            Empleado parametro = new Empleado();
            if (!string.IsNullOrEmpty(nombreBuscar.Trim()))
                parametro.nombre = nombreBuscar;

            empleadosList = EmpleadosNegocios.Get(parametro); //aca le mandas
            refreshGrid();

        }
        private void refreshGrid()
        {
            dataGridView1.DataSource = empleadosList;
            dataGridView1.Refresh();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            
            frm.ShowDialog();
            buscarEmpleados();

        }

        
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (empleadoBindingSource.Current == null)
                return;
            Form2 frm = new Form2();
            frm.modo = EnumModoForm.Consulta;
            frm._empleado = (Empleado)empleadoBindingSource.Current;
            frm.ShowDialog();
            buscarEmpleados();
        }

       

        private void txt_buscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscarEmpleados();
            }

        }

    }
}