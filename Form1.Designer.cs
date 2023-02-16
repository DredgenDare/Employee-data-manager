namespace Programming_project
{
    partial class Employeedatemanager
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
            this.Readrichtxtbox1 = new System.Windows.Forms.RichTextBox();
            this.readtxtbox1 = new System.Windows.Forms.TextBox();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Readrichtxtbox1
            // 
            this.Readrichtxtbox1.Location = new System.Drawing.Point(324, 12);
            this.Readrichtxtbox1.Name = "Readrichtxtbox1";
            this.Readrichtxtbox1.Size = new System.Drawing.Size(272, 263);
            this.Readrichtxtbox1.TabIndex = 0;
            this.Readrichtxtbox1.Text = "";
            // 
            // readtxtbox1
            // 
            this.readtxtbox1.Location = new System.Drawing.Point(324, 281);
            this.readtxtbox1.Name = "readtxtbox1";
            this.readtxtbox1.Size = new System.Drawing.Size(272, 20);
            this.readtxtbox1.TabIndex = 1;
            // 
            // ReadBtn
            // 
            this.ReadBtn.BackColor = System.Drawing.Color.Maroon;
            this.ReadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadBtn.Location = new System.Drawing.Point(618, 89);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(272, 71);
            this.ReadBtn.TabIndex = 2;
            this.ReadBtn.Text = "Read employee file";
            this.ReadBtn.UseVisualStyleBackColor = false;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(132, 14);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(174, 20);
            this.FirstNameTb.TabIndex = 7;
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(132, 40);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(174, 20);
            this.LastNameTb.TabIndex = 8;
            // 
            // GenderCb
            // 
            this.GenderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.GenderCb.Location = new System.Drawing.Point(132, 73);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(174, 21);
            this.GenderCb.TabIndex = 9;
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(132, 108);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(174, 71);
            this.AddressTb.TabIndex = 10;
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.BackColor = System.Drawing.Color.Maroon;
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeBtn.Location = new System.Drawing.Point(132, 185);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(174, 71);
            this.AddEmployeeBtn.TabIndex = 11;
            this.AddEmployeeBtn.Text = "Add Employee";
            this.AddEmployeeBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.BackColor = System.Drawing.Color.Maroon;
            this.SelectFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFileBtn.Location = new System.Drawing.Point(618, 12);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(272, 71);
            this.SelectFileBtn.TabIndex = 12;
            this.SelectFileBtn.Text = "Select employee file";
            this.SelectFileBtn.UseVisualStyleBackColor = false;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Maroon;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(618, 166);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(272, 71);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Delete employee file";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Employeedatemanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(902, 310);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SelectFileBtn);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.LastNameTb);
            this.Controls.Add(this.FirstNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.readtxtbox1);
            this.Controls.Add(this.Readrichtxtbox1);
            this.Name = "Employeedatemanager";
            this.Text = "Employee data manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Readrichtxtbox1;
        private System.Windows.Forms.TextBox readtxtbox1;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Button SelectFileBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

