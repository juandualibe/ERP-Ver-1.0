namespace SisVentas.Presentacion
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Pnl_opciones = new System.Windows.Forms.Panel();
            this.btnCerrarsesion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.Pnl_barraestado = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Descripcion_us = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_us = new System.Windows.Forms.Label();
            this.Pnl_contenido = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnFamilias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.Pnl_opciones.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.Pnl_barraestado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_opciones
            // 
            this.Pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(157)))), ((int)(((byte)(190)))));
            this.Pnl_opciones.Controls.Add(this.btnCerrarsesion);
            this.Pnl_opciones.Controls.Add(this.btnUsuarios);
            this.Pnl_opciones.Controls.Add(this.btnEmpresa);
            this.Pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_opciones.Location = new System.Drawing.Point(1116, 0);
            this.Pnl_opciones.Name = "Pnl_opciones";
            this.Pnl_opciones.Size = new System.Drawing.Size(225, 892);
            this.Pnl_opciones.TabIndex = 0;
            this.Pnl_opciones.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_opciones_Paint);
            // 
            // btnCerrarsesion
            // 
            this.btnCerrarsesion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarsesion.Location = new System.Drawing.Point(9, 740);
            this.btnCerrarsesion.Name = "btnCerrarsesion";
            this.btnCerrarsesion.Size = new System.Drawing.Size(207, 83);
            this.btnCerrarsesion.TabIndex = 2;
            this.btnCerrarsesion.Text = "Cerrar Sesión";
            this.btnCerrarsesion.UseVisualStyleBackColor = true;
            this.btnCerrarsesion.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(8, 161);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(207, 83);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Location = new System.Drawing.Point(8, 49);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(207, 83);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            this.Pnl_titulo.Controls.Add(this.pctLogo);
            this.Pnl_titulo.Controls.Add(this.lbl_Titulo);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(1116, 132);
            this.Pnl_titulo.TabIndex = 0;
            this.Pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_titulo_Paint);
            this.Pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_titulo_MouseDown);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(15, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(131, 114);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            this.pctLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctLogo_MouseDown);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Titulo.Location = new System.Drawing.Point(234, 49);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(279, 36);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Sistema de Ventas";
            this.lbl_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Titulo_MouseDown);
            // 
            // Pnl_barraestado
            // 
            this.Pnl_barraestado.BackColor = System.Drawing.Color.Gainsboro;
            this.Pnl_barraestado.Controls.Add(this.pictureBox2);
            this.Pnl_barraestado.Controls.Add(this.lbl_Descripcion_us);
            this.Pnl_barraestado.Controls.Add(this.pictureBox1);
            this.Pnl_barraestado.Controls.Add(this.lbl_nombre_us);
            this.Pnl_barraestado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_barraestado.Location = new System.Drawing.Point(0, 766);
            this.Pnl_barraestado.Name = "Pnl_barraestado";
            this.Pnl_barraestado.Size = new System.Drawing.Size(1116, 126);
            this.Pnl_barraestado.TabIndex = 1;
            this.Pnl_barraestado.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Descripcion_us
            // 
            this.lbl_Descripcion_us.AutoSize = true;
            this.lbl_Descripcion_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion_us.Location = new System.Drawing.Point(69, 64);
            this.lbl_Descripcion_us.Name = "lbl_Descripcion_us";
            this.lbl_Descripcion_us.Size = new System.Drawing.Size(102, 20);
            this.lbl_Descripcion_us.TabIndex = 2;
            this.lbl_Descripcion_us.Text = "Rol Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nombre_us
            // 
            this.lbl_nombre_us.AutoSize = true;
            this.lbl_nombre_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_us.Location = new System.Drawing.Point(69, 24);
            this.lbl_nombre_us.Name = "lbl_nombre_us";
            this.lbl_nombre_us.Size = new System.Drawing.Size(77, 20);
            this.lbl_nombre_us.TabIndex = 0;
            this.lbl_nombre_us.Text = "Usuario: ";
            this.lbl_nombre_us.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pnl_contenido
            // 
            this.Pnl_contenido.BackColor = System.Drawing.Color.LightCyan;
            this.Pnl_contenido.Controls.Add(this.btnClientes);
            this.Pnl_contenido.Controls.Add(this.btnReportes);
            this.Pnl_contenido.Controls.Add(this.btnVentas);
            this.Pnl_contenido.Controls.Add(this.btnCompras);
            this.Pnl_contenido.Controls.Add(this.btnProveedores);
            this.Pnl_contenido.Controls.Add(this.btnFamilias);
            this.Pnl_contenido.Controls.Add(this.btnProductos);
            this.Pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_contenido.Location = new System.Drawing.Point(0, 132);
            this.Pnl_contenido.Name = "Pnl_contenido";
            this.Pnl_contenido.Size = new System.Drawing.Size(1116, 634);
            this.Pnl_contenido.TabIndex = 2;
            this.Pnl_contenido.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_contenido_Paint);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClientes.ImageKey = "users_clients_group_16774.png";
            this.btnClientes.ImageList = this.imageList1;
            this.btnClientes.Location = new System.Drawing.Point(595, 29);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(212, 214);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empresa.png");
            this.imageList1.Images.SetKeyName(1, "724package_100522.png");
            this.imageList1.Images.SetKeyName(2, "package_box_delivery_icon_232955.png");
            this.imageList1.Images.SetKeyName(3, "provider_fst_icon_208586.png");
            this.imageList1.Images.SetKeyName(4, "diagram-61_24456.png");
            this.imageList1.Images.SetKeyName(5, "cash_register_icon_192650.png");
            this.imageList1.Images.SetKeyName(6, "Reports_25409.png");
            this.imageList1.Images.SetKeyName(7, "users_clients_group_16774.png");
            this.imageList1.Images.SetKeyName(8, "transport_truck_delivery_icon_148906.png");
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReportes.ImageKey = "Reports_25409.png";
            this.btnReportes.ImageList = this.imageList1;
            this.btnReportes.Location = new System.Drawing.Point(595, 372);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(212, 214);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVentas.ImageKey = "cash_register_icon_192650.png";
            this.btnVentas.ImageList = this.imageList1;
            this.btnVentas.Location = new System.Drawing.Point(15, 372);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(212, 214);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCompras.ImageKey = "diagram-61_24456.png";
            this.btnCompras.ImageList = this.imageList1;
            this.btnCompras.Location = new System.Drawing.Point(301, 372);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(212, 214);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProveedores.ImageKey = "transport_truck_delivery_icon_148906.png";
            this.btnProveedores.ImageList = this.imageList1;
            this.btnProveedores.Location = new System.Drawing.Point(888, 29);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(212, 214);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnFamilias
            // 
            this.btnFamilias.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFamilias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamilias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFamilias.ImageKey = "package_box_delivery_icon_232955.png";
            this.btnFamilias.ImageList = this.imageList1;
            this.btnFamilias.Location = new System.Drawing.Point(301, 29);
            this.btnFamilias.Name = "btnFamilias";
            this.btnFamilias.Size = new System.Drawing.Size(212, 214);
            this.btnFamilias.TabIndex = 2;
            this.btnFamilias.Text = "Familias Productos";
            this.btnFamilias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFamilias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFamilias.UseVisualStyleBackColor = false;
            this.btnFamilias.Click += new System.EventHandler(this.btnFamilias_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProductos.ImageKey = "724package_100522.png";
            this.btnProductos.ImageList = this.imageList1;
            this.btnProductos.Location = new System.Drawing.Point(10, 29);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(212, 214);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 892);
            this.Controls.Add(this.Pnl_contenido);
            this.Controls.Add(this.Pnl_barraestado);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Pnl_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas ver 1.0";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.Pnl_opciones.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.Pnl_barraestado.ResumeLayout(false);
            this.Pnl_barraestado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_contenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_opciones;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Panel Pnl_barraestado;
        private System.Windows.Forms.Panel Pnl_contenido;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnFamilias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Label lbl_nombre_us;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Descripcion_us;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnCerrarsesion;
        private System.Windows.Forms.Button btnUsuarios;
    }
}