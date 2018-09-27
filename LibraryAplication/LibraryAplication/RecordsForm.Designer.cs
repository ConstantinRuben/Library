namespace LibraryAplication
{
    partial class RecordsForm
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
            this.panelTopSideAddBook = new System.Windows.Forms.Panel();
            this.label_Recors = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.panelTopSideAddBook.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopSideAddBook
            // 
            this.panelTopSideAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.panelTopSideAddBook.Controls.Add(this.label_Recors);
            this.panelTopSideAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSideAddBook.Location = new System.Drawing.Point(0, 0);
            this.panelTopSideAddBook.Name = "panelTopSideAddBook";
            this.panelTopSideAddBook.Size = new System.Drawing.Size(1357, 56);
            this.panelTopSideAddBook.TabIndex = 6;
            // 
            // label_Recors
            // 
            this.label_Recors.AutoSize = true;
            this.label_Recors.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Recors.ForeColor = System.Drawing.Color.White;
            this.label_Recors.Location = new System.Drawing.Point(12, 9);
            this.label_Recors.Name = "label_Recors";
            this.label_Recors.Size = new System.Drawing.Size(92, 33);
            this.label_Recors.TabIndex = 10;
            this.label_Recors.Text = "Recors";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewRecords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 548);
            this.panel1.TabIndex = 7;
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRecords.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRecords.EnableHeadersVisualStyles = false;
            this.dataGridViewRecords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.Size = new System.Drawing.Size(828, 548);
            this.dataGridViewRecords.TabIndex = 0;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTopSideAddBook);
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            this.Load += new System.EventHandler(this.RecordsForm_Load);
            this.panelTopSideAddBook.ResumeLayout(false);
            this.panelTopSideAddBook.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSideAddBook;
        private System.Windows.Forms.Label label_Recors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
    }
}