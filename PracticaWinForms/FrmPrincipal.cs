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


            // Ocultar Paneles subcontroles
            PnlSubControlAlumnos.Visible = false;
            PnlSubControlMaterias.Visible = false;
            PnlSubControlCarreras.Visible = false;

            // Ocultar pestaña
            FlpPestaña.Visible = false;

            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    //c.BackColor = Color.FromArgb(255,255,255);
                    c.BackColor = ColorTranslator.FromHtml("#ffffff");
                    break;
                }
            }

            FlpSideBar.BackColor = ColorTranslator.FromHtml("#0077b6");
            PnlUsuario.BackColor = ColorTranslator.FromHtml("#0077b6");

        }

        private void BtnSideBarAlumnos_Click(object sender, EventArgs e)
        {
            bool esVisible = PnlSubControlAlumnos.Visible;

            PnlSubControlMaterias.Visible = false;
            PnlSubControlCarreras.Visible = false;

            PnlSubControlAlumnos.Visible = !esVisible;
        }

        private void BtnCarreras_Click(object sender, EventArgs e)
        {
            bool esVisible = PnlSubControlCarreras.Visible;

            PnlSubControlAlumnos.Visible = false;
            PnlSubControlMaterias.Visible = false;

            PnlSubControlCarreras.Visible = !esVisible;
        }

        private void BtnMaterias_Click(object sender, EventArgs e)
        {
            bool esVisible = PnlSubControlMaterias.Visible;

            PnlSubControlAlumnos.Visible = false;
            PnlSubControlCarreras.Visible = false;

            PnlSubControlMaterias.Visible = !esVisible;
        }

        private void BtnAltaAlumno_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmAltaAlumnos))
                {
                    return;
                }
            }
            CerrarFormulariosHijos();

            FrmAltaAlumnos ventana = new FrmAltaAlumnos();
            ventana.MdiParent = this;
            ventana.StartPosition = FormStartPosition.Manual;

            int margenX = 30;
            int margenY = (int)(FlpPestaña.Bounds.Height * 1.4f);

            int anchoContenedor = this.ClientSize.Width - this.FlpSideBar.Width;
            int altoContenedor = this.ClientSize.Height - this.PnlUsuario.Height;

            int anchoHijo = anchoContenedor - (margenX * 2);
            int altoHijo = altoContenedor - (int)(margenY*1.5);

            ventana.Location = new Point(margenX, margenY);
            ventana.Size = new Size(anchoHijo, altoHijo);

            ventana.Show();
            LblPestañaActual.Text = "Alta alumno";
            FlpPestaña.Visible = true;
            
        }

        private void CerrarFormulariosHijos()
        {
            // borrara formularios que sean hijos para solo permitir que exista el que abramos ultimo
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }

        private void BtnCerrarPestañaActual_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();
            FlpPestaña.Visible = false;
        }

        private void BtnListadoAlumnos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmListadoAlumnos))
                {
                    return;
                }
            }
            CerrarFormulariosHijos();

            FrmListadoAlumnos ventana = new FrmListadoAlumnos();
            ventana.MdiParent = this;
            ventana.StartPosition = FormStartPosition.Manual;

            int margen = 30;
            ventana.Location = new Point(margen, margen + 10);

            int anchoContenedor = this.ClientSize.Width - this.FlpSideBar.Width;
            int altoContenedor = this.ClientSize.Height - this.PnlUsuario.Height;

            ventana.Size = new Size(anchoContenedor - (margen * 2), altoContenedor - (margen * 2));

            ventana.Show();
            LblPestañaActual.Text = "Listado alumnos";
            FlpPestaña.Visible = true;
            
        }

        private void BtnAltaCarrera_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmAltaCarreras))
                {
                    return;
                }
            }
            CerrarFormulariosHijos();

            FrmAltaCarreras ventana = new FrmAltaCarreras();
            ventana.MdiParent = this;
            ventana.StartPosition = FormStartPosition.Manual;

            int margen = 30;
            ventana.Location = new Point(margen, margen + 10);

            int anchoContenedor = this.ClientSize.Width - this.FlpSideBar.Width;
            int altoContenedor = this.ClientSize.Height - this.PnlUsuario.Height;

            ventana.Size = new Size(anchoContenedor - (margen * 2), altoContenedor - (margen * 2));

            ventana.Show();
            LblPestañaActual.Text = "Alta carreras";
            FlpPestaña.Visible = true;

        }

        private void BtnListadoCarreras_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmListadoCarreras))
                {
                    return;
                }
            }
            CerrarFormulariosHijos();

            FrmListadoCarreras ventana = new FrmListadoCarreras();
            ventana.MdiParent = this;
            ventana.StartPosition = FormStartPosition.Manual;

            int margen = 30;
            ventana.Location = new Point(margen, margen + 10);

            int anchoContenedor = this.ClientSize.Width - this.FlpSideBar.Width;
            int altoContenedor = this.ClientSize.Height - this.PnlUsuario.Height;

            ventana.Size = new Size(anchoContenedor - (margen * 2), altoContenedor - (margen * 2));

            ventana.Show();
            LblPestañaActual.Text = "Listado carrera";
            FlpPestaña.Visible = true;
            
        }

        private void BtnAltaMateria_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmAltaMaterias))
                {
                    return;
                }
            }
            CerrarFormulariosHijos();

            FrmAltaMaterias ventana = new FrmAltaMaterias();
            ventana.MdiParent = this;
            ventana.StartPosition = FormStartPosition.Manual;

            int margen = 30;
            ventana.Location = new Point(margen, margen + 10);

            int anchoContenedor = this.ClientSize.Width - this.FlpSideBar.Width;
            int altoContenedor = this.ClientSize.Height - this.PnlUsuario.Height;

            ventana.Size = new Size(anchoContenedor - (margen * 2), altoContenedor - (margen * 2));

            ventana.Show();
            LblPestañaActual.Text = "Alta materia";
            FlpPestaña.Visible = true;
            
        }

        private void BtnListadoMaterias_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmListadoMaterias))
                {
                    return;
                }
            }
            CerrarFormulariosHijos();

            FrmListadoMaterias ventana = new FrmListadoMaterias();
            ventana.MdiParent = this;
            ventana.StartPosition = FormStartPosition.Manual;

            int margen = 30;
            ventana.Location = new Point(margen, margen + 10);

            int anchoContenedor = this.ClientSize.Width - this.FlpSideBar.Width;
            int altoContenedor = this.ClientSize.Height - this.PnlUsuario.Height;

            ventana.Size = new Size(anchoContenedor - (margen * 2), altoContenedor - (margen * 2));

            ventana.Show();
            LblPestañaActual.Text = "Listado materias";
            FlpPestaña.Visible = true;
            
        }

        private void FlpPestaña_Paint(object sender, PaintEventArgs e)
        {
            // Color del borde que prefieras (por ejemplo, el mismo azul o un gris fino)
            Color colorBorde = ColorTranslator.FromHtml("#051923");

            using (Pen lapiz = new Pen(colorBorde, 1))
            {
                // Se resta 1 al ancho y alto para que no se corte en los bordes del control
                Rectangle limite = new Rectangle(0, 0, FlpPestaña.Width - 1, FlpPestaña.Height - 1);
                e.Graphics.DrawRectangle(lapiz, limite);
            }
        }
    }
}
