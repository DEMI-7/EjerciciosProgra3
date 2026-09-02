namespace PracticaWinForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            // verificar base de datos
            if (txtNombre.Text == "admin" && txtContraseña.Text == "123")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtContraseña.Clear();
                txtNombre.Clear();
                txtNombre.Focus();
                MessageBox.Show("Contraseña incorrecta");
            }


        }

        private void checkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarContraseña.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
                picBoxOjito.Image = Properties.Resources.showPassOff;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                picBoxOjito.Image = Properties.Resources.showPassOn;
            }

        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            // comprobar tecla pulsada enter
            if (e.KeyCode == Keys.Enter)
            {
                // evitar sonido molesto de windows
                e.SuppressKeyPress = true;
                // cambiar foco a otro elemento de la ventana
                txtContraseña.Focus();
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            // comprobar tecla pulsada enter
            if (e.KeyCode == Keys.Enter)
            {
                // evitar sonido molesto de windows
                e.SuppressKeyPress = true;
                // cambiar foco a otro elemento de la ventana
                BtnIniciar.Focus();
            }
        }
    }
}
