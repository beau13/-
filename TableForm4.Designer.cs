namespace WindowsFormsApp1
{
    partial class TableForm4
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
            this.dgv4 = new System.Windows.Forms.DataGridView();
            this.searchTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.searchButton = new MaterialSkin.Controls.MaterialButton();
            this.preserveButton4 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv4
            // 
            this.dgv4.BackgroundColor = System.Drawing.Color.White;
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Location = new System.Drawing.Point(88, 297);
            this.dgv4.Name = "dgv4";
            this.dgv4.RowHeadersWidth = 82;
            this.dgv4.RowTemplate.Height = 33;
            this.dgv4.Size = new System.Drawing.Size(1248, 281);
            this.dgv4.TabIndex = 0;
            // 
            // searchTextBox4
            // 
            this.searchTextBox4.AnimateReadOnly = false;
            this.searchTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox4.Depth = 0;
            this.searchTextBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox4.LeadingIcon = null;
            this.searchTextBox4.Location = new System.Drawing.Point(88, 179);
            this.searchTextBox4.MaxLength = 50;
            this.searchTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextBox4.Multiline = false;
            this.searchTextBox4.Name = "searchTextBox4";
            this.searchTextBox4.Size = new System.Drawing.Size(1039, 50);
            this.searchTextBox4.TabIndex = 53;
            this.searchTextBox4.Text = "";
            this.searchTextBox4.TrailingIcon = null;
            // 
            // searchButton
            // 
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchButton.Depth = 0;
            this.searchButton.HighEmphasis = true;
            this.searchButton.Icon = null;
            this.searchButton.Location = new System.Drawing.Point(1192, 193);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchButton.Name = "searchButton";
            this.searchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchButton.Size = new System.Drawing.Size(72, 36);
            this.searchButton.TabIndex = 54;
            this.searchButton.Text = "поиск";
            this.searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchButton.UseAccentColor = false;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // preserveButton4
            // 
            this.preserveButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.preserveButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.preserveButton4.Depth = 0;
            this.preserveButton4.HighEmphasis = true;
            this.preserveButton4.Icon = null;
            this.preserveButton4.Location = new System.Drawing.Point(88, 618);
            this.preserveButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.preserveButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.preserveButton4.Name = "preserveButton4";
            this.preserveButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.preserveButton4.Size = new System.Drawing.Size(109, 36);
            this.preserveButton4.TabIndex = 55;
            this.preserveButton4.Text = "сохранить";
            this.preserveButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.preserveButton4.UseAccentColor = false;
            this.preserveButton4.UseVisualStyleBackColor = true;
            this.preserveButton4.Click += new System.EventHandler(this.preserveButton4_Click);
            // 
            // TableForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1400, 0);
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1440, 760);
            this.Controls.Add(this.preserveButton4);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox4);
            this.Controls.Add(this.dgv4);
            this.Name = "TableForm4";
            this.Text = "Контакты";
            this.Load += new System.EventHandler(this.TableForm4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv4;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox4;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialButton preserveButton4;
    }
}