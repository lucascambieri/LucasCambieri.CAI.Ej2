namespace LucasCambieri.CAI.Ej2
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
            marcaComboBox = new ComboBox();
            marcaLabel = new Label();
            modeloLabel = new Label();
            añoLabel = new Label();
            precioLabel = new Label();
            AceptarBoton = new Button();
            CancelarBoton = new Button();
            modeloText = new TextBox();
            añoText = new TextBox();
            precioText = new TextBox();
            usuarioLabel = new Label();
            nombreRealLabel = new Label();
            fechaActualLabel = new Label();
            SuspendLayout();
            // 
            // marcaComboBox
            // 
            marcaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            marcaComboBox.FormattingEnabled = true;
            marcaComboBox.Location = new Point(12, 71);
            marcaComboBox.Name = "marcaComboBox";
            marcaComboBox.Size = new Size(121, 23);
            marcaComboBox.TabIndex = 0;
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new Point(12, 50);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new Size(40, 15);
            marcaLabel.TabIndex = 1;
            marcaLabel.Text = "Marca";
            marcaLabel.Click += marcaLabel_Click;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new Point(180, 50);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new Size(48, 15);
            modeloLabel.TabIndex = 3;
            modeloLabel.Text = "Modelo";
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new Point(320, 50);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new Size(29, 15);
            añoLabel.TabIndex = 5;
            añoLabel.Text = "Año";
            añoLabel.Click += label3_Click;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new Point(458, 50);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new Size(40, 15);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "Precio";
            precioLabel.UseWaitCursor = true;
            precioLabel.Click += label4_Click;
            // 
            // AceptarBoton
            // 
            AceptarBoton.Location = new Point(263, 143);
            AceptarBoton.Name = "AceptarBoton";
            AceptarBoton.Size = new Size(116, 37);
            AceptarBoton.TabIndex = 8;
            AceptarBoton.Text = "ACEPTAR";
            AceptarBoton.UseVisualStyleBackColor = true;
            AceptarBoton.Click += MarcaBoton_Click;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(452, 143);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(106, 37);
            CancelarBoton.TabIndex = 9;
            CancelarBoton.Text = "CANCELAR";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += BotonCancelar_Click;
            // 
            // modeloText
            // 
            modeloText.Location = new Point(180, 71);
            modeloText.Name = "modeloText";
            modeloText.Size = new Size(100, 23);
            modeloText.TabIndex = 10;
            // 
            // añoText
            // 
            añoText.Location = new Point(320, 71);
            añoText.Name = "añoText";
            añoText.Size = new Size(100, 23);
            añoText.TabIndex = 11;
            añoText.TextChanged += AñoTexto_TextChanged;
            // 
            // precioText
            // 
            precioText.Location = new Point(458, 71);
            precioText.Name = "precioText";
            precioText.Size = new Size(100, 23);
            precioText.TabIndex = 12;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new Point(14, 173);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(38, 15);
            usuarioLabel.TabIndex = 13;
            usuarioLabel.Text = "label1";
            // 
            // nombreRealLabel
            // 
            nombreRealLabel.AutoSize = true;
            nombreRealLabel.Location = new Point(95, 173);
            nombreRealLabel.Name = "nombreRealLabel";
            nombreRealLabel.Size = new Size(38, 15);
            nombreRealLabel.TabIndex = 14;
            nombreRealLabel.Text = "label1";
            // 
            // fechaActualLabel
            // 
            fechaActualLabel.ImageAlign = ContentAlignment.TopRight;
            fechaActualLabel.Location = new Point(331, 9);
            fechaActualLabel.Name = "fechaActualLabel";
            fechaActualLabel.Size = new Size(233, 15);
            fechaActualLabel.TabIndex = 15;
            fechaActualLabel.Text = "Fecha";
            fechaActualLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 197);
            Controls.Add(fechaActualLabel);
            Controls.Add(nombreRealLabel);
            Controls.Add(usuarioLabel);
            Controls.Add(precioText);
            Controls.Add(añoText);
            Controls.Add(modeloText);
            Controls.Add(CancelarBoton);
            Controls.Add(AceptarBoton);
            Controls.Add(precioLabel);
            Controls.Add(añoLabel);
            Controls.Add(modeloLabel);
            Controls.Add(marcaLabel);
            Controls.Add(marcaComboBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox marcaComboBox;
        private Label marcaLabel;
        private Label modeloLabel;
        private Label añoLabel;
        private Label precioLabel;
        private Button AceptarBoton;
        private Button CancelarBoton;
        private TextBox modeloText;
        private TextBox añoText;
        private TextBox precioText;
        private Label usuarioLabel;
        private Label nombreRealLabel;
        private Label fechaActualLabel;
    }
}