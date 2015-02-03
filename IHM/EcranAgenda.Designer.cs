namespace Clinique
{
    partial class EcranAgenda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LBL_agenda_veto = new System.Windows.Forms.Label();
            this.LBL_agenda_date = new System.Windows.Forms.Label();
            this.dateTimePicker_agenda_date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_agenda = new System.Windows.Forms.DataGridView();
            this.BTN_agenda_Dossier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_agenda_date);
            this.groupBox1.Controls.Add(this.LBL_agenda_date);
            this.groupBox1.Controls.Add(this.LBL_agenda_veto);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // LBL_agenda_veto
            // 
            this.LBL_agenda_veto.AutoSize = true;
            this.LBL_agenda_veto.Location = new System.Drawing.Point(6, 33);
            this.LBL_agenda_veto.Name = "LBL_agenda_veto";
            this.LBL_agenda_veto.Size = new System.Drawing.Size(57, 13);
            this.LBL_agenda_veto.TabIndex = 1;
            this.LBL_agenda_veto.Text = "Vétérinaire";
            // 
            // LBL_agenda_date
            // 
            this.LBL_agenda_date.AutoSize = true;
            this.LBL_agenda_date.Location = new System.Drawing.Point(221, 33);
            this.LBL_agenda_date.Name = "LBL_agenda_date";
            this.LBL_agenda_date.Size = new System.Drawing.Size(30, 13);
            this.LBL_agenda_date.TabIndex = 2;
            this.LBL_agenda_date.Text = "Date";
            // 
            // dateTimePicker_agenda_date
            // 
            this.dateTimePicker_agenda_date.Location = new System.Drawing.Point(276, 30);
            this.dateTimePicker_agenda_date.Name = "dateTimePicker_agenda_date";
            this.dateTimePicker_agenda_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_agenda_date.TabIndex = 3;
            // 
            // dataGridView_agenda
            // 
            this.dataGridView_agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_agenda.Location = new System.Drawing.Point(13, 85);
            this.dataGridView_agenda.Name = "dataGridView_agenda";
            this.dataGridView_agenda.Size = new System.Drawing.Size(482, 143);
            this.dataGridView_agenda.TabIndex = 1;
            // 
            // BTN_agenda_Dossier
            // 
            this.BTN_agenda_Dossier.Location = new System.Drawing.Point(414, 234);
            this.BTN_agenda_Dossier.Name = "BTN_agenda_Dossier";
            this.BTN_agenda_Dossier.Size = new System.Drawing.Size(75, 23);
            this.BTN_agenda_Dossier.TabIndex = 2;
            this.BTN_agenda_Dossier.Text = "Dossier Médical";
            this.BTN_agenda_Dossier.UseVisualStyleBackColor = true;
            // 
            // EcranAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 264);
            this.Controls.Add(this.BTN_agenda_Dossier);
            this.Controls.Add(this.dataGridView_agenda);
            this.Controls.Add(this.groupBox1);
            this.Name = "EcranAgenda";
            this.Text = "Agenda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_agenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_agenda_date;
        private System.Windows.Forms.Label LBL_agenda_veto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_agenda_date;
        private System.Windows.Forms.DataGridView dataGridView_agenda;
        private System.Windows.Forms.Button BTN_agenda_Dossier;
    }
}