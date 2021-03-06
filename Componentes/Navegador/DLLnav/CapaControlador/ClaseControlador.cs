using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;
using CapaModeloNav;
using System.Collections;
namespace CapaControlador
{
    public class ClaseControlador
    {
        string errores = "";
        TextBox[] texts;
        Control control;

        ClaseModeloSegunda ModeloSegunda = new ClaseModeloSegunda();
        ClaseModeloTercera ModeloTercera = new ClaseModeloTercera();

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public TextBox[] ordenandoTextos(Control parent)
        {
            texts = ModeloTercera.AsignaAlias(parent);
            control = parent;
            TextBox[] alias = new TextBox[texts.Length];

            int j = 0;
            for (int i = (texts.Length - 1); i >= 0; i--)
            {
                alias[j] = texts[i];
                j++;
            }

            return alias;
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void comparaTagscampoBD(TextBox[] alias, string tabla, string BD)
        {
            errores = ModeloTercera.comparaTagscampoBD(alias, tabla, BD);
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void funAsignarSalidadControl(Form menu)
        {
            if (String.IsNullOrEmpty(errores))
            {
                ModeloSegunda.metodoSalir(menu);
                ModeloSegunda.metodoDeshabilitarTexts(control);
            }
            else
            {
                MessageBox.Show(errores);
                menu.Close();
            }
        }

        /*2*/
        public int idSiguienteDeNuevoIngreso(string tabla)
        {
            int longitud = texts.Length;
            int entero = ModeloTercera.idSiguienteDeNuevoIngreso(tabla, texts[longitud - 1].Tag.ToString());

            return entero;
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void metodoLlenarCombo(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            ModeloSegunda.metodoLlenarCombo(cbx,tabla,value, display, estatus);
        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void SeleccionDeFilaDGV(DataGridView data)
        {
            ModeloTercera.SeleccionDeFilaDGV(data);
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void activaRadiobtn(RadioButton activo, RadioButton inactivo, TextBox estatus)
        {
            ModeloSegunda.metodoActivaRadiobtn(activo, inactivo, estatus); 
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void CambioEstadoTextBox(TextBox estado, RadioButton AI, string cadenaEstado)
        {
            ModeloTercera.CambioEstadoTextBox(estado, AI, cadenaEstado);
        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void enviarDatoCbxaTextbox(ComboBox combo, TextBox combotexto)
        {
            ModeloSegunda.metodoEnviarDatoCbxaTextbox(combo, combotexto); 

        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public void SeleccionarElementoEnComboBox(ComboBox combo, TextBox combotexto)
        {
            ModeloTercera.SeleccionarElementoEnComboBox(combo, combotexto);
        }

        /*Jorge Lizandro Castañeda Choy - 9959-18-4964*/
        public void CambiarFormatoFecha(DateTimePicker date, TextBox textoDate)
        {
            ModeloSegunda.metodoCambiarFormatoFecha(date,textoDate); 

        }

        /*Josue Daniel Zapata Azañon - 9959-18-4829*/
        public void SeleccionarFechaDTP(DateTimePicker date, TextBox textoDate)
        {
            ModeloTercera.SeleccionarFechaDTP(date, textoDate);
        }

        /*Wilmer Alexander Torres Lemus - 9959-18-9131*/
        public string obtieneRutaReporte(string idAplicacion, string campoRuta, string campoB, string tablaR)
        {
            string ruta = ModeloSegunda.obtieneRutaReporte(idAplicacion, campoRuta, campoB, tablaR);
            return ruta;
        }


        

        public DataTable ActualizarDGV(string tablaDB)//Jaime López 0901-18-735
        {
            //cambiado 18/10/2021-01:30pm, todo el odbc se paso a realizar solo en la modelo
            //para aumentar la seguridad
            return ModeloTercera.ActualizarDGV(tablaDB);
        }
        public bool modificar(TextBox[] campos, string tablas)//Modificar de Wilber Enrique Segura Ramirez 0901-18-13952
        {
          return ModeloTercera.Modificar(campos, tablas); 
        }

        /*1*/
        public bool insertarDatostabla(TextBox[] campos, string tablas)
        {
            return ModeloSegunda.metodoInsertarDatosTabla(campos, tablas);
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        public void InhabilitarRegistro(TextBox[] arreglo, string tabla, string campoEstado)
        {
            ModeloSegunda.metodoInhabilitarRegistro(arreglo, tabla, campoEstado);
        }

        /*Geovani Fernando Mendoza - 9959-18-15407*/
        public void LlamadaAyudas(string idAplicacion, string nombreCampo, string tablaA)
        {
            ModeloTercera.LlamadaAyudas(idAplicacion, nombreCampo, tablaA, control);

            //MessageBox.Show(tablaA);

        }

        /*Liam Patrick Bernard García - 0901-18-10092*/
        public string funObtienePermisos(string idUsuario, string idAplicacion)
        {
            CapaModeloSeguridadHSC.llamarPermisos modeloSeguridad = new CapaModeloSeguridadHSC.llamarPermisos();
            return modeloSeguridad.llenarpermisos(idUsuario, idAplicacion);
        }

    }

}
