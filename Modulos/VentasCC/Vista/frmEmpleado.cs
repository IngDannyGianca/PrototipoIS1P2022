using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMVentasCC
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
            //Usuario
            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "empleadoM", "hotelSanCarlos");
            navegador1.MetodoSalirVista(this);
            navegador1.LlenarCombobox(comboBox1, "puestoM", "codigo_puesto", "nombre_puesto", "estatus_puesto");
            navegador1.LlenarCombobox(comboBox2, "departamentoM", "codigo_departamento", "nombre_departamento", "estatus_departamento");


            //inicio de elementos para dar de baja
            navegador1.campoEstado = "Estado";
            //fin de elementos para dar de baja

            /* Inicio ID Aplicacion usada para reportes y ayudas */
            navegador1.idAplicacion = "1002";
            /* Inicio ID Aplicacion usada para reportes y ayudas */

            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda


            // Inicio datos para ejecurar reportes
            navegador1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes

            navegador1.ObtenerNombreDGV(this.dataGridView1);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            navegador1.ActivaRadiobtn(rbnHabilitado, rbnInhabilitado, txtEstatus); /*txtEstatus_TextChanged*/
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.SelecciondeFilaDGV(dataGridView1);
        }

        private void rbnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnHabilitado.Checked == true)
            {
                txtEstatus.Text = "1";
            }
            else if (rbnHabilitado.Checked == false)
            {
                txtEstatus.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.EnviarDatoComboaTextbox(comboBox1, textBox3);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.EnviarDatoComboaTextbox(comboBox2, textBox4);
        }
    }
}
