namespace dbexample
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmembership = new System.Windows.Forms.Label();
            this.lblshopping = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(109, 78);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(81, 15);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter name";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.ForeColor = System.Drawing.Color.White;
            this.lblgender.Location = new System.Drawing.Point(109, 115);
            this.lblgender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(100, 15);
            this.lblgender.TabIndex = 1;
            this.lblgender.Text = "Select gender ";
            // 
            // lblmembership
            // 
            this.lblmembership.AutoSize = true;
            this.lblmembership.Location = new System.Drawing.Point(109, 158);
            this.lblmembership.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmembership.Name = "lblmembership";
            this.lblmembership.Size = new System.Drawing.Size(131, 15);
            this.lblmembership.TabIndex = 2;
            this.lblmembership.Text = "Select Membership";
            // 
            // lblshopping
            // 
            this.lblshopping.AutoSize = true;
            this.lblshopping.Location = new System.Drawing.Point(109, 197);
            this.lblshopping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshopping.Name = "lblshopping";
            this.lblshopping.Size = new System.Drawing.Size(185, 15);
            this.lblshopping.TabIndex = 3;
            this.lblshopping.Text = "Select Shopping perference";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(109, 360);
            this.lblcod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(73, 15);
            this.lblcod.TabIndex = 4;
            this.lblcod.Text = "pefer COD";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(109, 406);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(107, 15);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Enter Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(335, 69);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 21);
            this.txtname.TabIndex = 6;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(335, 105);
            this.cbgender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(181, 23);
            this.cbgender.TabIndex = 7;
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(335, 152);
            this.rbfree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(54, 19);
            this.rbfree.TabIndex = 8;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "Free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(516, 152);
            this.rbpaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(54, 19);
            this.rbpaid.TabIndex = 9;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "Paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            // 
            // clbshop
            // 
            this.clbshop.FormattingEnabled = true;
            this.clbshop.Items.AddRange(new object[] {
            "Cosmectics",
            "shoes",
            "Mobiles",
            "laptops",
            "Electronic gadgets",
            "Apparels",
            "kitchen Items"});
            this.clbshop.Location = new System.Drawing.Point(335, 197);
            this.clbshop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(241, 100);
            this.clbshop.TabIndex = 10;
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(335, 355);
            this.cbcod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(63, 19);
            this.cbcod.TabIndex = 11;
            this.cbcod.Text = "COD?";
            this.cbcod.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(335, 400);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(241, 21);
            this.txtpassword.TabIndex = 12;
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Olive;
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(195, 448);
            this.btnregister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(100, 27);
            this.btnregister.TabIndex = 13;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.Olive;
            this.btnselect.Location = new System.Drawing.Point(335, 448);
            this.btnselect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(100, 27);
            this.btnselect.TabIndex = 14;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 15;
            this.lbselect.Location = new System.Drawing.Point(854, 69);
            this.lbselect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(255, 274);
            this.lbselect.TabIndex = 15;
            // 
            // cbId
            // 
            this.cbId.DisplayMember = "Name";
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(335, 31);
            this.cbId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(160, 23);
            this.cbId.TabIndex = 16;
            this.cbId.ValueMember = "Id";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Olive;
            this.btndelete.Location = new System.Drawing.Point(477, 448);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 27);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1348, 503);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbcod);
            this.Controls.Add(this.clbshop);
            this.Controls.Add(this.rbpaid);
            this.Controls.Add(this.rbfree);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblshopping);
            this.Controls.Add(this.lblmembership);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmembership;
        private System.Windows.Forms.Label lblshopping;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Button btndelete;


    }
}