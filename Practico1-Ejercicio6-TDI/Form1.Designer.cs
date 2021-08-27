
namespace Practico1_Ejercicio6_TDI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tittleLabel = new System.Windows.Forms.Label();
            this.doc1TextBox = new System.Windows.Forms.TextBox();
            this.doc2TextBox = new System.Windows.Forms.TextBox();
            this.doc1Label = new System.Windows.Forms.Label();
            this.doc2Label = new System.Windows.Forms.Label();
            this.compareButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLabel.Location = new System.Drawing.Point(78, 73);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(361, 31);
            this.tittleLabel.TabIndex = 0;
            this.tittleLabel.Text = "Comparador de Documentos";
            // 
            // doc1TextBox
            // 
            this.doc1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc1TextBox.Location = new System.Drawing.Point(45, 177);
            this.doc1TextBox.Name = "doc1TextBox";
            this.doc1TextBox.ReadOnly = true;
            this.doc1TextBox.Size = new System.Drawing.Size(432, 38);
            this.doc1TextBox.TabIndex = 1;
            this.doc1TextBox.Click += new System.EventHandler(this.doc1TextBox_Click);
            // 
            // doc2TextBox
            // 
            this.doc2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc2TextBox.Location = new System.Drawing.Point(45, 254);
            this.doc2TextBox.Name = "doc2TextBox";
            this.doc2TextBox.ReadOnly = true;
            this.doc2TextBox.Size = new System.Drawing.Size(432, 38);
            this.doc2TextBox.TabIndex = 2;
            this.doc2TextBox.Click += new System.EventHandler(this.doc2TextBox_Click);
            // 
            // doc1Label
            // 
            this.doc1Label.AutoSize = true;
            this.doc1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc1Label.Location = new System.Drawing.Point(42, 157);
            this.doc1Label.Name = "doc1Label";
            this.doc1Label.Size = new System.Drawing.Size(188, 17);
            this.doc1Label.TabIndex = 3;
            this.doc1Label.Text = "Ingrese el primer documento";
            // 
            // doc2Label
            // 
            this.doc2Label.AutoSize = true;
            this.doc2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc2Label.Location = new System.Drawing.Point(42, 234);
            this.doc2Label.Name = "doc2Label";
            this.doc2Label.Size = new System.Drawing.Size(203, 17);
            this.doc2Label.TabIndex = 4;
            this.doc2Label.Text = "Ingrese el segundo documento";
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(190, 343);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(125, 44);
            this.compareButton.TabIndex = 5;
            this.compareButton.Text = "Comparar";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 454);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.doc2Label);
            this.Controls.Add(this.doc1Label);
            this.Controls.Add(this.doc2TextBox);
            this.Controls.Add(this.doc1TextBox);
            this.Controls.Add(this.tittleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.TextBox doc1TextBox;
        private System.Windows.Forms.TextBox doc2TextBox;
        private System.Windows.Forms.Label doc1Label;
        private System.Windows.Forms.Label doc2Label;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

