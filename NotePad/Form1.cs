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

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //el tipo de letra debe de estar en las maquinas donde se vaya a usar la app
            FontDialog dig = new FontDialog();//quiero crear una variable llamada dig
            if (dig.ShowDialog() == DialogResult.OK)
            {
                string fontName;
                float fontSize;
                fontName = dig.Font.Name; //tipo de letra es igual al de la variable 
                fontSize = dig.Font.Size;//tamaño de la letra es igual a lo que tengas en la varible
                richTextBox1.Font = dig.Font;//toma todas las fuentes de windows xD
            }
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void naranjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Orange;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Aqua;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void negroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Black;
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ZOOM +
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize += 2.0F;//aumenta el tamaño de letra?
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize, richTextBox1.Font.Style,
                richTextBox1.Font.Unit);//esta sustituyendo el tipo de fuente, no cambia nombre ni estilo por lo declarado entre parentesis, pero reajusta el tamaño de la letra

        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ZOOM -
            float currentSize;
            currentSize = richTextBox1.Font.Size;
            currentSize -= 2.0F;//aumenta el tamaño de letra?
            if (currentSize <= 2)//protege para que el programa no pete por reducir algun tamaño menor de la constante lol
            {
                currentSize = 2;
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize, richTextBox1.Font.Style,
                richTextBox1.Font.Unit); //lol, el mas por un menos
            }
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado pot Bruno Zamora 5°B");
        }
    }
}