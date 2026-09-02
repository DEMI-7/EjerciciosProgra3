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
            PnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // PnlUsuario
            // 
            PnlUsuario.BackColor = Color.FromArgb(39, 145, 230);
            PnlUsuario.BorderStyle = BorderStyle.FixedSingle;
            PnlUsuario.Controls.Add(lblFecha);
            PnlUsuario.Controls.Add(lblBienvenido);
            PnlUsuario.Controls.Add(picBoxLogo);
            PnlUsuario.Dock = DockStyle.Top;
            PnlUsuario.Location = new Point(0, 0);
            PnlUsuario.Name = "PnlUsuario";
            PnlUsuario.Size = new Size(1064, 143);
            PnlUsuario.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(794, 8);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(17, 25);
            lblFecha.TabIndex = 2;
            lblFecha.Text = ".";
            lblFecha.TextAlign = ContentAlignment.MiddleRight;
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
            // FrmPrincipal
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1064, 681);
            Controls.Add(PnlUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1080, 720);
            MinimumSize = new Size(1080, 720);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion UTN";
            Load += FrmPrincipal_Load;
            PnlUsuario.ResumeLayout(false);
            PnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlUsuario;
        private PictureBox picBoxLogo;
        private Label lblBienvenido;
        private Label lblFecha;
    }
}