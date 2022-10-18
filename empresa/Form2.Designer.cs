namespace FrontWinForms
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_ingreso = new System.Windows.Forms.DateTimePicker();
            this.txt_salario = new System.Windows.Forms.NumericUpDown();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_confir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_salario)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salario";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(97, 22);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 23);
            this.txt_dni.TabIndex = 8;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(97, 69);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 23);
            this.txt_nom.TabIndex = 9;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(97, 109);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 23);
            this.txt_direccion.TabIndex = 10;
            // 
            // txt_ingreso
            // 
            this.txt_ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ingreso.Location = new System.Drawing.Point(97, 162);
            this.txt_ingreso.Name = "txt_ingreso";
            this.txt_ingreso.Size = new System.Drawing.Size(100, 23);
            this.txt_ingreso.TabIndex = 11;
            // 
            // txt_salario
            // 
            this.txt_salario.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_salario.Location = new System.Drawing.Point(97, 213);
            this.txt_salario.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(100, 23);
            this.txt_salario.TabIndex = 12;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(122, 273);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_confir
            // 
            this.btn_confir.Location = new System.Drawing.Point(23, 273);
            this.btn_confir.Name = "btn_confir";
            this.btn_confir.Size = new System.Drawing.Size(75, 23);
            this.btn_confir.TabIndex = 16;
            this.btn_confir.Text = "Confirmar";
            this.btn_confir.UseVisualStyleBackColor = true;
            this.btn_confir.Click += new System.EventHandler(this.btn_confir_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 305);
            this.Controls.Add(this.btn_confir);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.txt_ingreso);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Text = "Agregar empledos";
            ((System.ComponentModel.ISupportInitialize)(this.txt_salario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_dni;
        private TextBox txt_nom;
        private TextBox txt_direccion;
        private DateTimePicker txt_ingreso;
        private NumericUpDown txt_salario;

        private Button btn_cerrar;
        private Button btn_confir;
    }
}