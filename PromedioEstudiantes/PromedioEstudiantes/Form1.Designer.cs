
namespace PromedioEstudiantes
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLab1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLab2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLab3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParcial1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtParcial2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtParcial3 = new System.Windows.Forms.TextBox();
            this.txtCalcular = new System.Windows.Forms.Button();
            this.txtVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(28, 123);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(31, 182);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(100, 20);
            this.TxtMateria.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de la Materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota Lab1";
            // 
            // txtLab1
            // 
            this.txtLab1.Location = new System.Drawing.Point(233, 79);
            this.txtLab1.Name = "txtLab1";
            this.txtLab1.Size = new System.Drawing.Size(100, 20);
            this.txtLab1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota Lab2";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLab2
            // 
            this.txtLab2.Location = new System.Drawing.Point(233, 123);
            this.txtLab2.Name = "txtLab2";
            this.txtLab2.Size = new System.Drawing.Size(100, 20);
            this.txtLab2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nota Lab3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notas de Laboratorios";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtLab3
            // 
            this.txtLab3.Location = new System.Drawing.Point(233, 177);
            this.txtLab3.Name = "txtLab3";
            this.txtLab3.Size = new System.Drawing.Size(100, 20);
            this.txtLab3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Parcial1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Notas de Parciales";
            // 
            // txtParcial1
            // 
            this.txtParcial1.Location = new System.Drawing.Point(418, 79);
            this.txtParcial1.Name = "txtParcial1";
            this.txtParcial1.Size = new System.Drawing.Size(100, 20);
            this.txtParcial1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Parcial2";
            // 
            // txtParcial2
            // 
            this.txtParcial2.Location = new System.Drawing.Point(425, 123);
            this.txtParcial2.Name = "txtParcial2";
            this.txtParcial2.Size = new System.Drawing.Size(100, 20);
            this.txtParcial2.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Parcial3";
            // 
            // txtParcial3
            // 
            this.txtParcial3.Location = new System.Drawing.Point(425, 177);
            this.txtParcial3.Name = "txtParcial3";
            this.txtParcial3.Size = new System.Drawing.Size(100, 20);
            this.txtParcial3.TabIndex = 19;
            // 
            // txtCalcular
            // 
            this.txtCalcular.Location = new System.Drawing.Point(474, 273);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(104, 45);
            this.txtCalcular.TabIndex = 20;
            this.txtCalcular.Text = "Calcular";
            this.txtCalcular.UseVisualStyleBackColor = true;
            this.txtCalcular.Click += new System.EventHandler(this.txtCalcular_Click);
            // 
            // txtVaciar
            // 
            this.txtVaciar.Location = new System.Drawing.Point(624, 273);
            this.txtVaciar.Name = "txtVaciar";
            this.txtVaciar.Size = new System.Drawing.Size(101, 45);
            this.txtVaciar.TabIndex = 21;
            this.txtVaciar.Text = "Vaciar";
            this.txtVaciar.UseVisualStyleBackColor = true;
            this.txtVaciar.Click += new System.EventHandler(this.txtVaciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVaciar);
            this.Controls.Add(this.txtCalcular);
            this.Controls.Add(this.txtParcial3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtParcial2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtParcial1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLab3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLab2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLab1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "tex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLab1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLab2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLab3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtParcial1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtParcial2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtParcial3;
        private System.Windows.Forms.Button txtCalcular;
        private System.Windows.Forms.Button txtVaciar;
    }
}

