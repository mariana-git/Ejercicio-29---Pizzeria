
namespace EjercicioPizzeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxTamaño = new System.Windows.Forms.GroupBox();
            this.rbtnFamiliar = new System.Windows.Forms.RadioButton();
            this.rbtnMediana = new System.Windows.Forms.RadioButton();
            this.rbtnGrande = new System.Windows.Forms.RadioButton();
            this.rbtnChica = new System.Windows.Forms.RadioButton();
            this.gbxExtras = new System.Windows.Forms.GroupBox();
            this.chkMorrones = new System.Windows.Forms.CheckBox();
            this.chkJamon = new System.Windows.Forms.CheckBox();
            this.chkAceitunas = new System.Windows.Forms.CheckBox();
            this.chkDobleQ = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.gbxTamaño.SuspendLayout();
            this.gbxExtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTamaño
            // 
            this.gbxTamaño.Controls.Add(this.rbtnFamiliar);
            this.gbxTamaño.Controls.Add(this.rbtnMediana);
            this.gbxTamaño.Controls.Add(this.rbtnGrande);
            this.gbxTamaño.Controls.Add(this.rbtnChica);
            this.gbxTamaño.Location = new System.Drawing.Point(50, 105);
            this.gbxTamaño.Name = "gbxTamaño";
            this.gbxTamaño.Size = new System.Drawing.Size(192, 77);
            this.gbxTamaño.TabIndex = 0;
            this.gbxTamaño.TabStop = false;
            this.gbxTamaño.Text = "Tamaño";
            // 
            // rbtnFamiliar
            // 
            this.rbtnFamiliar.AutoSize = true;
            this.rbtnFamiliar.Location = new System.Drawing.Point(114, 49);
            this.rbtnFamiliar.Name = "rbtnFamiliar";
            this.rbtnFamiliar.Size = new System.Drawing.Size(67, 19);
            this.rbtnFamiliar.TabIndex = 3;
            this.rbtnFamiliar.Text = "Familiar";
            this.rbtnFamiliar.UseVisualStyleBackColor = true;
            // 
            // rbtnMediana
            // 
            this.rbtnMediana.AutoSize = true;
            this.rbtnMediana.Location = new System.Drawing.Point(114, 23);
            this.rbtnMediana.Name = "rbtnMediana";
            this.rbtnMediana.Size = new System.Drawing.Size(71, 19);
            this.rbtnMediana.TabIndex = 2;
            this.rbtnMediana.Text = "Mediana";
            this.rbtnMediana.UseVisualStyleBackColor = true;
            // 
            // rbtnGrande
            // 
            this.rbtnGrande.AutoSize = true;
            this.rbtnGrande.Location = new System.Drawing.Point(7, 49);
            this.rbtnGrande.Name = "rbtnGrande";
            this.rbtnGrande.Size = new System.Drawing.Size(63, 19);
            this.rbtnGrande.TabIndex = 1;
            this.rbtnGrande.Text = "Grande";
            this.rbtnGrande.UseVisualStyleBackColor = true;
            // 
            // rbtnChica
            // 
            this.rbtnChica.AutoSize = true;
            this.rbtnChica.Location = new System.Drawing.Point(7, 23);
            this.rbtnChica.Name = "rbtnChica";
            this.rbtnChica.Size = new System.Drawing.Size(55, 19);
            this.rbtnChica.TabIndex = 0;
            this.rbtnChica.Text = "Chica";
            this.rbtnChica.UseVisualStyleBackColor = true;
            // 
            // gbxExtras
            // 
            this.gbxExtras.Controls.Add(this.chkMorrones);
            this.gbxExtras.Controls.Add(this.chkJamon);
            this.gbxExtras.Controls.Add(this.chkAceitunas);
            this.gbxExtras.Controls.Add(this.chkDobleQ);
            this.gbxExtras.Location = new System.Drawing.Point(50, 212);
            this.gbxExtras.Name = "gbxExtras";
            this.gbxExtras.Size = new System.Drawing.Size(194, 80);
            this.gbxExtras.TabIndex = 1;
            this.gbxExtras.TabStop = false;
            this.gbxExtras.Text = "Extras";
            // 
            // chkMorrones
            // 
            this.chkMorrones.AutoSize = true;
            this.chkMorrones.Location = new System.Drawing.Point(115, 48);
            this.chkMorrones.Name = "chkMorrones";
            this.chkMorrones.Size = new System.Drawing.Size(77, 19);
            this.chkMorrones.TabIndex = 3;
            this.chkMorrones.Text = "Morrones";
            this.chkMorrones.UseVisualStyleBackColor = true;
            // 
            // chkJamon
            // 
            this.chkJamon.AutoSize = true;
            this.chkJamon.Location = new System.Drawing.Point(7, 48);
            this.chkJamon.Name = "chkJamon";
            this.chkJamon.Size = new System.Drawing.Size(61, 19);
            this.chkJamon.TabIndex = 2;
            this.chkJamon.Text = "Jamón";
            this.chkJamon.UseVisualStyleBackColor = true;
            // 
            // chkAceitunas
            // 
            this.chkAceitunas.AutoSize = true;
            this.chkAceitunas.Location = new System.Drawing.Point(114, 22);
            this.chkAceitunas.Name = "chkAceitunas";
            this.chkAceitunas.Size = new System.Drawing.Size(78, 19);
            this.chkAceitunas.TabIndex = 1;
            this.chkAceitunas.Text = "Aceitunas";
            this.chkAceitunas.UseVisualStyleBackColor = true;
            // 
            // chkDobleQ
            // 
            this.chkDobleQ.AutoSize = true;
            this.chkDobleQ.Location = new System.Drawing.Point(7, 23);
            this.chkDobleQ.Name = "chkDobleQ";
            this.chkDobleQ.Size = new System.Drawing.Size(94, 19);
            this.chkDobleQ.TabIndex = 0;
            this.chkDobleQ.Text = "Doble Queso";
            this.chkDobleQ.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("DK Longreach", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(79, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 22);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Pizzería ISFT 172";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSubtitulo.Location = new System.Drawing.Point(79, 79);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(136, 23);
            this.lblSubtitulo.TabIndex = 3;
            this.lblSubtitulo.Text = "Complete su pedido";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 316);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(200, 316);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(106, 316);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(12, 367);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(263, 23);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrega
            // 
            this.lblEntrega.BackColor = System.Drawing.SystemColors.Control;
            this.lblEntrega.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEntrega.Location = new System.Drawing.Point(12, 397);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(263, 23);
            this.lblEntrega.TabIndex = 8;
            this.lblEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 438);
            this.Controls.Add(this.lblEntrega);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxExtras);
            this.Controls.Add(this.gbxTamaño);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza YA";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.gbxTamaño.ResumeLayout(false);
            this.gbxTamaño.PerformLayout();
            this.gbxExtras.ResumeLayout(false);
            this.gbxExtras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTamaño;
        private System.Windows.Forms.RadioButton rbtnFamiliar;
        private System.Windows.Forms.RadioButton rbtnMediana;
        private System.Windows.Forms.RadioButton rbtnGrande;
        private System.Windows.Forms.RadioButton rbtnChica;
        private System.Windows.Forms.GroupBox gbxExtras;
        private System.Windows.Forms.CheckBox chkMorrones;
        private System.Windows.Forms.CheckBox chkJamon;
        private System.Windows.Forms.CheckBox chkAceitunas;
        private System.Windows.Forms.CheckBox chkDobleQ;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblEntrega;
    }
}

