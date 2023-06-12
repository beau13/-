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
            this.idTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.noteTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.noButton = new MaterialSkin.Controls.MaterialButton();
            this.rtb = new MaterialSkin.Controls.MaterialTextBox();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.searchButton = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
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
            this.searchTextBox3.Location = new System.Drawing.Point(96, 154);
            this.searchTextBox3.MaxLength = 50;
            this.searchTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextBox3.Multiline = false;
            this.searchTextBox3.Name = "searchTextBox3";
            this.searchTextBox3.Size = new System.Drawing.Size(630, 50);
            this.searchTextBox3.TabIndex = 52;
            this.searchTextBox3.Text = "";
            this.searchTextBox3.TrailingIcon = null;
            // 
            // idTextBox3
            // 
            this.idTextBox3.AnimateReadOnly = false;
            this.idTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox3.Depth = 0;
            this.idTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idTextBox3.LeadingIcon = null;
            this.idTextBox3.Location = new System.Drawing.Point(845, 797);
            this.idTextBox3.MaxLength = 50;
            this.idTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.idTextBox3.Multiline = false;
            this.idTextBox3.Name = "idTextBox3";
            this.idTextBox3.Size = new System.Drawing.Size(248, 50);
            this.idTextBox3.TabIndex = 51;
            this.idTextBox3.Text = "";
            this.idTextBox3.TrailingIcon = null;
            // 
            // noteTextBox
            // 
            this.noteTextBox.AnimateReadOnly = false;
            this.noteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTextBox.Depth = 0;
            this.noteTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.noteTextBox.LeadingIcon = null;
            this.noteTextBox.Location = new System.Drawing.Point(301, 892);
            this.noteTextBox.MaxLength = 50;
            this.noteTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.noteTextBox.Multiline = false;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(248, 50);
            this.noteTextBox.TabIndex = 50;
            this.noteTextBox.Text = "";
            this.noteTextBox.TrailingIcon = null;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(867, 950);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(91, 36);
            this.deleteButton.TabIndex = 48;
            this.deleteButton.Text = "удалить";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(769, 822);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(740, 680);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 33);
            this.label4.TabIndex = 46;
            this.label4.Text = "Удалить задачу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 917);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "     заметка     \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Добавить/изменить задачу:";
            // 
            // addButton
            // 
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(200, 1038);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(100, 36);
            this.addButton.TabIndex = 42;
            this.addButton.Text = "Добавить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1008, 225);
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
            this.rtb.Location = new System.Drawing.Point(797, 473);
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
            this.dgv3.Location = new System.Drawing.Point(96, 278);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 82;
            this.dgv3.RowTemplate.Height = 33;
            this.dgv3.Size = new System.Drawing.Size(828, 336);
            this.dgv3.TabIndex = 38;
            // 
            // searchButton
            // 
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchButton.Depth = 0;
            this.searchButton.HighEmphasis = true;
            this.searchButton.Icon = null;
            this.searchButton.Location = new System.Drawing.Point(774, 168);
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
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(301, 778);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(248, 50);
            this.materialTextBox1.TabIndex = 55;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 803);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "id";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(420, 1038);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(100, 36);
            this.materialButton1.TabIndex = 56;
            this.materialButton1.Text = "обновить";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // TableForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1400, 1172);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox3);
            this.Controls.Add(this.idTextBox3);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
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
        private MaterialSkin.Controls.MaterialTextBox idTextBox3;
        private MaterialSkin.Controls.MaterialTextBox noteTextBox;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton addButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialButton noButton;
        private MaterialSkin.Controls.MaterialTextBox rtb;
        private System.Windows.Forms.DataGridView dgv3;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}