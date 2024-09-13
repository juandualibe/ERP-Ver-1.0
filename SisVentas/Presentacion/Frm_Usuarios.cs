using SisVentas.Datos;
using SisVentas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }

        #region "Variables"
        int nCodigo_us = 0;
        int nEstadoGuarda = 0;
        #endregion

        #region "Metodos"
        private void Limpia_Texto()
        {
            txtLogin_us.Text = "";
            txtPassword_us.Text = "";
            txtNombre_us.Text = "";
            cmbRolUsuario.Text = "";
        }
        private void Estado_Texto(bool lEstado)
        {
            txtLogin_us.Enabled = lEstado;
            txtPassword_us.Enabled = lEstado;
            txtNombre_us.Enabled = lEstado;
            cmbRolUsuario.Enabled = lEstado;
        }

        private void Estado_BotonesProcesos(bool lEstado)
        {
            btnCancelar.Visible = lEstado;
            btnGuardar.Visible = lEstado;
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            btnNuevo.Enabled = lEstado;
            btnActualizar.Enabled = lEstado;
            btnEstado.Enabled = lEstado;
            btnRetornar.Enabled = lEstado;
        }

        private void Formato()
        {
            dgvListado.Columns[0].Width = 100;
            dgvListado.Columns[0].HeaderText = "CÓDIGO_US";
            dgvListado.Columns[1].Width = 200;
            dgvListado.Columns[1].HeaderText = "LOGIN";
            dgvListado.Columns[2].Width = 200;
            dgvListado.Columns[2].HeaderText = "NOMBRE";
            dgvListado.Columns[3].Width = 200;
            dgvListado.Columns[3].HeaderText = "ROL DE USUARIO";
            dgvListado.Columns[4].Width = 100;
            dgvListado.Columns[4].HeaderText = "ACTIVO";
            dgvListado.Columns[5].Visible = false;
        }

        private void Listado_us(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            dgvListado.DataSource = Datos.Listado_us(cTexto);
            this.Formato();
        }

        private void Listado_ru()
        {
            try
            {
                D_Usuarios Datos = new D_Usuarios();
                cmbRolUsuario.DataSource = Datos.Listado_ru();
                cmbRolUsuario.ValueMember = "codigo_ru";
                cmbRolUsuario.DisplayMember = "descripcion_ru";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTrabajo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_ru();
            this.Listado_us("%"); //El % es para que muestre toda la info que tiene actualmente esa tabla
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; //Nuevo Registro
            this.Limpia_Texto(); //Llamada al método
            this.Estado_Texto(true); //True para que se active la caja de texto o el listado del combo
            this.Estado_BotonesProcesos(true); //Para que se activen los botones de cancelar y guardar
            this.Estado_BotonesPrincipales(false); //Para que se inactiven mientras estamos en el proceso de registrar nueva información
            this.txtLogin_us.Focus(); //Envía el enfoque del cursos a esa caja de texto
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 0;
            this.Limpia_Texto(); //Limpia la caja de txt
            this.Estado_Texto(false); //Para que se desactiven las cajas de texto cuando terminamos de generar nuevos registros
            this.Estado_BotonesProcesos(false); //Para que se oculten mientras no generamos un registro
            this.Estado_BotonesPrincipales(true); //Para que se vuelvan a activar mientras no generamos nuevo registro

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_us(txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtLogin_us.Text == string.Empty ||
               txtPassword_us.Text == string.Empty ||
               txtNombre_us.Text == string.Empty ||
               cmbRolUsuario.Text == string.Empty)
            {
                MessageBox.Show("Ingrese dato requerido (*)",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else //Procedemos a guardar la información 
            {
                string Rpta;
                E_Usuarios oPro = new E_Usuarios();
                oPro.Codigo_us = nCodigo_us;
                oPro.Login_us = txtLogin_us.Text;
                oPro.Password_us = txtPassword_us.Text;
                oPro.Nombre_us = txtNombre_us.Text;
                oPro.Codigo_ru = Convert.ToInt32(cmbRolUsuario.SelectedValue);
                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Guardar_us(nEstadoGuarda, oPro);
                bool esNumero = int.TryParse(Rpta, out int xCodigo);
                if (esNumero == true) 
                {
                    nEstadoGuarda = 0;
                    nCodigo_us = 0;
                    this.Limpia_Texto();
                    this.Estado_Texto(false);
                    this.Estado_BotonesProcesos(false);
                    this.Estado_BotonesPrincipales(true);
                    this.Listado_us("%");
                    MessageBox.Show("Los datos han sido guardados correctamente con el código #",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
