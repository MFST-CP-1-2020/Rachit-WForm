namespace PAL
{
    partial class Form1
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
            this.bttn_update = new System.Windows.Forms.Button();
            this.bttn_delete = new System.Windows.Forms.Button();
            this.bttn_view = new System.Windows.Forms.Button();
            this.txt_Employeeid = new System.Windows.Forms.TextBox();
            this.lbl_Employeeid = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_State = new System.Windows.Forms.TextBox();
            this.bttn_submit = new System.Windows.Forms.Button();
            this.grid_output = new System.Windows.Forms.DataGridView();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.radiobttn_Male = new System.Windows.Forms.RadioButton();
            this.radiobttn_Female = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.txt_Phonenumber = new System.Windows.Forms.TextBox();
            this.lbl_Phonenumber = new System.Windows.Forms.Label();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.lbl_Lastname = new System.Windows.Forms.Label();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.lbl_Firstname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_output)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_update
            // 
            this.bttn_update.Location = new System.Drawing.Point(361, 424);
            this.bttn_update.Name = "bttn_update";
            this.bttn_update.Size = new System.Drawing.Size(94, 35);
            this.bttn_update.TabIndex = 66;
            this.bttn_update.Text = "update";
            this.bttn_update.UseVisualStyleBackColor = true;
            this.bttn_update.Click += new System.EventHandler(this.bttn_update_Click);
            // 
            // bttn_delete
            // 
            this.bttn_delete.Location = new System.Drawing.Point(161, 424);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(94, 35);
            this.bttn_delete.TabIndex = 65;
            this.bttn_delete.Text = "delete";
            this.bttn_delete.UseVisualStyleBackColor = true;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // bttn_view
            // 
            this.bttn_view.Location = new System.Drawing.Point(261, 424);
            this.bttn_view.Name = "bttn_view";
            this.bttn_view.Size = new System.Drawing.Size(94, 35);
            this.bttn_view.TabIndex = 64;
            this.bttn_view.Text = "View";
            this.bttn_view.UseVisualStyleBackColor = true;
            this.bttn_view.Click += new System.EventHandler(this.bttn_view_Click);
            // 
            // txt_Employeeid
            // 
            this.txt_Employeeid.Location = new System.Drawing.Point(261, 367);
            this.txt_Employeeid.Name = "txt_Employeeid";
            this.txt_Employeeid.Size = new System.Drawing.Size(100, 22);
            this.txt_Employeeid.TabIndex = 63;
            // 
            // lbl_Employeeid
            // 
            this.lbl_Employeeid.AutoSize = true;
            this.lbl_Employeeid.Location = new System.Drawing.Point(162, 370);
            this.lbl_Employeeid.Name = "lbl_Employeeid";
            this.lbl_Employeeid.Size = new System.Drawing.Size(85, 17);
            this.lbl_Employeeid.TabIndex = 62;
            this.lbl_Employeeid.Text = "Employee id";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(261, 339);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 22);
            this.txt_City.TabIndex = 61;
            // 
            // txt_State
            // 
            this.txt_State.Location = new System.Drawing.Point(261, 297);
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(100, 22);
            this.txt_State.TabIndex = 60;
            // 
            // bttn_submit
            // 
            this.bttn_submit.Location = new System.Drawing.Point(61, 424);
            this.bttn_submit.Name = "bttn_submit";
            this.bttn_submit.Size = new System.Drawing.Size(94, 35);
            this.bttn_submit.TabIndex = 59;
            this.bttn_submit.Text = "Add";
            this.bttn_submit.UseVisualStyleBackColor = true;
            this.bttn_submit.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // grid_output
            // 
            this.grid_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_output.Location = new System.Drawing.Point(513, 121);
            this.grid_output.Name = "grid_output";
            this.grid_output.RowTemplate.Height = 24;
            this.grid_output.Size = new System.Drawing.Size(762, 357);
            this.grid_output.TabIndex = 58;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(163, 339);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(29, 17);
            this.lbl_City.TabIndex = 57;
            this.lbl_City.Text = "city";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(163, 297);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(39, 17);
            this.lbl_State.TabIndex = 56;
            this.lbl_State.Text = "state";
            // 
            // radiobttn_Male
            // 
            this.radiobttn_Male.AutoSize = true;
            this.radiobttn_Male.Location = new System.Drawing.Point(243, 248);
            this.radiobttn_Male.Name = "radiobttn_Male";
            this.radiobttn_Male.Size = new System.Drawing.Size(59, 21);
            this.radiobttn_Male.TabIndex = 55;
            this.radiobttn_Male.TabStop = true;
            this.radiobttn_Male.Text = "male";
            this.radiobttn_Male.UseVisualStyleBackColor = true;
            // 
            // radiobttn_Female
            // 
            this.radiobttn_Female.AutoSize = true;
            this.radiobttn_Female.Location = new System.Drawing.Point(312, 250);
            this.radiobttn_Female.Name = "radiobttn_Female";
            this.radiobttn_Female.Size = new System.Drawing.Size(71, 21);
            this.radiobttn_Female.TabIndex = 54;
            this.radiobttn_Female.TabStop = true;
            this.radiobttn_Female.Text = "female";
            this.radiobttn_Female.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(163, 250);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(53, 17);
            this.lbl_Gender.TabIndex = 53;
            this.lbl_Gender.Text = "gender";
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_Heading.Location = new System.Drawing.Point(157, 57);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(550, 48);
            this.lbl_Heading.TabIndex = 52;
            this.lbl_Heading.Text = "Employee Registration Form";
            // 
            // txt_Phonenumber
            // 
            this.txt_Phonenumber.Location = new System.Drawing.Point(261, 204);
            this.txt_Phonenumber.Name = "txt_Phonenumber";
            this.txt_Phonenumber.Size = new System.Drawing.Size(100, 22);
            this.txt_Phonenumber.TabIndex = 51;
            // 
            // lbl_Phonenumber
            // 
            this.lbl_Phonenumber.AutoSize = true;
            this.lbl_Phonenumber.Location = new System.Drawing.Point(162, 204);
            this.lbl_Phonenumber.Name = "lbl_Phonenumber";
            this.lbl_Phonenumber.Size = new System.Drawing.Size(100, 17);
            this.lbl_Phonenumber.TabIndex = 50;
            this.lbl_Phonenumber.Text = "phone number";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(261, 163);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(100, 22);
            this.txt_Lastname.TabIndex = 49;
            // 
            // lbl_Lastname
            // 
            this.lbl_Lastname.AutoSize = true;
            this.lbl_Lastname.Location = new System.Drawing.Point(162, 163);
            this.lbl_Lastname.Name = "lbl_Lastname";
            this.lbl_Lastname.Size = new System.Drawing.Size(76, 17);
            this.lbl_Lastname.TabIndex = 48;
            this.lbl_Lastname.Text = "Last Name";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Location = new System.Drawing.Point(261, 121);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(100, 22);
            this.txt_Firstname.TabIndex = 47;
            // 
            // lbl_Firstname
            // 
            this.lbl_Firstname.AutoSize = true;
            this.lbl_Firstname.Location = new System.Drawing.Point(162, 124);
            this.lbl_Firstname.Name = "lbl_Firstname";
            this.lbl_Firstname.Size = new System.Drawing.Size(76, 17);
            this.lbl_Firstname.TabIndex = 46;
            this.lbl_Firstname.Text = "First Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 534);
            this.Controls.Add(this.bttn_update);
            this.Controls.Add(this.bttn_delete);
            this.Controls.Add(this.bttn_view);
            this.Controls.Add(this.txt_Employeeid);
            this.Controls.Add(this.lbl_Employeeid);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_State);
            this.Controls.Add(this.bttn_submit);
            this.Controls.Add(this.grid_output);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.radiobttn_Male);
            this.Controls.Add(this.radiobttn_Female);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Heading);
            this.Controls.Add(this.txt_Phonenumber);
            this.Controls.Add(this.lbl_Phonenumber);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.lbl_Lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.lbl_Firstname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid_output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_update;
        private System.Windows.Forms.Button bttn_delete;
        private System.Windows.Forms.Button bttn_view;
        private System.Windows.Forms.TextBox txt_Employeeid;
        private System.Windows.Forms.Label lbl_Employeeid;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_State;
        private System.Windows.Forms.Button bttn_submit;
        private System.Windows.Forms.DataGridView grid_output;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.RadioButton radiobttn_Male;
        private System.Windows.Forms.RadioButton radiobttn_Female;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.TextBox txt_Phonenumber;
        private System.Windows.Forms.Label lbl_Phonenumber;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.Label lbl_Lastname;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.Label lbl_Firstname;
    }
}

