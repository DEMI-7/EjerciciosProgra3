using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PracticaWinForms
{
    public partial class FrmListadoAlumnos : Form
    {
        public FrmListadoAlumnos()
        {
            InitializeComponent();
        }

        private void FrmListadoAlumnos_Paint(object sender, PaintEventArgs e)
        {
            // 1. Definimos el color del borde
            Color colorBorde = ColorTranslator.FromHtml("#051923");

            // 2. Grosor de la línea en píxeles (1px para una línea sencilla)
            int grosor = 1;

            using (Pen lapiz = new Pen(colorBorde, grosor))
            {
                // Restamos 1 pixel al ancho y alto para que la línea se dibuje 
                // exactamente dentro de los límites visibles del formulario
                Rectangle limite = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);

                e.Graphics.DrawRectangle(lapiz, limite);
            }
        }
    }
}
