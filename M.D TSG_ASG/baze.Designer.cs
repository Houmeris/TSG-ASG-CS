
namespace M.D_TSG_ASG
{
    partial class baze
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
            this.lentele = new System.Windows.Forms.DataGridView();
            this.salygos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isvados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Redaguoti = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lentele)).BeginInit();
            this.SuspendLayout();
            // 
            // lentele
            // 
            this.lentele.AllowUserToAddRows = false;
            this.lentele.AllowUserToDeleteRows = false;
            this.lentele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lentele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salygos,
            this.isvados});
            this.lentele.Location = new System.Drawing.Point(43, 12);
            this.lentele.Name = "lentele";
            this.lentele.Size = new System.Drawing.Size(290, 455);
            this.lentele.TabIndex = 0;
            // 
            // salygos
            // 
            this.salygos.HeaderText = "salygos";
            this.salygos.Name = "salygos";
            // 
            // isvados
            // 
            this.isvados.HeaderText = "isvados";
            this.isvados.Name = "isvados";
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(391, 78);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Trinti";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pirmiausia pasirinkite eilutė";
            // 
            // Redaguoti
            // 
            this.Redaguoti.Enabled = false;
            this.Redaguoti.Location = new System.Drawing.Point(391, 124);
            this.Redaguoti.Name = "Redaguoti";
            this.Redaguoti.Size = new System.Drawing.Size(75, 23);
            this.Redaguoti.TabIndex = 4;
            this.Redaguoti.Text = "Redaguoti";
            this.Redaguoti.UseVisualStyleBackColor = true;
            this.Redaguoti.Click += new System.EventHandler(this.Redaguoti_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(391, 170);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Pridėti";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // baze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 479);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Redaguoti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.lentele);
            this.Name = "baze";
            this.Text = "baze";
            this.Load += new System.EventHandler(this.baze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lentele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lentele;
        private System.Windows.Forms.DataGridViewTextBoxColumn salygos;
        private System.Windows.Forms.DataGridViewTextBoxColumn isvados;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Redaguoti;
        private System.Windows.Forms.Button Add;
    }
}