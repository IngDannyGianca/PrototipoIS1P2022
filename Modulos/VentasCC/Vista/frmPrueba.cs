using BitacoraUsuario;
using System;
using System.Data;
using System.Windows.Forms;
using static datosUsuario;
//Forma Creada por Ivania Gatica 0901-18-19528
namespace CapaVistaSeguridadHSC
{
    //0901-18-17144 Luis De la Cruz
    public partial class frmMantenimientoPerfil : Form
    {

        private string idaplicacion = "1";
        string usuario = "1";
        string permisos;




        public frmMantenimientoPerfil()
        {
            InitializeComponent();
            //Usuario
            TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
            navegador1.ObtenerCamposdeTabla(alias, "perfil", "hotelSanCarlos");
            navegador1.MetodoSalirVista(this);


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

            navegador1.ObtenerNombreDGV(this.dtgPerfiles);
            navegador1.LlenarTabla();
            navegador1.ObtenerReferenciaFormActual(this);
        }

        private string tabla = "perfil";

        //0901-18-19528 Ivania Gatica -- 0901-18-17144 Luis De la Cruz 

        public void actualizardatagriew()
        {
     
        }

        public void funLimpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            rbnHabilitado.Checked = false;
            rbnInhabilitado.Checked = false;
            txtEstatus.Text = "";
        }

        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.CambioEstadoTextbox(txtEstatus, rbnHabilitado, "A"); /*rbnActivo_CheckedChanged*/
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.CambioEstadoTextbox(txtEstatus, rbnInhabilitado, "I"); /*rbnInactivo_CheckedChanged*/
        }

        private void frmMantenimientoPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSet3.perfil' Puede moverla o quitarla según sea necesario.
            }
            catch (Exception Error)
            {
                Console.WriteLine("404", Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void perfilTabla_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //Ivania Gatica 0901-18-19528
        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
        //Luis de la Cruz 0901-18-17144
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {

            }
            else
            {
                //Jorge González 0901-18-3920
                Bitacora loggear = new Bitacora();
                loggear.guardarEnBitacora(IdUsuario, "1", "0004", "Error al modificar");
                //
                MessageBox.Show("Error debe de ingresar todos los valores solicitados ");
            }
            actualizardatagriew();
        }
        //Ivania Gatica 0901-18-19528
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }
        
        public void actualizarTablaDeporte()
        {
            try
            {
                //CapaVista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
            }
            catch (Exception Error)
            {
                Console.WriteLine("404 ", Error);
            }
        }
        //Ivania Gatica 0901-18-19528
        private void perfilTabla_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox1.Text = dtgPerfiles.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dtgPerfiles.CurrentRow.Cells[1].Value.ToString();
                txtEstatus.Text = dtgPerfiles.CurrentRow.Cells[2].Value.ToString();

                if (txtEstatus.Text == "A")
                {
                    rbnHabilitado.Checked = true;
                }
                else if (txtEstatus.Text == "I")
                {
                    rbnInhabilitado.Checked = true;
                }
            }
            catch
            {
            }
        }



        private void dtgPerfiles_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.SelecciondeFilaDGV(dtgPerfiles);
        }

        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {
            navegador1.ActivaRadiobtn(rbnHabilitado, rbnInhabilitado, txtEstatus); /*txtEstatus_TextChanged*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}