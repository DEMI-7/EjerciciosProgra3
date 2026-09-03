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
            dateTimePicker1 = new DateTimePicker();
            BtnConfirmar = new Button();
            LblCarrera = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Segoe UI", 15.75F);
            LblNombre.Location = new Point(312, 70);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(94, 30);
            LblNombre.TabIndex = 0;
            LblNombre.Text = "Nombre:";
            // 
            // LblApellido
            // 
            LblApellido.AutoSize = true;
            LblApellido.Font = new Font("Segoe UI", 15.75F);
            LblApellido.Location = new Point(312, 149);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(94, 30);
            LblApellido.TabIndex = 1;
            LblApellido.Text = "Apellido:";
            // 
            // LblFechaNacimiento
            // 
            LblFechaNacimiento.AutoSize = true;
            LblFechaNacimiento.Font = new Font("Segoe UI", 15.75F);
            LblFechaNacimiento.Location = new Point(192, 224);
            LblFechaNacimiento.Name = "LblFechaNacimiento";
            LblFechaNacimiento.Size = new Size(214, 30);
            LblFechaNacimiento.TabIndex = 2;
            LblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // LblMail
            // 
            LblMail.AutoSize = true;
            LblMail.Font = new Font("Segoe UI", 15.75F);
            LblMail.Location = new Point(330, 302);
            LblMail.Name = "LblMail";
            LblMail.Size = new Size(76, 30);
            LblMail.TabIndex = 3;
            LblMail.Text = "E-mail:";
            // 
            // LblTelefono
            // 
            LblTelefono.AutoSize = true;
            LblTelefono.Font = new Font("Segoe UI", 15.75F);
            LblTelefono.Location = new Point(200, 379);
            LblTelefono.Name = "LblTelefono";
            LblTelefono.Size = new Size(206, 30);
            LblTelefono.TabIndex = 4;
            LblTelefono.Text = "Numero de teléfono:";
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = Color.FromArgb(237, 242, 255);
            TxtNombre.BorderStyle = BorderStyle.FixedSingle;
            TxtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.Location = new Point(409, 68);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(325, 35);
            TxtNombre.TabIndex = 5;
            // 
            // TxtApellido
            // 
            TxtApellido.BackColor = Color.FromArgb(237, 242, 255);
            TxtApellido.BorderStyle = BorderStyle.FixedSingle;
            TxtApellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtApellido.Location = new Point(409, 147);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(325, 35);
            TxtApellido.TabIndex = 6;
            // 
            // TxtMail
            // 
            TxtMail.BackColor = Color.FromArgb(237, 242, 255);
            TxtMail.BorderStyle = BorderStyle.FixedSingle;
            TxtMail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMail.Location = new Point(409, 300);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(325, 35);
            TxtMail.TabIndex = 7;
            // 
            // TxtTelefono
            // 
            TxtTelefono.BackColor = Color.FromArgb(237, 242, 255);
            TxtTelefono.BorderStyle = BorderStyle.FixedSingle;
            TxtTelefono.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTelefono.Location = new Point(409, 377);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(325, 35);
            TxtTelefono.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(409, 230);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(325, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.BackColor = Color.FromArgb(0, 168, 232);
            BtnConfirmar.FlatAppearance.BorderColor = Color.Black;
            BtnConfirmar.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 198, 255);
            BtnConfirmar.FlatStyle = FlatStyle.Flat;
            BtnConfirmar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnConfirmar.Location = new Point(409, 564);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(325, 54);
            BtnConfirmar.TabIndex = 10;
            BtnConfirmar.Text = "CONFIRMAR";
            BtnConfirmar.UseVisualStyleBackColor = false;
            // 
            // LblCarrera
            // 
            LblCarrera.AutoSize = true;
            LblCarrera.Font = new Font("Segoe UI", 15.75F);
            LblCarrera.Location = new Point(321, 455);
            LblCarrera.Name = "LblCarrera";
            LblCarrera.Size = new Size(85, 30);
            LblCarrera.TabIndex = 11;
            LblCarrera.Text = "Carrera:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(409, 462);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(325, 23);
            comboBox1.TabIndex = 12;
            // 
            // FrmAltaAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1694, 814);
            Controls.Add(comboBox1);
            Controls.Add(LblCarrera);
            Controls.Add(BtnConfirmar);
            Controls.Add(dateTimePicker1);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtMail);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Controls.Add(LblTelefono);
            Controls.Add(LblMail);
            Controls.Add(LblFechaNacimiento);
            Controls.Add(LblApellido);
            Controls.Add(LblNombre);
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
        private DateTimePicker dateTimePicker1;
        private Button BtnConfirmar;
        private Label LblCarrera;
        private ComboBox comboBox1;
    }
}