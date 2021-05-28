
namespace ExamenDashboard.ControlesUsuario
{
    partial class Tablas
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
            this.datosTabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datosTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // datosTabla
            // 
            this.datosTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosTabla.Location = new System.Drawing.Point(41, 27);
            this.datosTabla.Name = "datosTabla";
            this.datosTabla.RowHeadersWidth = 62;
            this.datosTabla.RowTemplate.Height = 28;
            this.datosTabla.Size = new System.Drawing.Size(354, 383);
            this.datosTabla.TabIndex = 0;
            // 
            // Tablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datosTabla);
            this.Name = "Tablas";
            this.Size = new System.Drawing.Size(520, 462);
            ((System.ComponentModel.ISupportInitialize)(this.datosTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView datosTabla;
    }
}
