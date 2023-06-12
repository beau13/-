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
            this.idTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.addressTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updateButton1 = new MaterialSkin.Controls.MaterialButton();
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
            this.dgv4.Size = new System.Drawing.Size(1180, 281);
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
            this.searchTextBox4.Size = new System.Drawing.Size(1005, 50);
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
            this.searchButton.Location = new System.Drawing.Point(1134, 193);
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
            // idTextBox
            // 
            this.idTextBox.AnimateReadOnly = false;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Depth = 0;
            this.idTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idTextBox.LeadingIcon = null;
            this.idTextBox.Location = new System.Drawing.Point(1082, 764);
            this.idTextBox.MaxLength = 50;
            this.idTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.idTextBox.Multiline = false;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(248, 50);
            this.idTextBox.TabIndex = 62;
            this.idTextBox.Text = "";
            this.idTextBox.TrailingIcon = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AnimateReadOnly = false;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(270, 866);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(393, 50);
            this.nameTextBox.TabIndex = 61;
            this.nameTextBox.Text = "";
            this.nameTextBox.TrailingIcon = null;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(1115, 894);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(91, 36);
            this.deleteButton.TabIndex = 60;
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
            this.label5.Location = new System.Drawing.Point(1007, 789);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(968, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 33);
            this.label4.TabIndex = 58;
            this.label4.Text = "Удалить контакт:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 891);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "     имя     \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 630);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 33);
            this.label1.TabIndex = 56;
            this.label1.Text = "Добавить/изменить контакт:";
            // 
            // addButton
            // 
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(222, 1406);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(100, 36);
            this.addButton.TabIndex = 55;
            this.addButton.Text = "Добавить";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.AnimateReadOnly = false;
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.Depth = 0;
            this.addressTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressTextBox.LeadingIcon = null;
            this.addressTextBox.Location = new System.Drawing.Point(270, 1002);
            this.addressTextBox.MaxLength = 50;
            this.addressTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.addressTextBox.Multiline = false;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(393, 50);
            this.addressTextBox.TabIndex = 64;
            this.addressTextBox.Text = "";
            this.addressTextBox.TrailingIcon = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 1027);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "   адрес   \r\n";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.AnimateReadOnly = false;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.Depth = 0;
            this.phoneTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneTextBox.LeadingIcon = null;
            this.phoneTextBox.Location = new System.Drawing.Point(270, 1124);
            this.phoneTextBox.MaxLength = 50;
            this.phoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.phoneTextBox.Multiline = false;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(393, 50);
            this.phoneTextBox.TabIndex = 66;
            this.phoneTextBox.Text = "";
            this.phoneTextBox.TrailingIcon = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 1149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 65;
            this.label6.Text = "номер телефона\r\n";
            // 
            // mailTextBox
            // 
            this.mailTextBox.AnimateReadOnly = false;
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailTextBox.Depth = 0;
            this.mailTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mailTextBox.LeadingIcon = null;
            this.mailTextBox.Location = new System.Drawing.Point(270, 1257);
            this.mailTextBox.MaxLength = 50;
            this.mailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.mailTextBox.Multiline = false;
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(393, 50);
            this.mailTextBox.TabIndex = 68;
            this.mailTextBox.Text = "";
            this.mailTextBox.TrailingIcon = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(99, 1282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "email почта \r\n";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(270, 748);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(248, 50);
            this.materialTextBox1.TabIndex = 70;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(195, 773);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 25);
            this.label8.TabIndex = 69;
            this.label8.Text = "id";
            // 
            // updateButton1
            // 
            this.updateButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateButton1.Depth = 0;
            this.updateButton1.HighEmphasis = true;
            this.updateButton1.Icon = null;
            this.updateButton1.Location = new System.Drawing.Point(435, 1406);
            this.updateButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateButton1.Size = new System.Drawing.Size(100, 36);
            this.updateButton1.TabIndex = 71;
            this.updateButton1.Text = "обновить";
            this.updateButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateButton1.UseAccentColor = false;
            this.updateButton1.UseVisualStyleBackColor = true;
            this.updateButton1.Click += new System.EventHandler(this.updateButton1_Click);
            // 
            // TableForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1400, 0);
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1440, 1567);
            this.Controls.Add(this.updateButton1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox4);
            this.Controls.Add(this.dgv4);
            this.Name = "TableForm4";
            this.Text = "Контакты";
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv4;
        private MaterialSkin.Controls.MaterialTextBox searchTextBox4;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialTextBox idTextBox;
        private MaterialSkin.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialTextBox addressTextBox;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox phoneTextBox;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox mailTextBox;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialButton updateButton1;
    }
}