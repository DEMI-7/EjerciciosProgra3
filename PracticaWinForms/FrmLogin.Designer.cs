namespace PracticaWinForms
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            BtnIniciar = new Button();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            checkMostrarContraseña = new CheckBox();
            picBoxOjito = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxOjito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnIniciar
            // 
            BtnIniciar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIniciar.Location = new Point(362, 511);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(298, 84);
            BtnIniciar.TabIndex = 3;
            BtnIniciar.Text = "INICIAR";
            BtnIniciar.UseVisualStyleBackColor = true;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(439, 413);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 0;
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(439, 462);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(221, 23);
            txtContraseña.TabIndex = 1;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.KeyDown += txtContraseña_KeyDown;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(362, 416);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "USUARIO:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(335, 465);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(86, 15);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "CONTRASEÑA:";
            // 
            // checkMostrarContraseña
            // 
            checkMostrarContraseña.AutoSize = true;
            checkMostrarContraseña.Location = new Point(666, 465);
            checkMostrarContraseña.Name = "checkMostrarContraseña";
            checkMostrarContraseña.Size = new Size(15, 14);
            checkMostrarContraseña.TabIndex = 2;
            checkMostrarContraseña.UseVisualStyleBackColor = true;
            checkMostrarContraseña.CheckedChanged += checkMostrarContraseña_CheckedChanged;
            // 
            // picBoxOjito
            // 
            picBoxOjito.Image = Properties.Resources.showPassOn;
            picBoxOjito.Location = new Point(687, 459);
            picBoxOjito.Name = "picBoxOjito";
            picBoxOjito.Size = new Size(42, 26);
            picBoxOjito.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOjito.TabIndex = 7;
            picBoxOjito.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.UTN_logo;
            pictureBox2.Location = new Point(439, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1064, 681);
            Controls.Add(pictureBox2);
            Controls.Add(picBoxOjito);
            Controls.Add(checkMostrarContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(BtnIniciar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximumSize = new Size(1080, 720);
            MinimumSize = new Size(1080, 678);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UNIVERISDAD: Ejemplo";
            ((System.ComponentModel.ISupportInitialize)picBoxOjito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnIniciar;
        private TextBox txtNombre;
        private TextBox txtContraseña;
        private Label lblUsuario;
        private Label lblContraseña;
        private CheckBox checkMostrarContraseña;
        private PictureBox picBoxOjito;
        private PictureBox pictureBox2;
    }
}
