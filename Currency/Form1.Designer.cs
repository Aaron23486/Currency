namespace Currency
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMonedaOrigen = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.cmbMonedaDestino = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblMonedaDestino = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.White;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(355, 310);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(91, 25);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblMonedaOrigen
            // 
            this.lblMonedaOrigen.AutoSize = true;
            this.lblMonedaOrigen.BackColor = System.Drawing.Color.White;
            this.lblMonedaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedaOrigen.ForeColor = System.Drawing.Color.Black;
            this.lblMonedaOrigen.Location = new System.Drawing.Point(50, 77);
            this.lblMonedaOrigen.Name = "lblMonedaOrigen";
            this.lblMonedaOrigen.Size = new System.Drawing.Size(148, 25);
            this.lblMonedaOrigen.TabIndex = 1;
            this.lblMonedaOrigen.Text = "Moneda Origen";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(323, 350);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(161, 23);
            this.txtCantidad.TabIndex = 2;
            // 
            // cmbMonedaOrigen
            // 
            this.cmbMonedaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonedaOrigen.FormattingEnabled = true;
            this.cmbMonedaOrigen.Location = new System.Drawing.Point(225, 77);
            this.cmbMonedaOrigen.Name = "cmbMonedaOrigen";
            this.cmbMonedaOrigen.Size = new System.Drawing.Size(171, 21);
            this.cmbMonedaOrigen.TabIndex = 3;
            this.cmbMonedaOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbMonedaOrigen_SelectedIndexChanged);
            // 
            // cmbMonedaDestino
            // 
            this.cmbMonedaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonedaDestino.FormattingEnabled = true;
            this.cmbMonedaDestino.Location = new System.Drawing.Point(225, 158);
            this.cmbMonedaDestino.Name = "cmbMonedaDestino";
            this.cmbMonedaDestino.Size = new System.Drawing.Size(171, 21);
            this.cmbMonedaDestino.TabIndex = 4;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(487, 168);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(104, 41);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblMonedaDestino
            // 
            this.lblMonedaDestino.AutoSize = true;
            this.lblMonedaDestino.BackColor = System.Drawing.Color.White;
            this.lblMonedaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedaDestino.ForeColor = System.Drawing.Color.Black;
            this.lblMonedaDestino.Location = new System.Drawing.Point(41, 158);
            this.lblMonedaDestino.Name = "lblMonedaDestino";
            this.lblMonedaDestino.Size = new System.Drawing.Size(155, 25);
            this.lblMonedaDestino.TabIndex = 6;
            this.lblMonedaDestino.Text = "Moneda Destino";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.White;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Location = new System.Drawing.Point(633, 310);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 25);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(599, 350);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(161, 23);
            this.txtResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMonedaDestino);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbMonedaDestino);
            this.Controls.Add(this.cmbMonedaOrigen);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblMonedaOrigen);
            this.Controls.Add(this.lblCantidad);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMonedaOrigen;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbMonedaOrigen;
        private System.Windows.Forms.ComboBox cmbMonedaDestino;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblMonedaDestino;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

