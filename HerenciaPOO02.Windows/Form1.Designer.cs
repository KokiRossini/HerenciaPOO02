
namespace HerenciaPOO02.Windows
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AudioLibroRadioButton = new System.Windows.Forms.RadioButton();
            this.LibroImpresoRadioButton = new System.Windows.Forms.RadioButton();
            this.CapturarDatosButton = new System.Windows.Forms.Button();
            this.MostrarDatosButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.PaginasTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.TituloTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AudioLibroRadioButton);
            this.groupBox1.Controls.Add(this.LibroImpresoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Publicacion";
            // 
            // AudioLibroRadioButton
            // 
            this.AudioLibroRadioButton.AutoSize = true;
            this.AudioLibroRadioButton.Location = new System.Drawing.Point(6, 48);
            this.AudioLibroRadioButton.Name = "AudioLibroRadioButton";
            this.AudioLibroRadioButton.Size = new System.Drawing.Size(84, 19);
            this.AudioLibroRadioButton.TabIndex = 0;
            this.AudioLibroRadioButton.Text = "AudioLibro";
            this.AudioLibroRadioButton.UseVisualStyleBackColor = true;
            // 
            // LibroImpresoRadioButton
            // 
            this.LibroImpresoRadioButton.AutoSize = true;
            this.LibroImpresoRadioButton.Checked = true;
            this.LibroImpresoRadioButton.Location = new System.Drawing.Point(7, 23);
            this.LibroImpresoRadioButton.Name = "LibroImpresoRadioButton";
            this.LibroImpresoRadioButton.Size = new System.Drawing.Size(98, 19);
            this.LibroImpresoRadioButton.TabIndex = 0;
            this.LibroImpresoRadioButton.TabStop = true;
            this.LibroImpresoRadioButton.Text = "Libro impreso";
            this.LibroImpresoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CapturarDatosButton
            // 
            this.CapturarDatosButton.Location = new System.Drawing.Point(215, 31);
            this.CapturarDatosButton.Name = "CapturarDatosButton";
            this.CapturarDatosButton.Size = new System.Drawing.Size(104, 27);
            this.CapturarDatosButton.TabIndex = 1;
            this.CapturarDatosButton.Text = "Capturar datos";
            this.CapturarDatosButton.UseVisualStyleBackColor = true;
            this.CapturarDatosButton.Click += new System.EventHandler(this.CapturarDatosButton_Click);
            // 
            // MostrarDatosButton
            // 
            this.MostrarDatosButton.Location = new System.Drawing.Point(215, 64);
            this.MostrarDatosButton.Name = "MostrarDatosButton";
            this.MostrarDatosButton.Size = new System.Drawing.Size(104, 27);
            this.MostrarDatosButton.TabIndex = 1;
            this.MostrarDatosButton.Text = "Mostrar datos";
            this.MostrarDatosButton.UseVisualStyleBackColor = true;
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(215, 97);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(104, 27);
            this.SalirButton.TabIndex = 1;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TiempoTextBox);
            this.groupBox2.Controls.Add(this.PaginasTextBox);
            this.groupBox2.Controls.Add(this.PrecioTextBox);
            this.groupBox2.Controls.Add(this.TituloTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 146);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la publicacion";
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.Location = new System.Drawing.Point(118, 111);
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.Size = new System.Drawing.Size(61, 23);
            this.TiempoTextBox.TabIndex = 1;
            // 
            // PaginasTextBox
            // 
            this.PaginasTextBox.Location = new System.Drawing.Point(97, 82);
            this.PaginasTextBox.Name = "PaginasTextBox";
            this.PaginasTextBox.Size = new System.Drawing.Size(61, 23);
            this.PaginasTextBox.TabIndex = 1;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Location = new System.Drawing.Point(56, 52);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(102, 23);
            this.PrecioTextBox.TabIndex = 1;
            // 
            // TituloTextBox
            // 
            this.TituloTextBox.Location = new System.Drawing.Point(54, 25);
            this.TituloTextBox.Name = "TituloTextBox";
            this.TituloTextBox.Size = new System.Drawing.Size(238, 23);
            this.TituloTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tiempo (Minutos):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Num. Paginas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.MostrarDatosButton);
            this.Controls.Add(this.CapturarDatosButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AudioLibroRadioButton;
        private System.Windows.Forms.RadioButton LibroImpresoRadioButton;
        private System.Windows.Forms.Button CapturarDatosButton;
        private System.Windows.Forms.Button MostrarDatosButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TiempoTextBox;
        private System.Windows.Forms.TextBox PaginasTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox TituloTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

