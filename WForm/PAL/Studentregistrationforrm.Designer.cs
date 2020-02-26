namespace PAL
{
    partial class Studentregistrationforrm
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
            this.bttn_update.Location = new System.Drawing.Point(343, 490);
            this.bttn_update.Name = "bttn_update";
            this.bttn_update.Size = new System.Drawing.Size(94, 35);
            this.bttn_update.TabIndex = 87;
            this.bttn_update.Text = "update";
            this.bttn_update.UseVisualStyleBackColor = true;
            this.bttn_update.Click += new System.EventHandler(this.bttn_update_Click);
            // 
            // bttn_delete
            // 
            this.bttn_delete.Location = new System.Drawing.Point(143, 490);
            this.bttn_delete.Name = "bttn_delete";
            this.bttn_delete.Size = new System.Drawing.Size(94, 35);
            this.bttn_delete.TabIndex = 86;
            this.bttn_delete.Text = "delete";
            this.bttn_delete.UseVisualStyleBackColor = true;
            this.bttn_delete.Click += new System.EventHandler(this.bttn_delete_Click);
            // 
            // bttn_view
            // 
            this.bttn_view.Location = new System.Drawing.Point(243, 490);
            this.bttn_view.Name = "bttn_view";
            this.bttn_view.Size = new System.Drawing.Size(94, 35);
            this.bttn_view.TabIndex = 85;
            this.bttn_view.Text = "View";
            this.bttn_view.UseVisualStyleBackColor = true;
            this.bttn_view.Click += new System.EventHandler(this.bttn_view_Click);
            // 
            // txt_Employeeid
            // 
            this.txt_Employeeid.Location = new System.Drawing.Point(243, 433);
            this.txt_Employeeid.Name = "txt_Employeeid";
            this.txt_Employeeid.Size = new System.Drawing.Size(100, 22);
            this.txt_Employeeid.TabIndex = 84;
            // 
            // lbl_Employeeid
            // 
            this.lbl_Employeeid.AutoSize = true;
            this.lbl_Employeeid.Location = new System.Drawing.Point(144, 436);
            this.lbl_Employeeid.Name = "lbl_Employeeid";
            this.lbl_Employeeid.Size = new System.Drawing.Size(85, 17);
            this.lbl_Employeeid.TabIndex = 83;
            this.lbl_Employeeid.Text = "Employee id";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(243, 405);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 22);
            this.txt_City.TabIndex = 82;
            // 
            // txt_State
            // 
            this.txt_State.Location = new System.Drawing.Point(243, 363);
            this.txt_State.Name = "txt_State";
            this.txt_State.Size = new System.Drawing.Size(100, 22);
            this.txt_State.TabIndex = 81;
            // 
            // bttn_submit
            // 
            this.bttn_submit.Location = new System.Drawing.Point(43, 490);
            this.bttn_submit.Name = "bttn_submit";
            this.bttn_submit.Size = new System.Drawing.Size(94, 35);
            this.bttn_submit.TabIndex = 80;
            this.bttn_submit.Text = "Add";
            this.bttn_submit.UseVisualStyleBackColor = true;
            this.bttn_submit.Click += new System.EventHandler(this.bttn_submit_Click);
            // 
            // grid_output
            // 
            this.grid_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_output.Location = new System.Drawing.Point(495, 187);
            this.grid_output.Name = "grid_output";
            this.grid_output.RowTemplate.Height = 24;
            this.grid_output.Size = new System.Drawing.Size(762, 357);
            this.grid_output.TabIndex = 79;
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(145, 405);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(29, 17);
            this.lbl_City.TabIndex = 78;
            this.lbl_City.Text = "city";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Location = new System.Drawing.Point(145, 363);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(39, 17);
            this.lbl_State.TabIndex = 77;
            this.lbl_State.Text = "state";
            // 
            // radiobttn_Male
            // 
            this.radiobttn_Male.AutoSize = true;
            this.radiobttn_Male.Location = new System.Drawing.Point(225, 314);
            this.radiobttn_Male.Name = "radiobttn_Male";
            this.radiobttn_Male.Size = new System.Drawing.Size(59, 21);
            this.radiobttn_Male.TabIndex = 76;
            this.radiobttn_Male.TabStop = true;
            this.radiobttn_Male.Text = "male";
            this.radiobttn_Male.UseVisualStyleBackColor = true;
            // 
            // radiobttn_Female
            // 
            this.radiobttn_Female.AutoSize = true;
            this.radiobttn_Female.Location = new System.Drawing.Point(294, 316);
            this.radiobttn_Female.Name = "radiobttn_Female";
            this.radiobttn_Female.Size = new System.Drawing.Size(71, 21);
            this.radiobttn_Female.TabIndex = 75;
            this.radiobttn_Female.TabStop = true;
            this.radiobttn_Female.Text = "female";
            this.radiobttn_Female.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(145, 316);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(53, 17);
            this.lbl_Gender.TabIndex = 74;
            this.lbl_Gender.Text = "gender";
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_Heading.Location = new System.Drawing.Point(139, 123);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(508, 48);
            this.lbl_Heading.TabIndex = 73;
            this.lbl_Heading.Text = "Student Registration Form";
            // 
            // txt_Phonenumber
            // 
            this.txt_Phonenumber.Location = new System.Drawing.Point(243, 270);
            this.txt_Phonenumber.Name = "txt_Phonenumber";
            this.txt_Phonenumber.Size = new System.Drawing.Size(100, 22);
            this.txt_Phonenumber.TabIndex = 72;
            // 
            // lbl_Phonenumber
            // 
            this.lbl_Phonenumber.AutoSize = true;
            this.lbl_Phonenumber.Location = new System.Drawing.Point(144, 270);
            this.lbl_Phonenumber.Name = "lbl_Phonenumber";
            this.lbl_Phonenumber.Size = new System.Drawing.Size(100, 17);
            this.lbl_Phonenumber.TabIndex = 71;
            this.lbl_Phonenumber.Text = "phone number";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(243, 229);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(100, 22);
            this.txt_Lastname.TabIndex = 70;
            // 
            // lbl_Lastname
            // 
            this.lbl_Lastname.AutoSize = true;
            this.lbl_Lastname.Location = new System.Drawing.Point(144, 229);
            this.lbl_Lastname.Name = "lbl_Lastname";
            this.lbl_Lastname.Size = new System.Drawing.Size(76, 17);
            this.lbl_Lastname.TabIndex = 69;
            this.lbl_Lastname.Text = "Last Name";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Location = new System.Drawing.Point(243, 187);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(100, 22);
            this.txt_Firstname.TabIndex = 68;
            // 
            // lbl_Firstname
            // 
            this.lbl_Firstname.AutoSize = true;
            this.lbl_Firstname.Location = new System.Drawing.Point(144, 190);
            this.lbl_Firstname.Name = "lbl_Firstname";
            this.lbl_Firstname.Size = new System.Drawing.Size(76, 17);
            this.lbl_Firstname.TabIndex = 67;
            this.lbl_Firstname.Text = "First Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 765);
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
            this.Name = "Form2";
            this.Text = "Form2";
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