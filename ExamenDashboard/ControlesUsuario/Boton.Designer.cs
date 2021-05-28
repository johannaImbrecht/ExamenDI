
namespace ExamenDashboard.ControlesUsuario
{
    partial class Boton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prueba
            // 
            this.prueba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prueba.Location = new System.Drawing.Point(0, 0);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(180, 180);
            this.prueba.TabIndex = 0;
            this.prueba.Text = "Prueba";
            this.prueba.UseVisualStyleBackColor = true;
            // 
            // Boton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prueba);
            this.Name = "Boton";
            this.Load += new System.EventHandler(this.Boton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prueba;
    }
}
