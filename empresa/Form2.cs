using empresa;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontWinForms
{
    public partial class Form2 : Form
    {
        public EnumModoForm modo = EnumModoForm.Alta;
        public Empleado _empleado = new Empleado();
        public Form2()
        {
            
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (modo == EnumModoForm.Alta) 
            {
                limpiarControles();
                HabilitarControles(true);
            }
            if (modo == EnumModoForm.Modificacion) 
            {
                HabilitarControles(true);
                CargarDatos();
            }
        }

        private void CargarDatos()
        {

            txt_salario.Value = Convert.ToDecimal(_empleado.salario);
            txt_direccion.Text = _empleado.direccion;
            txt_dni.Text = _empleado.dni;
            if (_empleado.FechaDeIngreso != null)
                txt_ingreso.Value = Convert.ToDateTime(_empleado.FechaDeIngreso);
            txt_nom.Text = _empleado.nombre;
        }
        private bool ValidarEmpleado(ref string mensaje, Empleado e)
        {
            mensaje = "";
            if (String.IsNullOrEmpty(e.dni.Trim()))
            {
                mensaje += "\nError en DNI";
            }
            if (String.IsNullOrEmpty(e.nombre.Trim()))
            {
                mensaje += "\nError en Nombre";
            }
            if (!String.IsNullOrEmpty(mensaje))
            {
                return false;
            }
            return true;
        }

        private void HabilitarControles(bool habilitar)
        {

            txt_direccion.Enabled = habilitar;
            txt_dni.Enabled = habilitar;
            txt_ingreso.Enabled = habilitar;
            txt_nom.Enabled = habilitar;
            txt_salario.Enabled = habilitar;

        }
        private void limpiarControles()
        {
            txt_direccion.Text = "";
            txt_dni.Text = "";
            txt_ingreso.Text = "";
            txt_nom.Text = "";
            txt_salario.Value = 0;
        }


        private void Guardar()
        {
            try
            {
                //cargo los datos ingresados en un objeto empleado
                Empleado emp = new Empleado();
                emp.salario = txt_salario.Value;
                emp.direccion = txt_direccion.Text.Trim();
                emp.dni = txt_dni.Text.Trim();
                emp.FechaDeIngreso = txt_ingreso.Value;
                emp.Departamento = null; 
                emp.nombre = txt_nom.Text.Trim();
                
                string mensajeErrores = "";
                DialogResult res = MessageBox.Show("¿Confirma guardar ? ","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    return;
                }
                
                int idEmp = EmpleadosNegocios.Insertar(emp);
                string si = idEmp.ToString();
                MessageBox.Show("Se generó el empleado nro " + idEmp.ToString(), "Empleado creado",MessageBoxButtons.OK,MessageBoxIcon.Information);
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_confir_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }
    }

}

       
