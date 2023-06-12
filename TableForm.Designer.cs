namespace WindowsFormsApp1
{
    partial class TableForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.rtb = new MaterialSkin.Controls.MaterialTextBox();
            this.searchButton = new MaterialSkin.Controls.MaterialButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.timeTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.addTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.idTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.searchTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.Color.RoyalBlue;
            this.dgv.Location = new System.Drawing.Point(76, 300);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(828, 336);
            this.dgv.TabIndex = 0;
            // 
            // rtb
            // 
            this.rtb.AnimateReadOnly = false;
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Depth = 0;
            this.rtb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtb.LeadingIcon = null;
            this.rtb.Location = new System.Drawing.Point(779, 566);
            this.rtb.MaxLength = 50;
            this.rtb.MouseState = MaterialSkin.MouseState.OUT;
            this.rtb.Multiline = false;
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(100, 50);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            this.rtb.TrailingIcon = null;
            this.rtb.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchButton.Depth = 0;
            this.searchButton.HighEmphasis = true;
            this.searchButton.Icon = null;
            this.searchButton.Location = new System.Drawing.Point(753, 188);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchButton.Name = "searchButton";
            this.searchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchButton.Size = new System.Drawing.Size(72, 36);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Поиск";
            this.searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchButton.UseAccentColor = false;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(971, 256);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(207, 1160);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(100, 36);
            this.materialButton1.TabIndex = 10;
            this.materialButton1.Text = "Добавить";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 910);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "дата и время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(183, 1043);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "     задача";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 692);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добавить/изменить задачу:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(733, 692);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 33);
            this.label4.TabIndex = 19;
            this.label4.Text = "Удалить задачу:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(749, 866);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "id";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(840, 972);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(91, 36);
            this.materialButton2.TabIndex = 22;
            this.materialButton2.Text = "удалить";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // timeTextBox1
            // 
            this.timeTextBox1.AnimateReadOnly = false;
            this.timeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeTextBox1.Depth = 0;
            this.timeTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.timeTextBox1.LeadingIcon = null;
            this.timeTextBox1.Location = new System.Drawing.Point(342, 885);
            this.timeTextBox1.MaxLength = 50;
            this.timeTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.timeTextBox1.Multiline = false;
            this.timeTextBox1.Name = "timeTextBox1";
            this.timeTextBox1.Size = new System.Drawing.Size(248, 50);
            this.timeTextBox1.TabIndex = 34;
            this.timeTextBox1.Text = "";
            this.timeTextBox1.TrailingIcon = null;
            // 
            // addTextBox1
            // 
            this.addTextBox1.AnimateReadOnly = false;
            this.addTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTextBox1.Depth = 0;
            this.addTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addTextBox1.LeadingIcon = null;
            this.addTextBox1.Location = new System.Drawing.Point(342, 1018);
            this.addTextBox1.MaxLength = 50;
            this.addTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.addTextBox1.Multiline = false;
            this.addTextBox1.Name = "addTextBox1";
            this.addTextBox1.Size = new System.Drawing.Size(248, 50);
            this.addTextBox1.TabIndex = 35;
            this.addTextBox1.Text = "";
            this.addTextBox1.TrailingIcon = null;
            // 
            // idTextBox
            // 
            this.idTextBox.AnimateReadOnly = false;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Depth = 0;
            this.idTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idTextBox.LeadingIcon = null;
            this.idTextBox.Location = new System.Drawing.Point(817, 841);
            this.idTextBox.MaxLength = 50;
            this.idTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.idTextBox.Multiline = false;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(248, 50);
            this.idTextBox.TabIndex = 36;
            this.idTextBox.Text = "";
            this.idTextBox.TrailingIcon = null;
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.AnimateReadOnly = false;
            this.searchTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox1.Depth = 0;
            this.searchTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox1.LeadingIcon = null;
            this.searchTextBox1.Location = new System.Drawing.Point(76, 174);
            this.searchTextBox1.MaxLength = 50;
            this.searchTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextBox1.Multiline = false;
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.Size = new System.Drawing.Size(630, 50);
            this.searchTextBox1.TabIndex = 37;
            this.searchTextBox1.Text = "";
            this.searchTextBox1.TrailingIcon = null;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(428, 1160);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(100, 36);
            this.materialButton3.TabIndex = 38;
            this.materialButton3.Text = "обновить";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialTextBox
            // 
            this.materialTextBox.AnimateReadOnly = false;
            this.materialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox.Depth = 0;
            this.materialTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox.LeadingIcon = null;
            this.materialTextBox.Location = new System.Drawing.Point(342, 768);
            this.materialTextBox.MaxLength = 50;
            this.materialTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox.Multiline = false;
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(248, 50);
            this.materialTextBox.TabIndex = 40;
            this.materialTextBox.Text = "";
            this.materialTextBox.TrailingIcon = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(254, 793);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "id";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1337, 1315);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.searchTextBox1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.addTextBox1);
            this.Controls.Add(this.timeTextBox1);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.dgv);
            this.Name = "TableForm";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialTextBox rtb;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox timeTextBox1;
        private MaterialSkin.Controls.MaterialTextBox addTextBox1;
        private MaterialSkin.Controls.MaterialTextBox idTextBox;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox;
        private System.Windows.Forms.Label label6;
    }
}