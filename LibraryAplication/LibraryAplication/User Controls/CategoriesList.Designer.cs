namespace LibraryAplication.User_Controls
{
    partial class CategoriesList
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
            this.panelCategories = new System.Windows.Forms.Panel();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.textBoxNewCategory = new System.Windows.Forms.TextBox();
            this.textBoxSearchbar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCategories
            // 
            this.panelCategories.AutoScroll = true;
            this.panelCategories.Location = new System.Drawing.Point(17, 3);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(213, 273);
            this.panelCategories.TabIndex = 2;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Location = new System.Drawing.Point(123, 280);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(100, 23);
            this.btnAddNewCategory.TabIndex = 3;
            this.btnAddNewCategory.Text = "AddNewCategory";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            this.btnAddNewCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnAddNewCategory_KeyUp);
            // 
            // textBoxNewCategory
            // 
            this.textBoxNewCategory.Location = new System.Drawing.Point(17, 282);
            this.textBoxNewCategory.Name = "textBoxNewCategory";
            this.textBoxNewCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewCategory.TabIndex = 4;
            this.textBoxNewCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNewCategory_KeyUp);
            // 
            // textBoxSearchbar
            // 
            this.textBoxSearchbar.Location = new System.Drawing.Point(17, 319);
            this.textBoxSearchbar.Name = "textBoxSearchbar";
            this.textBoxSearchbar.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchbar.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(139, 319);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CategoriesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(178)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearchbar);
            this.Controls.Add(this.textBoxNewCategory);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.panelCategories);
            this.Name = "CategoriesList";
            this.Size = new System.Drawing.Size(256, 398);
            this.Load += new System.EventHandler(this.CategoriesList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCategories;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.TextBox textBoxNewCategory;
        private System.Windows.Forms.TextBox textBoxSearchbar;
        private System.Windows.Forms.Button btnSearch;
    }
}
