namespace PracticaWinForms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            PnlUsuario = new Panel();
            lblFecha = new Label();
            lblBienvenido = new Label();
            picBoxLogo = new PictureBox();
            FlpSideBar = new FlowLayoutPanel();
            BtnSideBarAlumnos = new Button();
            PnlSubControlAlumnos = new Panel();
            BtnListadoAlumnos = new Button();
            BtnAltaAlumno = new Button();
            BtnCarreras = new Button();
            PnlSubControlCarreras = new Panel();
            BtnListadoCarreras = new Button();
            BtnAltaCarrera = new Button();
            BtnMaterias = new Button();
            PnlSubControlMaterias = new Panel();
            BtnListadoMaterias = new Button();
            BtnAltaMateria = new Button();
            LblPestañaActual = new Label();
            BtnCerrarPestañaActual = new Button();
            FlpPestaña = new FlowLayoutPanel();
            PnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            FlpSideBar.SuspendLayout();
            PnlSubControlAlumnos.SuspendLayout();
            PnlSubControlCarreras.SuspendLayout();
            PnlSubControlMaterias.SuspendLayout();
            FlpPestaña.SuspendLayout();
            SuspendLayout();
            // 
            // PnlUsuario
            // 
            PnlUsuario.BackColor = Color.FromArgb(39, 145, 230);
            PnlUsuario.Controls.Add(lblFecha);
            PnlUsuario.Controls.Add(lblBienvenido);
            PnlUsuario.Controls.Add(picBoxLogo);
            PnlUsuario.Dock = DockStyle.Top;
            PnlUsuario.Location = new Point(0, 0);
            PnlUsuario.Name = "PnlUsuario";
            PnlUsuario.Size = new Size(1064, 139);
            PnlUsuario.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(153, 33);
            lblFecha.Name = "lblFecha";
            lblFecha.RightToLeft = RightToLeft.Yes;
            lblFecha.Size = new Size(17, 25);
            lblFecha.TabIndex = 2;
            lblFecha.Text = ".";
            lblFecha.TextAlign = ContentAlignment.TopRight;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(153, 8);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(186, 25);
            lblBienvenido.TabIndex = 1;
            lblBienvenido.Text = "Bienvenido Usuario";
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = Properties.Resources.UTN_logo;
            picBoxLogo.Location = new Point(11, 7);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(136, 127);
            picBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 0;
            picBoxLogo.TabStop = false;
            // 
            // FlpSideBar
            // 
            FlpSideBar.BackColor = Color.White;
            FlpSideBar.Controls.Add(BtnSideBarAlumnos);
            FlpSideBar.Controls.Add(PnlSubControlAlumnos);
            FlpSideBar.Controls.Add(BtnCarreras);
            FlpSideBar.Controls.Add(PnlSubControlCarreras);
            FlpSideBar.Controls.Add(BtnMaterias);
            FlpSideBar.Controls.Add(PnlSubControlMaterias);
            FlpSideBar.Dock = DockStyle.Left;
            FlpSideBar.Location = new Point(0, 139);
            FlpSideBar.Name = "FlpSideBar";
            FlpSideBar.Size = new Size(166, 542);
            FlpSideBar.TabIndex = 1;
            // 
            // BtnSideBarAlumnos
            // 
            BtnSideBarAlumnos.BackColor = Color.White;
            BtnSideBarAlumnos.FlatAppearance.BorderColor = Color.Black;
            BtnSideBarAlumnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnSideBarAlumnos.FlatStyle = FlatStyle.Flat;
            BtnSideBarAlumnos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSideBarAlumnos.Location = new Point(14, 3);
            BtnSideBarAlumnos.Margin = new Padding(14, 3, 3, 0);
            BtnSideBarAlumnos.Name = "BtnSideBarAlumnos";
            BtnSideBarAlumnos.Size = new Size(130, 31);
            BtnSideBarAlumnos.TabIndex = 0;
            BtnSideBarAlumnos.Text = "Alumnos";
            BtnSideBarAlumnos.UseVisualStyleBackColor = false;
            BtnSideBarAlumnos.Click += BtnSideBarAlumnos_Click;
            // 
            // PnlSubControlAlumnos
            // 
            PnlSubControlAlumnos.AutoSize = true;
            PnlSubControlAlumnos.Controls.Add(BtnListadoAlumnos);
            PnlSubControlAlumnos.Controls.Add(BtnAltaAlumno);
            PnlSubControlAlumnos.Location = new Point(14, 37);
            PnlSubControlAlumnos.Margin = new Padding(14, 3, 3, 3);
            PnlSubControlAlumnos.Name = "PnlSubControlAlumnos";
            PnlSubControlAlumnos.Size = new Size(105, 62);
            PnlSubControlAlumnos.TabIndex = 1;
            // 
            // BtnListadoAlumnos
            // 
            BtnListadoAlumnos.BackColor = Color.White;
            BtnListadoAlumnos.FlatAppearance.BorderColor = Color.Black;
            BtnListadoAlumnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnListadoAlumnos.FlatStyle = FlatStyle.Flat;
            BtnListadoAlumnos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnListadoAlumnos.Location = new Point(0, 32);
            BtnListadoAlumnos.Name = "BtnListadoAlumnos";
            BtnListadoAlumnos.Size = new Size(102, 27);
            BtnListadoAlumnos.TabIndex = 1;
            BtnListadoAlumnos.Text = "Listado alumnos";
            BtnListadoAlumnos.UseVisualStyleBackColor = false;
            BtnListadoAlumnos.Click += BtnListadoAlumnos_Click;
            // 
            // BtnAltaAlumno
            // 
            BtnAltaAlumno.BackColor = Color.White;
            BtnAltaAlumno.FlatAppearance.BorderColor = Color.Black;
            BtnAltaAlumno.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnAltaAlumno.FlatStyle = FlatStyle.Flat;
            BtnAltaAlumno.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAltaAlumno.Location = new Point(0, 3);
            BtnAltaAlumno.Name = "BtnAltaAlumno";
            BtnAltaAlumno.Size = new Size(102, 27);
            BtnAltaAlumno.TabIndex = 0;
            BtnAltaAlumno.Text = "Dar de alta";
            BtnAltaAlumno.UseVisualStyleBackColor = false;
            BtnAltaAlumno.Click += BtnAltaAlumno_Click;
            // 
            // BtnCarreras
            // 
            BtnCarreras.BackColor = Color.White;
            BtnCarreras.FlatAppearance.BorderColor = Color.Black;
            BtnCarreras.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnCarreras.FlatStyle = FlatStyle.Flat;
            BtnCarreras.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            BtnCarreras.Location = new Point(14, 105);
            BtnCarreras.Margin = new Padding(14, 3, 3, 0);
            BtnCarreras.Name = "BtnCarreras";
            BtnCarreras.Size = new Size(130, 31);
            BtnCarreras.TabIndex = 2;
            BtnCarreras.Text = "Carreras";
            BtnCarreras.UseVisualStyleBackColor = false;
            BtnCarreras.Click += BtnCarreras_Click;
            // 
            // PnlSubControlCarreras
            // 
            PnlSubControlCarreras.AutoSize = true;
            PnlSubControlCarreras.Controls.Add(BtnListadoCarreras);
            PnlSubControlCarreras.Controls.Add(BtnAltaCarrera);
            PnlSubControlCarreras.Location = new Point(14, 139);
            PnlSubControlCarreras.Margin = new Padding(14, 3, 3, 3);
            PnlSubControlCarreras.Name = "PnlSubControlCarreras";
            PnlSubControlCarreras.Size = new Size(105, 62);
            PnlSubControlCarreras.TabIndex = 2;
            // 
            // BtnListadoCarreras
            // 
            BtnListadoCarreras.BackColor = Color.White;
            BtnListadoCarreras.FlatAppearance.BorderColor = Color.Black;
            BtnListadoCarreras.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnListadoCarreras.FlatStyle = FlatStyle.Flat;
            BtnListadoCarreras.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            BtnListadoCarreras.Location = new Point(0, 32);
            BtnListadoCarreras.Name = "BtnListadoCarreras";
            BtnListadoCarreras.Size = new Size(102, 27);
            BtnListadoCarreras.TabIndex = 1;
            BtnListadoCarreras.Text = "Listado carreras";
            BtnListadoCarreras.UseVisualStyleBackColor = false;
            BtnListadoCarreras.Click += BtnListadoCarreras_Click;
            // 
            // BtnAltaCarrera
            // 
            BtnAltaCarrera.BackColor = Color.White;
            BtnAltaCarrera.FlatAppearance.BorderColor = Color.Black;
            BtnAltaCarrera.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnAltaCarrera.FlatStyle = FlatStyle.Flat;
            BtnAltaCarrera.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            BtnAltaCarrera.Location = new Point(0, 3);
            BtnAltaCarrera.Name = "BtnAltaCarrera";
            BtnAltaCarrera.Size = new Size(102, 27);
            BtnAltaCarrera.TabIndex = 0;
            BtnAltaCarrera.Text = "Dar de alta";
            BtnAltaCarrera.UseVisualStyleBackColor = false;
            BtnAltaCarrera.Click += BtnAltaCarrera_Click;
            // 
            // BtnMaterias
            // 
            BtnMaterias.BackColor = Color.White;
            BtnMaterias.FlatAppearance.BorderColor = Color.Black;
            BtnMaterias.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnMaterias.FlatStyle = FlatStyle.Flat;
            BtnMaterias.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            BtnMaterias.Location = new Point(14, 207);
            BtnMaterias.Margin = new Padding(14, 3, 3, 0);
            BtnMaterias.Name = "BtnMaterias";
            BtnMaterias.Size = new Size(130, 31);
            BtnMaterias.TabIndex = 3;
            BtnMaterias.Text = "Materias";
            BtnMaterias.UseVisualStyleBackColor = false;
            BtnMaterias.Click += BtnMaterias_Click;
            // 
            // PnlSubControlMaterias
            // 
            PnlSubControlMaterias.AutoSize = true;
            PnlSubControlMaterias.Controls.Add(BtnListadoMaterias);
            PnlSubControlMaterias.Controls.Add(BtnAltaMateria);
            PnlSubControlMaterias.Location = new Point(14, 241);
            PnlSubControlMaterias.Margin = new Padding(14, 3, 3, 3);
            PnlSubControlMaterias.Name = "PnlSubControlMaterias";
            PnlSubControlMaterias.Size = new Size(105, 62);
            PnlSubControlMaterias.TabIndex = 3;
            // 
            // BtnListadoMaterias
            // 
            BtnListadoMaterias.BackColor = Color.White;
            BtnListadoMaterias.FlatAppearance.BorderColor = Color.Black;
            BtnListadoMaterias.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnListadoMaterias.FlatStyle = FlatStyle.Flat;
            BtnListadoMaterias.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            BtnListadoMaterias.Location = new Point(0, 32);
            BtnListadoMaterias.Name = "BtnListadoMaterias";
            BtnListadoMaterias.Size = new Size(102, 27);
            BtnListadoMaterias.TabIndex = 1;
            BtnListadoMaterias.Text = "Listado materias";
            BtnListadoMaterias.UseVisualStyleBackColor = false;
            BtnListadoMaterias.Click += BtnListadoMaterias_Click;
            // 
            // BtnAltaMateria
            // 
            BtnAltaMateria.BackColor = Color.White;
            BtnAltaMateria.FlatAppearance.BorderColor = Color.Black;
            BtnAltaMateria.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnAltaMateria.FlatStyle = FlatStyle.Flat;
            BtnAltaMateria.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            BtnAltaMateria.Location = new Point(0, 3);
            BtnAltaMateria.Name = "BtnAltaMateria";
            BtnAltaMateria.Size = new Size(102, 27);
            BtnAltaMateria.TabIndex = 0;
            BtnAltaMateria.Text = "Dar de alta";
            BtnAltaMateria.UseVisualStyleBackColor = false;
            BtnAltaMateria.Click += BtnAltaMateria_Click;
            // 
            // LblPestañaActual
            // 
            LblPestañaActual.AutoSize = true;
            LblPestañaActual.BackColor = Color.Transparent;
            LblPestañaActual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPestañaActual.Location = new Point(10, 3);
            LblPestañaActual.Margin = new Padding(10, 3, 0, 0);
            LblPestañaActual.Name = "LblPestañaActual";
            LblPestañaActual.Size = new Size(106, 21);
            LblPestañaActual.TabIndex = 3;
            LblPestañaActual.Text = "Alta Alumno";
            LblPestañaActual.UseMnemonic = false;
            // 
            // BtnCerrarPestañaActual
            // 
            BtnCerrarPestañaActual.BackColor = Color.FromArgb(240, 153, 163);
            BtnCerrarPestañaActual.FlatAppearance.BorderColor = Color.Black;
            BtnCerrarPestañaActual.FlatAppearance.MouseOverBackColor = Color.FromArgb(209, 73, 91);
            BtnCerrarPestañaActual.FlatStyle = FlatStyle.Flat;
            BtnCerrarPestañaActual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCerrarPestañaActual.Location = new Point(119, 3);
            BtnCerrarPestañaActual.Name = "BtnCerrarPestañaActual";
            BtnCerrarPestañaActual.Size = new Size(21, 23);
            BtnCerrarPestañaActual.TabIndex = 4;
            BtnCerrarPestañaActual.TabStop = false;
            BtnCerrarPestañaActual.Text = "X";
            BtnCerrarPestañaActual.UseVisualStyleBackColor = false;
            BtnCerrarPestañaActual.Click += BtnCerrarPestañaActual_Click;
            // 
            // FlpPestaña
            // 
            FlpPestaña.AutoSize = true;
            FlpPestaña.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FlpPestaña.BackColor = Color.White;
            FlpPestaña.Controls.Add(LblPestañaActual);
            FlpPestaña.Controls.Add(BtnCerrarPestañaActual);
            FlpPestaña.Location = new Point(198, 146);
            FlpPestaña.Name = "FlpPestaña";
            FlpPestaña.Size = new Size(143, 29);
            FlpPestaña.TabIndex = 6;
            FlpPestaña.Paint += FlpPestaña_Paint;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1064, 681);
            Controls.Add(FlpPestaña);
            Controls.Add(FlpSideBar);
            Controls.Add(PnlUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MinimumSize = new Size(1080, 678);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion UTN";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            PnlUsuario.ResumeLayout(false);
            PnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            FlpSideBar.ResumeLayout(false);
            FlpSideBar.PerformLayout();
            PnlSubControlAlumnos.ResumeLayout(false);
            PnlSubControlCarreras.ResumeLayout(false);
            PnlSubControlMaterias.ResumeLayout(false);
            FlpPestaña.ResumeLayout(false);
            FlpPestaña.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlUsuario;
        private PictureBox picBoxLogo;
        private Label lblBienvenido;
        private Label lblFecha;
        private FlowLayoutPanel FlpSideBar;
        private Button BtnSideBarAlumnos;
        private Panel PnlSubControlAlumnos;
        private Button BtnListadoAlumnos;
        private Button BtnAltaAlumno;
        private Button BtnCarreras;
        private Panel PnlSubControlCarreras;
        private Button BtnListadoCarreras;
        private Button BtnAltaCarrera;
        private Button BtnMaterias;
        private Panel PnlSubControlMaterias;
        private Button BtnListadoMaterias;
        private Button BtnAltaMateria;
        private Label LblPestañaActual;
        private Button BtnCerrarPestañaActual;
        private FlowLayoutPanel FlpPestaña;
    }
}