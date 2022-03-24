namespace RGB.Interfaces
{
    partial class _Interface_Defecto
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
            this.label_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_nombre.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label_nombre.ForeColor = System.Drawing.Color.White;
            this.label_nombre.Location = new System.Drawing.Point(254, 24);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(273, 76);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "[Nombre]";
            // 
            // _Interface_Defecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_nombre);
            this.Name = "_Interface_Defecto";
            this.Text = "_Interface_Defecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre;
    }
}