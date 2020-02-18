namespace WForm.EventAndDelegate
{
    partial class Form5
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
            this.submit_button = new System.Windows.Forms.Button();
            this.outputgrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.male_radiobutton = new System.Windows.Forms.RadioButton();
            this.female_radiobutton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phnenumber_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.state_textbox = new System.Windows.Forms.TextBox();
            this.city_textbox = new System.Windows.Forms.TextBox();
            this.employeeid_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.view_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(91, 422);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(94, 35);
            this.submit_button.TabIndex = 38;
            this.submit_button.Text = "Add";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // outputgrid
            // 
            this.outputgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputgrid.Location = new System.Drawing.Point(543, 119);
            this.outputgrid.Name = "outputgrid";
            this.outputgrid.RowTemplate.Height = 24;
            this.outputgrid.Size = new System.Drawing.Size(762, 357);
            this.outputgrid.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "city";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "state";
            // 
            // male_radiobutton
            // 
            this.male_radiobutton.AutoSize = true;
            this.male_radiobutton.Location = new System.Drawing.Point(273, 246);
            this.male_radiobutton.Name = "male_radiobutton";
            this.male_radiobutton.Size = new System.Drawing.Size(59, 21);
            this.male_radiobutton.TabIndex = 31;
            this.male_radiobutton.TabStop = true;
            this.male_radiobutton.Text = "male";
            this.male_radiobutton.UseVisualStyleBackColor = true;
            // 
            // female_radiobutton
            // 
            this.female_radiobutton.AutoSize = true;
            this.female_radiobutton.Location = new System.Drawing.Point(342, 248);
            this.female_radiobutton.Name = "female_radiobutton";
            this.female_radiobutton.Size = new System.Drawing.Size(71, 21);
            this.female_radiobutton.TabIndex = 30;
            this.female_radiobutton.TabStop = true;
            this.female_radiobutton.Text = "female";
            this.female_radiobutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(187, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 48);
            this.label5.TabIndex = 28;
            this.label5.Text = "Registration Form";
            // 
            // phnenumber_textbox
            // 
            this.phnenumber_textbox.Location = new System.Drawing.Point(291, 202);
            this.phnenumber_textbox.Name = "phnenumber_textbox";
            this.phnenumber_textbox.Size = new System.Drawing.Size(100, 22);
            this.phnenumber_textbox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "phone number";
            // 
            // lastname_textbox
            // 
            this.lastname_textbox.Location = new System.Drawing.Point(291, 161);
            this.lastname_textbox.Name = "lastname_textbox";
            this.lastname_textbox.Size = new System.Drawing.Size(100, 22);
            this.lastname_textbox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last Name";
            // 
            // firstname_textbox
            // 
            this.firstname_textbox.Location = new System.Drawing.Point(291, 119);
            this.firstname_textbox.Name = "firstname_textbox";
            this.firstname_textbox.Size = new System.Drawing.Size(100, 22);
            this.firstname_textbox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "First Name";
            // 
            // state_textbox
            // 
            this.state_textbox.Location = new System.Drawing.Point(291, 295);
            this.state_textbox.Name = "state_textbox";
            this.state_textbox.Size = new System.Drawing.Size(100, 22);
            this.state_textbox.TabIndex = 39;
            // 
            // city_textbox
            // 
            this.city_textbox.Location = new System.Drawing.Point(291, 337);
            this.city_textbox.Name = "city_textbox";
            this.city_textbox.Size = new System.Drawing.Size(100, 22);
            this.city_textbox.TabIndex = 40;
            // 
            // employeeid_text
            // 
            this.employeeid_text.Location = new System.Drawing.Point(291, 365);
            this.employeeid_text.Name = "employeeid_text";
            this.employeeid_text.Size = new System.Drawing.Size(100, 22);
            this.employeeid_text.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Employee id";
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(291, 422);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(94, 35);
            this.view_button.TabIndex = 43;
            this.view_button.Text = "View";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(191, 422);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(94, 35);
            this.delete_button.TabIndex = 44;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(391, 422);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(94, 35);
            this.update_button.TabIndex = 45;
            this.update_button.Text = "update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 531);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.employeeid_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.city_textbox);
            this.Controls.Add(this.state_textbox);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.outputgrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.male_radiobutton);
            this.Controls.Add(this.female_radiobutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phnenumber_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastname_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.DataGridView outputgrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton male_radiobutton;
        private System.Windows.Forms.RadioButton female_radiobutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phnenumber_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox state_textbox;
        private System.Windows.Forms.TextBox city_textbox;
        private System.Windows.Forms.TextBox employeeid_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
    }
}