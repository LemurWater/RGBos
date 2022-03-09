namespace RGB.Prueba
{
    partial class Prueba_Juego
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
            this.components = new System.ComponentModel.Container();
            this.Arriba = new System.Windows.Forms.Timer(this.components);
            this.Abajo = new System.Windows.Forms.Timer(this.components);
            this.Izquierda = new System.Windows.Forms.Timer(this.components);
            this.Derecha = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Arriba
            // 
            this.Arriba.Interval = 15;
            this.Arriba.Tick += new System.EventHandler(this.Arriba_Tick);
            // 
            // Abajo
            // 
            this.Abajo.Interval = 15;
            this.Abajo.Tick += new System.EventHandler(this.Abajo_Tick);
            // 
            // Izquierda
            // 
            this.Izquierda.Interval = 15;
            this.Izquierda.Tick += new System.EventHandler(this.Izquierda_Tick);
            // 
            // Derecha
            // 
            this.Derecha.Interval = 15;
            this.Derecha.Tick += new System.EventHandler(this.Derecha_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "봇";
            // 
            // Prueba_Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "Prueba_Juego";
            this.Text = "PRUEBA: Prueba_Juego";
            this.Load += new System.EventHandler(this.Prueba_Juego_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Prueba_Juego_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Prueba_Juego_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Arriba;
        private System.Windows.Forms.Timer Abajo;
        private System.Windows.Forms.Timer Izquierda;
        private System.Windows.Forms.Timer Derecha;
        private System.Windows.Forms.Label label1;
    }
}