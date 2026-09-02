using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PracticaWinForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // mostrar la fecha actual
            // 1. mostrar la fecha en el formato "Martes 1 de septiembre" dddd nombre del dia d dia, MMMM mes
            string fechaTexto = DateTime.Now.ToString("dddd d 'de' MMMM");

            // 1. primer fecha del dia
            lblFecha.Text = char.ToUpper(fechaTexto[0]) + fechaTexto.Substring(1);
        }
    }
}
