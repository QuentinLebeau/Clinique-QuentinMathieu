namespace Clinique
{
    partial class EcranRelance
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
            this.GRID_Relance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Relance)).BeginInit();
            this.SuspendLayout();
            // 
            // GRID_Relance
            // 
            this.GRID_Relance.AllowUserToAddRows = false;
            this.GRID_Relance.AllowUserToDeleteRows = false;
            this.GRID_Relance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRID_Relance.Location = new System.Drawing.Point(13, 13);
            this.GRID_Relance.Name = "GRID_Relance";
            this.GRID_Relance.ReadOnly = true;
            this.GRID_Relance.Size = new System.Drawing.Size(549, 299);
            this.GRID_Relance.TabIndex = 0;
            // 
            // EcranRelance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 324);
            this.Controls.Add(this.GRID_Relance);
            this.Name = "EcranRelance";
            this.Text = "Relance";
            ((System.ComponentModel.ISupportInitialize)(this.GRID_Relance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GRID_Relance;

    }
}