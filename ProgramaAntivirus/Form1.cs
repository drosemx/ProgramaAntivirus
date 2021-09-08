using System;
using System.Windows.Forms;
using ClaseMotorBusqueda;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                #region Ejecuta objeto de busqueda a partir de la seleccion del archivo. Instanciamos la clase motordebusqueda para crear un OBJETO
                      motordebusqueda objeto = new motordebusqueda();
                                int numvirus = objeto.BuscarArchivo(openFileDialog1.FileName);
                      if (numvirus > 0) label3.Text = "Resultado: Se han encontrado " + numvirus + " virus. ";
                #endregion
            }
            label3.Visible = true;
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //Cierra ventana principal, cierra aplicacion
             Close();
        }
        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra ventana con informacion general del sistema
            Form2 myform = new Form2();
            myform.Show();  
        }
        private void Form1_Load(object sender, EventArgs e) 
        {

        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }
    }
}
