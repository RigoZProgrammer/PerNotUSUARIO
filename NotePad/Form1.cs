using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Agregamos esta biblioteca

namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //"cositas ya mas pro"
            Stream stm; //para los archivos?, flujo o corriente del archivo?
            OpenFileDialog ofd = new OpenFileDialog();//poo, voy a usar ese objeto para abrir, ofd es el nombre de la variable
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)//cargamos el cuadro de dialogo
            {
                if ((stm = ofd.OpenFile()) != null)//revisa que el nombre del archivo no esta vacio o nulo (que haya un nombre)
                {
                    string str = ofd.FileName;
                    string ftxt = File.ReadAllText(str);
                    richTextBox1.Text = ftxt;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guardar archivo
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de texto(*.txt)|*.xtxt|Archivo de C#(*.cs)|*.cs"; //aqui estamos poninendo los tipos de archivos disponibles a guardar(los que se despliegan para seleccionar el tipo)
            sfd.ShowDialog();//no entendi
            File.WriteAllText(sfd.FileName, richTextBox1.Text); //guarda en un archivo con el nombre especificado y lo que salga en el rich?
            MessageBox.Show("Archivo de texto guardado exitosamente.");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //lo mismo que close();
        }
    }
}