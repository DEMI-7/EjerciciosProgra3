namespace PracticaWinForms
{
    partial class FrmAltaCarreras
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
            LblNombre = new Label();
            LblIdCarrera = new Label();
            LblMail = new Label();
            LblNivel = new Label();
            TxtNombre = new TextBox();
            TxtIdCarrera = new TextBox();
            TxtMail = new TextBox();
            TxtNivel = new TextBox();
            BtnBuscarNivel = new Button();
            SuspendLayout();
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Segoe UI", 15.75F);
            LblNombre.Location = new Point(291, 70);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(94, 30);
            LblNombre.TabIndex = 0;
            LblNombre.Text = "Nombre:";
            // 
            // LblIdCarrera
            // 
            LblIdCarrera.AutoSize = true;
            LblIdCarrera.Font = new Font("Segoe UI", 15.75F);
            LblIdCarrera.Location = new Point(346, 130);
            LblIdCarrera.Name = "LblIdCarrera";
            LblIdCarrera.Size = new Size(39, 30);
            LblIdCarrera.TabIndex = 1;
            LblIdCarrera.Text = "ID:";
            // 
            // LblMail
            // 
            LblMail.AutoSize = true;
            LblMail.Font = new Font("Segoe UI", 15.75F);
            LblMail.Location = new Point(309, 190);
            LblMail.Name = "LblMail";
            LblMail.Size = new Size(76, 30);
            LblMail.TabIndex = 2;
            LblMail.Text = "E-mail:";
            // 
            // LblNivel
            // 
            LblNivel.AutoSize = true;
            LblNivel.Font = new Font("Segoe UI", 15.75F);
            LblNivel.Location = new Point(320, 250);
            LblNivel.Name = "LblNivel";
            LblNivel.Size = new Size(65, 30);
            LblNivel.TabIndex = 3;
            LblNivel.Text = "Nivel:";
            // 
            // TxtNombre
            // 
            TxtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtNombre.BackColor = Color.FromArgb(237, 242, 255);
            TxtNombre.BorderStyle = BorderStyle.FixedSingle;
            TxtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.Location = new Point(391, 68);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(785, 35);
            TxtNombre.TabIndex = 6;
            // 
            // TxtIdCarrera
            // 
            TxtIdCarrera.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtIdCarrera.BackColor = Color.FromArgb(237, 242, 255);
            TxtIdCarrera.BorderStyle = BorderStyle.FixedSingle;
            TxtIdCarrera.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIdCarrera.Location = new Point(391, 128);
            TxtIdCarrera.Name = "TxtIdCarrera";
            TxtIdCarrera.Size = new Size(785, 35);
            TxtIdCarrera.TabIndex = 7;
            // 
            // TxtMail
            // 
            TxtMail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtMail.BackColor = Color.FromArgb(237, 242, 255);
            TxtMail.BorderStyle = BorderStyle.FixedSingle;
            TxtMail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMail.Location = new Point(391, 188);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(785, 35);
            TxtMail.TabIndex = 8;
            // 
            // TxtNivel
            // 
            TxtNivel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtNivel.BackColor = Color.FromArgb(237, 242, 255);
            TxtNivel.BorderStyle = BorderStyle.FixedSingle;
            TxtNivel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNivel.Location = new Point(391, 248);
            TxtNivel.Name = "TxtNivel";
            TxtNivel.ReadOnly = true;
            TxtNivel.Size = new Size(744, 35);
            TxtNivel.TabIndex = 9;
            TxtNivel.TabStop = false;
            // 
            // BtnBuscarNivel
            // 
            BtnBuscarNivel.BackColor = Color.White;
            BtnBuscarNivel.BackgroundImage = Properties.Resources.lupa;
            BtnBuscarNivel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBuscarNivel.FlatAppearance.BorderColor = Color.Black;
            BtnBuscarNivel.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnBuscarNivel.FlatStyle = FlatStyle.Flat;
            BtnBuscarNivel.Location = new Point(1141, 248);
            BtnBuscarNivel.Name = "BtnBuscarNivel";
            BtnBuscarNivel.Size = new Size(35, 35);
            BtnBuscarNivel.TabIndex = 10;
            BtnBuscarNivel.UseVisualStyleBackColor = false;
            // 
            // FrmAltaCarreras
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1694, 814);
            Controls.Add(BtnBuscarNivel);
            Controls.Add(TxtNivel);
            Controls.Add(TxtMail);
            Controls.Add(TxtIdCarrera);
            Controls.Add(TxtNombre);
            Controls.Add(LblNivel);
            Controls.Add(LblMail);
            Controls.Add(LblIdCarrera);
            Controls.Add(LblNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAltaCarreras";
            Text = "FrmAltaCarreras";
            Paint += FrmAltaCarreras_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNombre;
        private Label LblIdCarrera;
        private Label LblMail;
        private Label LblNivel;
        private TextBox TxtNombre;
        private TextBox TxtIdCarrera;
        private TextBox TxtMail;
        private TextBox TxtNivel;
        private Button BtnBuscarNivel;
    }
}