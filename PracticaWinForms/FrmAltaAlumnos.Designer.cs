namespace PracticaWinForms
{
    partial class FrmAltaAlumnos
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
            LblApellido = new Label();
            LblFechaNacimiento = new Label();
            LblMail = new Label();
            LblTelefono = new Label();
            TxtNombre = new TextBox();
            TxtApellido = new TextBox();
            TxtMail = new TextBox();
            TxtTelefono = new TextBox();
            DtmFechaNacimiento = new DateTimePicker();
            BtnConfirmar = new Button();
            LblCarrera = new Label();
            TxtCarrera = new TextBox();
            BtnBusquedaCarreras = new Button();
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
            // LblApellido
            // 
            LblApellido.AutoSize = true;
            LblApellido.Font = new Font("Segoe UI", 15.75F);
            LblApellido.Location = new Point(291, 250);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(94, 30);
            LblApellido.TabIndex = 1;
            LblApellido.Text = "Apellido:";
            // 
            // LblFechaNacimiento
            // 
            LblFechaNacimiento.AutoSize = true;
            LblFechaNacimiento.Font = new Font("Segoe UI", 15.75F);
            LblFechaNacimiento.Location = new Point(171, 130);
            LblFechaNacimiento.Name = "LblFechaNacimiento";
            LblFechaNacimiento.Size = new Size(214, 30);
            LblFechaNacimiento.TabIndex = 2;
            LblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // LblMail
            // 
            LblMail.AutoSize = true;
            LblMail.Font = new Font("Segoe UI", 15.75F);
            LblMail.Location = new Point(309, 190);
            LblMail.Name = "LblMail";
            LblMail.Size = new Size(76, 30);
            LblMail.TabIndex = 3;
            LblMail.Text = "E-mail:";
            // 
            // LblTelefono
            // 
            LblTelefono.AutoSize = true;
            LblTelefono.Font = new Font("Segoe UI", 15.75F);
            LblTelefono.Location = new Point(179, 310);
            LblTelefono.Name = "LblTelefono";
            LblTelefono.Size = new Size(206, 30);
            LblTelefono.TabIndex = 4;
            LblTelefono.Text = "Numero de teléfono:";
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
            TxtNombre.TabIndex = 5;
            // 
            // TxtApellido
            // 
            TxtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtApellido.BackColor = Color.FromArgb(237, 242, 255);
            TxtApellido.BorderStyle = BorderStyle.FixedSingle;
            TxtApellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtApellido.Location = new Point(391, 248);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(785, 35);
            TxtApellido.TabIndex = 6;
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
            TxtMail.TabIndex = 7;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtTelefono.BackColor = Color.FromArgb(237, 242, 255);
            TxtTelefono.BorderStyle = BorderStyle.FixedSingle;
            TxtTelefono.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTelefono.Location = new Point(391, 308);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(785, 35);
            TxtTelefono.TabIndex = 8;
            // 
            // DtmFechaNacimiento
            // 
            DtmFechaNacimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DtmFechaNacimiento.Location = new Point(391, 137);
            DtmFechaNacimiento.MaxDate = new DateTime(2026, 9, 3, 0, 0, 0, 0);
            DtmFechaNacimiento.Name = "DtmFechaNacimiento";
            DtmFechaNacimiento.Size = new Size(266, 23);
            DtmFechaNacimiento.TabIndex = 9;
            DtmFechaNacimiento.Value = new DateTime(2026, 9, 3, 0, 0, 0, 0);
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.BackColor = Color.FromArgb(0, 168, 232);
            BtnConfirmar.FlatAppearance.BorderColor = Color.Black;
            BtnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 198, 255);
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmar.Location = new Point(626, 430);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(325, 60);
            BtnConfirmar.TabIndex = 10;
            BtnConfirmar.Text = "CONFIRMAR";
            BtnConfirmar.UseVisualStyleBackColor = false;
            // 
            // LblCarrera
            // 
            LblCarrera.AutoSize = true;
            LblCarrera.Font = new Font("Segoe UI", 15.75F);
            LblCarrera.Location = new Point(300, 370);
            LblCarrera.Name = "LblCarrera";
            LblCarrera.Size = new Size(85, 30);
            LblCarrera.TabIndex = 11;
            LblCarrera.Text = "Carrera:";
            // 
            // TxtCarrera
            // 
            TxtCarrera.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtCarrera.BackColor = Color.FromArgb(237, 242, 255);
            TxtCarrera.BorderStyle = BorderStyle.FixedSingle;
            TxtCarrera.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCarrera.Location = new Point(391, 368);
            TxtCarrera.Name = "TxtCarrera";
            TxtCarrera.ReadOnly = true;
            TxtCarrera.ShortcutsEnabled = false;
            TxtCarrera.Size = new Size(744, 35);
            TxtCarrera.TabIndex = 12;
            TxtCarrera.TabStop = false;
            // 
            // BtnBusquedaCarreras
            // 
            BtnBusquedaCarreras.BackColor = Color.White;
            BtnBusquedaCarreras.BackgroundImage = Properties.Resources.lupa;
            BtnBusquedaCarreras.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBusquedaCarreras.FlatAppearance.BorderColor = Color.Black;
            BtnBusquedaCarreras.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 242, 255);
            BtnBusquedaCarreras.FlatStyle = FlatStyle.Flat;
            BtnBusquedaCarreras.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBusquedaCarreras.Location = new Point(1141, 368);
            BtnBusquedaCarreras.Margin = new Padding(14, 3, 3, 0);
            BtnBusquedaCarreras.Name = "BtnBusquedaCarreras";
            BtnBusquedaCarreras.Size = new Size(35, 35);
            BtnBusquedaCarreras.TabIndex = 15;
            BtnBusquedaCarreras.UseVisualStyleBackColor = false;
            BtnBusquedaCarreras.Click += BtnBusquedaCarreras_Click;
            // 
            // FrmAltaAlumnos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1694, 814);
            Controls.Add(BtnBusquedaCarreras);
            Controls.Add(TxtCarrera);
            Controls.Add(TxtTelefono);
            Controls.Add(LblCarrera);
            Controls.Add(DtmFechaNacimiento);
            Controls.Add(BtnConfirmar);
            Controls.Add(TxtApellido);
            Controls.Add(LblFechaNacimiento);
            Controls.Add(TxtMail);
            Controls.Add(LblNombre);
            Controls.Add(TxtNombre);
            Controls.Add(LblApellido);
            Controls.Add(LblTelefono);
            Controls.Add(LblMail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAltaAlumnos";
            Text = "AltaAlumno";
            Paint += FrmAltaAlumnos_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNombre;
        private Label LblApellido;
        private Label LblFechaNacimiento;
        private Label LblMail;
        private Label LblTelefono;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private TextBox TxtMail;
        private TextBox TxtTelefono;
        private DateTimePicker DtmFechaNacimiento;
        private Button BtnConfirmar;
        private Label LblCarrera;
        private TextBox TxtCarrera;
        private Button BtnBusquedaCarreras;
    }
}