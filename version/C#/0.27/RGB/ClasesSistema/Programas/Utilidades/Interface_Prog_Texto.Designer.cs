namespace RGB.ClasesSistema.Programas.Utilidades
{
    partial class Interface_Prog_Texto
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
            this.guardar = new System.Windows.Forms.Button();
            this.nuevo_texto = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.RichTextBox();
            this.texto = new System.Windows.Forms.RichTextBox();
            this.color_nuevo = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(686, 416);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // nuevo_texto
            // 
            this.nuevo_texto.Location = new System.Drawing.Point(43, 416);
            this.nuevo_texto.Name = "nuevo_texto";
            this.nuevo_texto.Size = new System.Drawing.Size(558, 22);
            this.nuevo_texto.TabIndex = 2;
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(43, 32);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(718, 45);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "";
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(43, 99);
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            this.texto.Size = new System.Drawing.Size(718, 303);
            this.texto.TabIndex = 4;
            this.texto.Text = "";
            // 
            // color_nuevo
            // 
            this.color_nuevo.BackColor = System.Drawing.Color.HotPink;
            this.color_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_nuevo.Location = new System.Drawing.Point(607, 416);
            this.color_nuevo.Name = "color_nuevo";
            this.color_nuevo.Size = new System.Drawing.Size(73, 23);
            this.color_nuevo.TabIndex = 5;
            this.color_nuevo.Click += new System.EventHandler(this.color_nuevo_Click_1);
            // 
            // Interface_Prog_Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.color_nuevo);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.nuevo_texto);
            this.Controls.Add(this.guardar);
            this.Name = "Interface_Prog_Texto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface_Prog_Texto";
            this.Load += new System.EventHandler(this.Interface_Prog_Texto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel color;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox nuevo_texto;
        private System.Windows.Forms.RichTextBox titulo;
        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.Panel color_nuevo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}