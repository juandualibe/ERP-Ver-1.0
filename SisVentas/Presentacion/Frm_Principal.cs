using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();

            // Configuración inicial
            this.Text = string.Empty;
            this.ControlBox = false;
            /*this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;*/
            this.FormBorderStyle = FormBorderStyle.Sizable; // Permite redimensionar la ventana
            /*this.WindowState = FormWindowState.Maximized; // Maximiza la ventana al iniciar*/
        }

        #region "Mis Variables"

        internal int nCodigo_us { get; set; }
        internal string cLogin_us { get; set; }
        internal string cNombre_us { get; set; }
        internal string cDescripcion_ru { get; set; }
        internal int nCodigo_ru { get; set; }

        #endregion

        #region "Estilo para el control del Título"
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr Hwnd, int wMsg, int wParam, int lParam);
        #endregion

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lbl_nombre_us.Text = "Usuario: " + cNombre_us;
            lbl_Descripcion_us.Text = "Rol Usuario: " + cDescripcion_ru;

            

            // Configura el tamaño y la ubicación del panel de opciones
            /*Pnl_opciones.Dock = DockStyle.Right;*/ // Ajusta al lado izquierdo
            /*Pnl_opciones.Width = 200;*/ // Ajusta el ancho según tus necesidades

            // Configura otros paneles para ajustarse al redimensionar la ventana
            /*Pnl_contenido.Dock = DockStyle.Fill;*/ // Llena el área restante del formulario
           
            /*Pnl_titulo.Dock = DockStyle.Top;*/ // Ajusta al área superior del formulario
        }

        private void Pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pctLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Opcion = MessageBox.Show("¿Desea cerrar sesión del Sistema?",
                                                  "Aviso del Sistema",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question);

            if (Opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Lógica para pintar el panel1 si es necesario
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            // Lógica para manejar el evento de clic en el botón de Compras
        }

        private void btnFamilias_Click(object sender, EventArgs e)
        {
            // Lógica para manejar el evento de clic en el botón de Familias
        }

        private void Pnl_opciones_Paint(object sender, PaintEventArgs e)
        {
            // Lógica para pintar el panel de opciones si es necesario
        }

        private void Pnl_contenido_Paint(object sender, PaintEventArgs e)
        {
            // Lógica para pintar el panel de contenido si es necesario
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Lógica para manejar el evento de clic en el label1
        }

        private void Pnl_titulo_Paint(object sender, PaintEventArgs e)
        {
            // Lógica para pintar el panel de título si es necesario
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Frm_Usuarios oFrm_us = new Frm_Usuarios();
            oFrm_us.ShowDialog();
        }
    }
}







