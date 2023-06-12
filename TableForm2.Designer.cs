namespace WindowsFormsApp1
{
    partial class TableForm2
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.timeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.reminderTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.idTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dgv1.Location = new System.Drawing.Point(61, 275);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 82;
            this.dgv1.RowTemplate.Height = 33;
            this.dgv1.Size = new System.Drawing.Size(770, 301);
            this.dgv1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(648, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Добавить/изменить напоминание:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 857);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = " дата и время ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 980);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "напоминание";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(910, 231);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(777, 796);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = " id ";
            // 
            // searchButton
            // 
            this.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchButton.Depth = 0;
            this.searchButton.HighEmphasis = true;
            this.searchButton.Icon = null;
            this.searchButton.Location = new System.Drawing.Point(694, 169);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchButton.Name = "searchButton";
            this.searchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchButton.Size = new System.Drawing.Size(72, 36);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "поиск";
            this.searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchButton.UseAccentColor = false;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(135, 1099);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(100, 36);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "добавить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(872, 913);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(91, 36);
            this.deleteButton.TabIndex = 26;
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(752, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 33);
            this.label5.TabIndex = 27;
            this.label5.Text = "Удалить напоминание:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.AnimateReadOnly = false;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Depth = 0;
            this.searchTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchTextBox.LeadingIcon = null;
            this.searchTextBox.Location = new System.Drawing.Point(61, 155);
            this.searchTextBox.MaxLength = 50;
            this.searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.searchTextBox.Multiline = false;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(604, 50);
            this.searchTextBox.TabIndex = 32;
            this.searchTextBox.Text = "";
            this.searchTextBox.TrailingIcon = null;
            // 
            // timeTextBox
            // 
            this.timeTextBox.AnimateReadOnly = false;
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeTextBox.Depth = 0;
            this.timeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.timeTextBox.LeadingIcon = null;
            this.timeTextBox.Location = new System.Drawing.Point(330, 836);
            this.timeTextBox.MaxLength = 50;
            this.timeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.timeTextBox.Multiline = false;
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(248, 50);
            this.timeTextBox.TabIndex = 33;
            this.timeTextBox.Text = "";
            this.timeTextBox.TrailingIcon = null;
            // 
            // reminderTextBox
            // 
            this.reminderTextBox.AnimateReadOnly = false;
            this.reminderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reminderTextBox.Depth = 0;
            this.reminderTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.reminderTextBox.LeadingIcon = null;
            this.reminderTextBox.Location = new System.Drawing.Point(330, 959);
            this.reminderTextBox.MaxLength = 50;
            this.reminderTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.reminderTextBox.Multiline = false;
            this.reminderTextBox.Name = "reminderTextBox";
            this.reminderTextBox.Size = new System.Drawing.Size(248, 50);
            this.reminderTextBox.TabIndex = 34;
            this.reminderTextBox.Text = "";
            this.reminderTextBox.TrailingIcon = null;
            // 
            // idTextBox
            // 
            this.idTextBox.AnimateReadOnly = false;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Depth = 0;
            this.idTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idTextBox.LeadingIcon = null;
            this.idTextBox.Location = new System.Drawing.Point(859, 775);
            this.idTextBox.MaxLength = 50;
            this.idTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.idTextBox.Multiline = false;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(248, 50);
            this.idTextBox.TabIndex = 35;
            this.idTextBox.Text = "";
            this.idTextBox.TrailingIcon = null;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(330, 723);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(248, 50);
            this.materialTextBox1.TabIndex = 37;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(248, 744);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = " id ";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(358, 1099);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(100, 36);
            this.materialButton1.TabIndex = 38;
            this.materialButton1.Text = "обновить";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // TableForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1292, 1266);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.reminderTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv1);
            this.Name = "TableForm2";
            this.Text = "Напоминания";
            this.Load += new System.EventHandler(this.TableForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox;
        private MaterialSkin.Controls.MaterialTextBox timeTextBox;
        private MaterialSkin.Controls.MaterialTextBox reminderTextBox;
        private MaterialSkin.Controls.MaterialTextBox idTextBox;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}