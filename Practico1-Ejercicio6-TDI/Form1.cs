using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1_Ejercicio6_TDI
{
    public partial class Form1 : Form
    {
        string pathDoc1;
        string pathDoc2;
        public Form1()
        {
            InitializeComponent();
        }

        private void doc1TextBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathDoc1 = openFileDialog1.FileName;
            }
        }

        private void doc2TextBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pathDoc2 = openFileDialog2.FileName;
            }
        }
        
    }
}
