namespace WForm.EventAndDelegate
{
    partial class Form2
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
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phnenumber_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.female_radiobutton = new System.Windows.Forms.RadioButton();
            this.male_radiobutton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.state_combobox = new System.Windows.Forms.ComboBox();
            this.country_combobox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(125, 112);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(100, 22);
            this.firstname_textbox.TabIndex = 1;
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(125, 154);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(100, 22);
            this.lastname_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // phnenumber_textbox
            // 
            this.phnenumber_textbox.Location = new System.Drawing.Point(125, 195);
            this.phnenumber_textbox.Name = "phnenumber_textbox";
            this.phnenumber_textbox.Size = new System.Drawing.Size(100, 22);
            this.phnenumber_textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "phone number";
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(125, 238);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(100, 22);
            this.address_textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(21, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 48);
            this.label5.TabIndex = 8;
            this.label5.Text = "Registration Form";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "gender";
            // 
            // female_radiobutton
            // 
            this.female_radiobutton.AutoSize = true;
            this.female_radiobutton.Location = new System.Drawing.Point(175, 286);
            this.female_radiobutton.Name = "female_radiobutton";
            this.female_radiobutton.Size = new System.Drawing.Size(71, 21);
            this.female_radiobutton.TabIndex = 10;
            this.female_radiobutton.TabStop = true;
            this.female_radiobutton.Text = "female";
            this.female_radiobutton.UseVisualStyleBackColor = true;
            // 
            // male_radiobutton
            // 
            this.male_radiobutton.AutoSize = true;
            this.male_radiobutton.Location = new System.Drawing.Point(106, 284);
            this.male_radiobutton.Name = "male_radiobutton";
            this.male_radiobutton.Size = new System.Drawing.Size(59, 21);
            this.male_radiobutton.TabIndex = 11;
            this.male_radiobutton.TabStop = true;
            this.male_radiobutton.Text = "male";
            this.male_radiobutton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "state";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "country";
            // 
            // state_combobox
            // 
            this.state_combobox.FormattingEnabled = true;
            this.state_combobox.Location = new System.Drawing.Point(125, 377);
            this.state_combobox.Name = "state_combobox";
            this.state_combobox.Size = new System.Drawing.Size(121, 24);
            this.state_combobox.TabIndex = 15;
            this.state_combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // country_combobox
            // 
            this.country_combobox.FormattingEnabled = true;
            this.country_combobox.Location = new System.Drawing.Point(125, 326);
            this.country_combobox.Name = "country_combobox";
            this.country_combobox.Size = new System.Drawing.Size(121, 24);
            this.country_combobox.TabIndex = 16;
            this.country_combobox.DropDownClosed += new System.EventHandler(this.country_combobox_DropDownClosed);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 357);
            this.dataGridView1.TabIndex = 17;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(160, 434);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(86, 35);
            this.update_button.TabIndex = 18;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(51, 434);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(94, 35);
            this.submit_button.TabIndex = 19;
            this.submit_button.Text = "submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 539);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.country_combobox);
            this.Controls.Add(this.state_combobox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.male_radiobutton);
            this.Controls.Add(this.female_radiobutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phnenumber_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.TextBox lastname_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phnenumber_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton female_radiobutton;
        private System.Windows.Forms.RadioButton male_radiobutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox state_combobox;
        private System.Windows.Forms.ComboBox country_combobox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button submit_button;
    }
}