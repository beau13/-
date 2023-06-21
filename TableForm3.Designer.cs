namespace WindowsFormsApp1
{
    partial class TableForm3
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
            this.searchTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.noButton = new MaterialSkin.Controls.MaterialButton();
            this.rtb = new MaterialSkin.Controls.MaterialTextBox();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.searchButton = new MaterialSkin.Controls.MaterialButton();
            this.preservebutton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox3
            // 
            this.searchTextBox3.AnimateReadOnly = false;
            this.searchTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox3.Depth = 0;
            this.searchTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox3.LeadingIcon = null;
            this.searchTextBox3.Location = new System.Drawing.Point(96, 168);
            this.searchTextBox3.MaxLength = 50;
            this.searchTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextBox3.Multiline = false;
            this.searchTextBox3.Name = "searchTextBox3";
            this.searchTextBox3.Size = new System.Drawing.Size(630, 50);
            this.searchTextBox3.TabIndex = 52;
            this.searchTextBox3.Text = "";
            this.searchTextBox3.TrailingIcon = null;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1008, 250);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 41;
            // 
            // noButton
            // 
            this.noButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.noButton.Depth = 0;
            this.noButton.HighEmphasis = true;
            this.noButton.Icon = null;
            this.noButton.Location = new System.Drawing.Point(631, -34);
            this.noButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.noButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.noButton.Name = "noButton";
            this.noButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.noButton.Size = new System.Drawing.Size(72, 36);
            this.noButton.TabIndex = 40;
            this.noButton.Text = "Поиск";
            this.noButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.noButton.UseAccentColor = false;
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            // 
            // rtb
            // 
            this.rtb.AnimateReadOnly = false;
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Depth = 0;
            this.rtb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtb.LeadingIcon = null;
            this.rtb.Location = new System.Drawing.Point(797, 487);
            this.rtb.MaxLength = 50;
            this.rtb.MouseState = MaterialSkin.MouseState.OUT;
            this.rtb.Multiline = false;
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(100, 50);
            this.rtb.TabIndex = 39;
            this.rtb.Text = "";
            this.rtb.TrailingIcon = null;
            this.rtb.Visible = false;
            // 
            // dgv3
            // 
            this.dgv3.BackgroundColor = System.Drawing.Color.White;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.GridColor = System.Drawing.Color.RoyalBlue;
            this.dgv3.Location = new System.Drawing.Point(96, 292);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 82;
            this.dgv3.RowTemplate.Height = 33;
            this.dgv3.Size = new System.Drawing.Size(828, 348);
            this.dgv3.TabIndex = 38;
            // 
            // searchButton
            // 
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchButton.Depth = 0;
            this.searchButton.HighEmphasis = true;
            this.searchButton.Icon = null;
            this.searchButton.Location = new System.Drawing.Point(774, 182);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchButton.Name = "searchButton";
            this.searchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchButton.Size = new System.Drawing.Size(72, 36);
            this.searchButton.TabIndex = 53;
            this.searchButton.Text = "поиск";
            this.searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchButton.UseAccentColor = false;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // preservebutton
            // 
            this.preservebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.preservebutton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.preservebutton.Depth = 0;
            this.preservebutton.HighEmphasis = true;
            this.preservebutton.Icon = null;
            this.preservebutton.Location = new System.Drawing.Point(96, 684);
            this.preservebutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.preservebutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.preservebutton.Name = "preservebutton";
            this.preservebutton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.preservebutton.Size = new System.Drawing.Size(109, 36);
            this.preservebutton.TabIndex = 54;
            this.preservebutton.Text = "сохранить";
            this.preservebutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.preservebutton.UseAccentColor = false;
            this.preservebutton.UseVisualStyleBackColor = true;
            this.preservebutton.Click += new System.EventHandler(this.preservebutton_Click);
            // 
            // TableForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1400, 844);
            this.Controls.Add(this.preservebutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.dgv3);
            this.Name = "TableForm3";
            this.Text = "Заметки";
            this.Load += new System.EventHandler(this.TableForm3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox searchTextBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialButton noButton;
        private MaterialSkin.Controls.MaterialTextBox rtb;
        private System.Windows.Forms.DataGridView dgv3;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialButton preservebutton;
    }
}