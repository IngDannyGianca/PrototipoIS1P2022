using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;

namespace CapaVistaMVentasCC
{
    public partial class MDIVentas : Form
    {
        public MDIVentas()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuesto form1 = new frmPuesto();
            form1.MdiParent = this; 
            form1.Show();
        }

        private void morasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento form1 = new frmDepartamento();
            form1.MdiParent = this;
            form1.Show();
        }

        private void fraccionamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConcepto form1 = new frmConcepto();
            form1.MdiParent = this;
            form1.Show();
        }

        private void tipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void MDIVentas_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            { this.Close(); }
        }

		private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
		{

        }

		private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{

        }

		private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado form1 = new frmEmpleado();
            form1.MdiParent = this;
            form1.Show();
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNomina form1 = new frmNomina();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
