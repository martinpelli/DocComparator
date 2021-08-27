using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practico1_Ejercicio6_TDI
{
    public partial class Form1 : Form
    {
        string pathDoc1 = "";
        string pathDoc2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void doc1TextBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathDoc1 = openFileDialog1.FileName;
                doc1TextBox.Text = pathDoc1;
            }
        }

        private void doc2TextBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pathDoc2 = openFileDialog2.FileName;
                doc2TextBox.Text = pathDoc2;
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[4];
            FileStream fileStreamDoc1 = new FileStream(pathDoc1, FileMode.Open, FileAccess.Read);
            FileInfo fileInfoDoc1 = new FileInfo(pathDoc1);
            FileInfo fileInfoDoc2 = new FileInfo(pathDoc2);
            fileStreamDoc1.Read(bytes, 0, 4);
            byte[] bytes2 = new byte[4];
            FileStream fileStreamDoc2 = new FileStream(pathDoc2, FileMode.Open, FileAccess.Read);
            fileStreamDoc2.Read(bytes2, 0, 4);
            string typeDoc1 = System.Text.Encoding.ASCII.GetString(bytes);
            string typeDoc2 = System.Text.Encoding.ASCII.GetString(bytes2);
            FileAttributes attributesDoc1 = File.GetAttributes(pathDoc1);
            FileAttributes attributesDoc2 = File.GetAttributes(pathDoc2);
            bool compressedDoc1 = false;
            bool compressedDoc2 = false;
            if ((attributesDoc1 & FileAttributes.Compressed) == FileAttributes.Compressed)
            {
                compressedDoc1 = true;
            }
            if ((attributesDoc2 & FileAttributes.Compressed) == FileAttributes.Compressed)
            {
                compressedDoc2 = true;
            }

            MessageBox.Show("Archivo 1:\n\tTipo: " + typeDoc1 + "\n\tComprimido: " + compressedDoc1 + "\n\tTamaño: "+ fileInfoDoc1.Length + "\nArchivo 2:\n\tTipo: " + typeDoc2 + "\n\tComprimido: " + compressedDoc2 + "\n\tTamaño: " + fileInfoDoc2.Length);
        }
    }
}
