namespace Mi_Formulario
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
            miNombre = new Label();
            textDNI = new TextBox();
            miApellido = new Label();
            miDNI = new Label();
            Aceptar = new Button();
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            lblMiNombreCompleto = new Label();
            lblApellidoNombre = new Label();
            SuspendLayout();
            // 
            // miNombre
            // 
            miNombre.AutoSize = true;
            miNombre.Location = new Point(32, 34);
            miNombre.Name = "miNombre";
            miNombre.Size = new Size(57, 15);
            miNombre.TabIndex = 0;
            miNombre.Text = "Nombre :";
            // 
            // textDNI
            // 
            textDNI.Location = new Point(102, 99);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(100, 23);
            textDNI.TabIndex = 4;
            // 
            // miApellido
            // 
            miApellido.AutoSize = true;
            miApellido.Location = new Point(32, 71);
            miApellido.Name = "miApellido";
            miApellido.Size = new Size(57, 15);
            miApellido.TabIndex = 5;
            miApellido.Text = "Apellido :";
            // 
            // miDNI
            // 
            miDNI.AutoSize = true;
            miDNI.Location = new Point(50, 101);
            miDNI.Name = "miDNI";
            miDNI.Size = new Size(33, 15);
            miDNI.TabIndex = 6;
            miDNI.Text = "DNI :";
            miDNI.Click += label2_Click;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(590, 276);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 7;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(102, 31);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 8;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(102, 68);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(100, 23);
            txbApellido.TabIndex = 9;
            // 
            // lblMiNombreCompleto
            // 
            lblMiNombreCompleto.AutoSize = true;
            lblMiNombreCompleto.Location = new Point(32, 153);
            lblMiNombreCompleto.Name = "lblMiNombreCompleto";
            lblMiNombreCompleto.Size = new Size(113, 15);
            lblMiNombreCompleto.TabIndex = 10;
            lblMiNombreCompleto.Text = "Nombre Completo :";
            // 
            // lblApellidoNombre
            // 
            lblApellidoNombre.AutoSize = true;
            lblApellidoNombre.Location = new Point(173, 153);
            lblApellidoNombre.Name = "lblApellidoNombre";
            lblApellidoNombre.Size = new Size(177, 15);
            lblApellidoNombre.TabIndex = 11;
            lblApellidoNombre.Text = "Aqui va a ir el nombre completo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 450);
            Controls.Add(lblApellidoNombre);
            Controls.Add(lblMiNombreCompleto);
            Controls.Add(txbApellido);
            Controls.Add(txbNombre);
            Controls.Add(Aceptar);
            Controls.Add(miDNI);
            Controls.Add(miApellido);
            Controls.Add(textDNI);
            Controls.Add(miNombre);
            Name = "Form1";
            Text = "Datos De Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label miNombre;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textDNI;
        private Label miApellido;
        private Label miDNI;
        private Button Aceptar;
        private TextBox txbNombre;
        private TextBox txbApellido;
        private Label lblMiNombreCompleto;
        private Label lblApellidoNombre;
    }
}