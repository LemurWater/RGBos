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
            this.agregar = new System.Windows.Forms.Button();
            this.rtb_titulo = new System.Windows.Forms.RichTextBox();
            this.rtx_texto = new System.Windows.Forms.RichTextBox();
            this.color_nuevo = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.rtb_ingresar = new System.Windows.Forms.RichTextBox();
            this.label_version = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.rtb_tamano = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boton_tam_men = new System.Windows.Forms.Button();
            this.boton_tam_mas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.White;
            this.agregar.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.agregar.Location = new System.Drawing.Point(855, 501);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(98, 37);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.Click_Guardar);
            // 
            // rtb_titulo
            // 
            this.rtb_titulo.BackColor = System.Drawing.Color.DimGray;
            this.rtb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_titulo.Location = new System.Drawing.Point(43, 32);
            this.rtb_titulo.Name = "rtb_titulo";
            this.rtb_titulo.ReadOnly = true;
            this.rtb_titulo.Size = new System.Drawing.Size(797, 66);
            this.rtb_titulo.TabIndex = 3;
            this.rtb_titulo.Text = "";
            // 
            // rtx_texto
            // 
            this.rtx_texto.BackColor = System.Drawing.Color.DimGray;
            this.rtx_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtx_texto.Location = new System.Drawing.Point(43, 135);
            this.rtx_texto.Name = "rtx_texto";
            this.rtx_texto.ReadOnly = true;
            this.rtx_texto.Size = new System.Drawing.Size(797, 403);
            this.rtx_texto.TabIndex = 4;
            this.rtx_texto.Text = "";
            // 
            // color_nuevo
            // 
            this.color_nuevo.BackColor = System.Drawing.Color.HotPink;
            this.color_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_nuevo.Location = new System.Drawing.Point(742, 558);
            this.color_nuevo.Name = "color_nuevo";
            this.color_nuevo.Size = new System.Drawing.Size(98, 37);
            this.color_nuevo.TabIndex = 5;
            this.color_nuevo.Click += new System.EventHandler(this.Click_Color_Nuevo);
            // 
            // rtb_ingresar
            // 
            this.rtb_ingresar.BackColor = System.Drawing.Color.DimGray;
            this.rtb_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_ingresar.Location = new System.Drawing.Point(43, 558);
            this.rtb_ingresar.Name = "rtb_ingresar";
            this.rtb_ingresar.Size = new System.Drawing.Size(680, 37);
            this.rtb_ingresar.TabIndex = 6;
            this.rtb_ingresar.Text = "";
            // 
            // label_version
            // 
            this.label_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_version.AutoSize = true;
            this.label_version.ForeColor = System.Drawing.Color.White;
            this.label_version.Location = new System.Drawing.Point(1244, 640);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(71, 16);
            this.label_version.TabIndex = 32;
            this.label_version.Text = "version 0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(884, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(69, 76);
            this.label1.TabIndex = 33;
            this.label1.Text = "T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(889, 92);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(62, 76);
            this.label2.TabIndex = 34;
            this.label2.Text = "e";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(889, 213);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(57, 76);
            this.label3.TabIndex = 36;
            this.label3.Text = "t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(889, 152);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(64, 76);
            this.label4.TabIndex = 35;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(891, 274);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(60, 76);
            this.label5.TabIndex = 37;
            this.label5.Text = "o";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button1.Location = new System.Drawing.Point(855, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 79);
            this.button1.TabIndex = 38;
            this.button1.Text = "[tituloOtexto]";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.Yellow;
            this.guardar.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.guardar.Location = new System.Drawing.Point(855, 558);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(98, 37);
            this.guardar.TabIndex = 39;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.Click_Guardar);
            // 
            // rtb_tamano
            // 
            this.rtb_tamano.BackColor = System.Drawing.Color.DimGray;
            this.rtb_tamano.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_tamano.ForeColor = System.Drawing.Color.Fuchsia;
            this.rtb_tamano.Location = new System.Drawing.Point(1125, 138);
            this.rtb_tamano.Name = "rtb_tamano";
            this.rtb_tamano.Size = new System.Drawing.Size(127, 45);
            this.rtb_tamano.TabIndex = 40;
            this.rtb_tamano.Text = "Prueba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1010, 128);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(37, 47);
            this.label6.TabIndex = 41;
            this.label6.Text = "a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1036, 107);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(60, 76);
            this.label7.TabIndex = 42;
            this.label7.Text = "a";
            // 
            // boton_tam_men
            // 
            this.boton_tam_men.BackColor = System.Drawing.Color.Firebrick;
            this.boton_tam_men.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.boton_tam_men.ForeColor = System.Drawing.Color.Yellow;
            this.boton_tam_men.Location = new System.Drawing.Point(1088, 138);
            this.boton_tam_men.Name = "boton_tam_men";
            this.boton_tam_men.Size = new System.Drawing.Size(31, 45);
            this.boton_tam_men.TabIndex = 43;
            this.boton_tam_men.Text = "<";
            this.boton_tam_men.UseVisualStyleBackColor = false;
            // 
            // boton_tam_mas
            // 
            this.boton_tam_mas.BackColor = System.Drawing.Color.ForestGreen;
            this.boton_tam_mas.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.boton_tam_mas.ForeColor = System.Drawing.Color.Yellow;
            this.boton_tam_mas.Location = new System.Drawing.Point(1258, 138);
            this.boton_tam_mas.Name = "boton_tam_mas";
            this.boton_tam_mas.Size = new System.Drawing.Size(31, 45);
            this.boton_tam_mas.TabIndex = 44;
            this.boton_tam_mas.Text = ">";
            this.boton_tam_mas.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(1088, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 45);
            this.button2.TabIndex = 45;
            this.button2.Text = "aA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Italic);
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(1160, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 45);
            this.button3.TabIndex = 46;
            this.button3.Text = "aA";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Strikeout);
            this.button4.Location = new System.Drawing.Point(1160, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 45);
            this.button4.TabIndex = 47;
            this.button4.Text = "aA";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Yellow;
            this.button5.Location = new System.Drawing.Point(1233, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 45);
            this.button5.TabIndex = 48;
            this.button5.Text = "aA";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Underline);
            this.button6.Location = new System.Drawing.Point(1231, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 45);
            this.button6.TabIndex = 49;
            this.button6.Text = "aA";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Fuchsia;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.button7.Location = new System.Drawing.Point(1152, 349);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 45);
            this.button7.TabIndex = 50;
            this.button7.Text = "aa aa ⇉ Aa Aa";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Fuchsia;
            this.button8.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.button8.Location = new System.Drawing.Point(1152, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 45);
            this.button8.TabIndex = 51;
            this.button8.Text = "aa aa ⇉ Aa aa";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Fuchsia;
            this.button9.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.button9.Location = new System.Drawing.Point(1152, 451);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 45);
            this.button9.TabIndex = 52;
            this.button9.Text = "Aa aa ⇉ AaAa";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.button10.Location = new System.Drawing.Point(1088, 273);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 45);
            this.button10.TabIndex = 53;
            this.button10.Text = "aA";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // Interface_Prog_Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1335, 665);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.boton_tam_mas);
            this.Controls.Add(this.boton_tam_men);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_tamano);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.rtb_ingresar);
            this.Controls.Add(this.color_nuevo);
            this.Controls.Add(this.rtx_texto);
            this.Controls.Add(this.rtb_titulo);
            this.Controls.Add(this.agregar);
            this.Name = "Interface_Prog_Texto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB - [Prog_Texto]";
            this.Load += new System.EventHandler(this.Interface_Prog_Texto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel color;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.RichTextBox rtb_titulo;
        private System.Windows.Forms.RichTextBox rtx_texto;
        private System.Windows.Forms.Panel color_nuevo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.RichTextBox rtb_ingresar;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.RichTextBox rtb_tamano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button boton_tam_men;
        private System.Windows.Forms.Button boton_tam_mas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}