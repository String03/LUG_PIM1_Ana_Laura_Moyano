namespace LUG_PIM1_Ana_Laura_Moyano
{
    partial class MainForm
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
            this.btnAgregarSecuencia = new System.Windows.Forms.Button();
            this.grvSecuencia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvSecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarSecuencia
            // 
            this.btnAgregarSecuencia.Location = new System.Drawing.Point(347, 293);
            this.btnAgregarSecuencia.Name = "btnAgregarSecuencia";
            this.btnAgregarSecuencia.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarSecuencia.TabIndex = 0;
            this.btnAgregarSecuencia.Text = "Agregar Secuencia";
            this.btnAgregarSecuencia.UseVisualStyleBackColor = true;
            this.btnAgregarSecuencia.Click += new System.EventHandler(this.btnAgregarSecuencia_Click);
            // 
            // grvSecuencia
            // 
            this.grvSecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSecuencia.Location = new System.Drawing.Point(182, 84);
            this.grvSecuencia.Name = "grvSecuencia";
            this.grvSecuencia.Size = new System.Drawing.Size(444, 150);
            this.grvSecuencia.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grvSecuencia);
            this.Controls.Add(this.btnAgregarSecuencia);
            this.Name = "MainForm";
            this.Text = "XML";
            ((System.ComponentModel.ISupportInitialize)(this.grvSecuencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarSecuencia;
        private System.Windows.Forms.DataGridView grvSecuencia;
    }
}

