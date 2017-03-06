namespace MovieBonanza
{
    partial class SelectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListCurrentMovies = new System.Windows.Forms.ListBox();
            this.GroupBoxYourSelection = new System.Windows.Forms.GroupBox();
            this.TextBoxCost = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.PictureBoxMovieSelected = new System.Windows.Forms.PictureBox();
            this.LabelCurrentMovies = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.GroupBoxYourSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMovieSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the movie you wish to STREAM from the list below:";
            // 
            // ListCurrentMovies
            // 
            this.ListCurrentMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCurrentMovies.FormattingEnabled = true;
            this.ListCurrentMovies.ItemHeight = 16;
            this.ListCurrentMovies.Location = new System.Drawing.Point(15, 82);
            this.ListCurrentMovies.Margin = new System.Windows.Forms.Padding(2);
            this.ListCurrentMovies.Name = "ListCurrentMovies";
            this.ListCurrentMovies.Size = new System.Drawing.Size(160, 244);
            this.ListCurrentMovies.Sorted = true;
            this.ListCurrentMovies.TabIndex = 1;
            this.ListCurrentMovies.SelectedIndexChanged += new System.EventHandler(this.ListBoxCurrentMovies_SelectedIndexChanged);
            // 
            // GroupBoxYourSelection
            // 
            this.GroupBoxYourSelection.Controls.Add(this.TextBoxCost);
            this.GroupBoxYourSelection.Controls.Add(this.CostLabel);
            this.GroupBoxYourSelection.Controls.Add(this.TextBoxCategory);
            this.GroupBoxYourSelection.Controls.Add(this.LabelCategory);
            this.GroupBoxYourSelection.Controls.Add(this.LabelTitle);
            this.GroupBoxYourSelection.Controls.Add(this.TextBoxTitle);
            this.GroupBoxYourSelection.Controls.Add(this.PictureBoxMovieSelected);
            this.GroupBoxYourSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxYourSelection.Location = new System.Drawing.Point(202, 74);
            this.GroupBoxYourSelection.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxYourSelection.Name = "GroupBoxYourSelection";
            this.GroupBoxYourSelection.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxYourSelection.Size = new System.Drawing.Size(370, 170);
            this.GroupBoxYourSelection.TabIndex = 2;
            this.GroupBoxYourSelection.TabStop = false;
            this.GroupBoxYourSelection.Text = "Your Selection";
            // 
            // TextBoxCost
            // 
            this.TextBoxCost.Enabled = false;
            this.TextBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCost.Location = new System.Drawing.Point(125, 133);
            this.TextBoxCost.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCost.Name = "TextBoxCost";
            this.TextBoxCost.ReadOnly = true;
            this.TextBoxCost.Size = new System.Drawing.Size(100, 22);
            this.TextBoxCost.TabIndex = 8;
            // 
            // CostLabel
            // 
            this.CostLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(122, 114);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(39, 16);
            this.CostLabel.TabIndex = 7;
            this.CostLabel.Text = "Cost";
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Enabled = false;
            this.TextBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCategory.Location = new System.Drawing.Point(125, 87);
            this.TextBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.ReadOnly = true;
            this.TextBoxCategory.Size = new System.Drawing.Size(230, 22);
            this.TextBoxCategory.TabIndex = 6;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(122, 68);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(71, 16);
            this.LabelCategory.TabIndex = 5;
            this.LabelCategory.Text = "Category";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(122, 22);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(39, 16);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "Title";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Enabled = false;
            this.TextBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTitle.Location = new System.Drawing.Point(125, 41);
            this.TextBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.ReadOnly = true;
            this.TextBoxTitle.Size = new System.Drawing.Size(230, 22);
            this.TextBoxTitle.TabIndex = 4;
            // 
            // PictureBoxMovieSelected
            // 
            this.PictureBoxMovieSelected.Location = new System.Drawing.Point(10, 22);
            this.PictureBoxMovieSelected.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBoxMovieSelected.Name = "PictureBoxMovieSelected";
            this.PictureBoxMovieSelected.Size = new System.Drawing.Size(100, 140);
            this.PictureBoxMovieSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMovieSelected.TabIndex = 4;
            this.PictureBoxMovieSelected.TabStop = false;
            // 
            // LabelCurrentMovies
            // 
            this.LabelCurrentMovies.AutoSize = true;
            this.LabelCurrentMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentMovies.Location = new System.Drawing.Point(12, 54);
            this.LabelCurrentMovies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCurrentMovies.Name = "LabelCurrentMovies";
            this.LabelCurrentMovies.Size = new System.Drawing.Size(143, 16);
            this.LabelCurrentMovies.TabIndex = 3;
            this.LabelCurrentMovies.Text = "CURRENT MOVIES";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(498, 318);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 30);
            this.ButtonNext.TabIndex = 4;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.LabelCurrentMovies);
            this.Controls.Add(this.GroupBoxYourSelection);
            this.Controls.Add(this.ListCurrentMovies);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza - Your Online Streaming Service";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.GroupBoxYourSelection.ResumeLayout(false);
            this.GroupBoxYourSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMovieSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListCurrentMovies;
        private System.Windows.Forms.GroupBox GroupBoxYourSelection;
        private System.Windows.Forms.TextBox TextBoxCost;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.PictureBox PictureBoxMovieSelected;
        private System.Windows.Forms.Label LabelCurrentMovies;
        private System.Windows.Forms.Button ButtonNext;
    }
}

