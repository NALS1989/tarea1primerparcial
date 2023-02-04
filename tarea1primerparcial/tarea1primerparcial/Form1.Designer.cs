namespace tarea1primerparcial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcularbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imparoparlabel2 = new System.Windows.Forms.Label();
            this.numerotextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcularbutton1
            // 
            this.calcularbutton1.Location = new System.Drawing.Point(314, 198);
            this.calcularbutton1.Name = "calcularbutton1";
            this.calcularbutton1.Size = new System.Drawing.Size(174, 62);
            this.calcularbutton1.TabIndex = 0;
            this.calcularbutton1.Text = "CALCULAR";
            this.calcularbutton1.UseVisualStyleBackColor = true;
            this.calcularbutton1.Click += new System.EventHandler(this.calcularbutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESE NUMERO";
            // 
            // imparoparlabel2
            // 
            this.imparoparlabel2.AutoSize = true;
            this.imparoparlabel2.Location = new System.Drawing.Point(375, 145);
            this.imparoparlabel2.Name = "imparoparlabel2";
            this.imparoparlabel2.Size = new System.Drawing.Size(44, 16);
            this.imparoparlabel2.TabIndex = 2;
            this.imparoparlabel2.Text = "label2";
            // 
            // numerotextBox1
            // 
            this.numerotextBox1.Location = new System.Drawing.Point(352, 103);
            this.numerotextBox1.Name = "numerotextBox1";
            this.numerotextBox1.Size = new System.Drawing.Size(95, 22);
            this.numerotextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Evalua True (Par) False ( Impar)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numerotextBox1);
            this.Controls.Add(this.imparoparlabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imparoparlabel2;
        private System.Windows.Forms.TextBox numerotextBox1;
        private System.Windows.Forms.Label label2;
    }
}