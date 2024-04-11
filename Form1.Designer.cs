namespace ejercicioStatic
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
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.Celsius = new System.Windows.Forms.Label();
            this.Fahrenheit = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(734, 258);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(175, 71);
            this.btnFahrenheit.TabIndex = 0;
            this.btnFahrenheit.Text = "Convertir a Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(481, 258);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(170, 71);
            this.btnCelsius.TabIndex = 1;
            this.btnCelsius.Text = "Convertir a Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(793, 168);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(60, 20);
            this.Celsius.TabIndex = 2;
            this.Celsius.Text = "Celsius";
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(522, 168);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(86, 20);
            this.Fahrenheit.TabIndex = 3;
            this.Fahrenheit.Text = "Fahrenheit";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(481, 213);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(170, 26);
            this.txtFahrenheit.TabIndex = 4;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(734, 213);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(175, 26);
            this.txtCelsius.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 450);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.btnFahrenheit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Label Celsius;
        private System.Windows.Forms.Label Fahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
    }
}

