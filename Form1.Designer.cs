
namespace Teste1
{
    partial class CALCULO_IMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PESO = new System.Windows.Forms.TextBox();
            this.ALTURA = new System.Windows.Forms.TextBox();
            this.GO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PESO
            // 
            this.PESO.Location = new System.Drawing.Point(228, 211);
            this.PESO.Name = "PESO";
            this.PESO.Size = new System.Drawing.Size(125, 27);
            this.PESO.TabIndex = 0;
            // 
            // ALTURA
            // 
            this.ALTURA.Location = new System.Drawing.Point(390, 211);
            this.ALTURA.Name = "ALTURA";
            this.ALTURA.Size = new System.Drawing.Size(125, 27);
            this.ALTURA.TabIndex = 1;
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(319, 260);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(94, 29);
            this.GO.TabIndex = 2;
            this.GO.Text = "Calcular";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(198, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calcule seu IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira aqui seu peso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insira aqui sua altura";
            // 
            // CALCULO_IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.ALTURA);
            this.Controls.Add(this.PESO);
            this.Name = "CALCULO_IMC";
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PESO;
        private System.Windows.Forms.TextBox ALTURA;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

