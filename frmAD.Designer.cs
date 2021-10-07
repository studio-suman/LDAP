
namespace ActiveDirectory
{
    partial class frmAD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAD));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchUserName = new System.Windows.Forms.Button();
            this.pnlblock1 = new System.Windows.Forms.GroupBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsernameDisplay = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTelephon = new System.Windows.Forms.Label();
            this.pnlblock2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.pnlblock1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address/Employee ID";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSearchUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSearchUser.Location = new System.Drawing.Point(153, 19);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(235, 20);
            this.txtSearchUser.TabIndex = 1;
            this.txtSearchUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchUser_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchUserName);
            this.groupBox1.Controls.Add(this.txtSearchUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Information";
            // 
            // btnSearchUserName
            // 
            this.btnSearchUserName.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSearchUserName.Location = new System.Drawing.Point(403, 19);
            this.btnSearchUserName.Name = "btnSearchUserName";
            this.btnSearchUserName.Size = new System.Drawing.Size(60, 23);
            this.btnSearchUserName.TabIndex = 4;
            this.btnSearchUserName.Text = "Search";
            this.btnSearchUserName.UseVisualStyleBackColor = true;
            this.btnSearchUserName.Click += new System.EventHandler(this.btnSearchUserName_Click);
            // 
            // pnlblock1
            // 
            this.pnlblock1.Controls.Add(this.lblTelephone);
            this.pnlblock1.Controls.Add(this.lblEmployeeID);
            this.pnlblock1.Controls.Add(this.label5);
            this.pnlblock1.Controls.Add(this.lblLastName);
            this.pnlblock1.Controls.Add(this.label4);
            this.pnlblock1.Controls.Add(this.lblFirstname);
            this.pnlblock1.Controls.Add(this.label3);
            this.pnlblock1.Controls.Add(this.label2);
            this.pnlblock1.Controls.Add(this.lblUsernameDisplay);
            this.pnlblock1.Controls.Add(this.lblEmailId);
            this.pnlblock1.Controls.Add(this.label7);
            this.pnlblock1.Controls.Add(this.lblTelephon);
            this.pnlblock1.Location = new System.Drawing.Point(18, 78);
            this.pnlblock1.Name = "pnlblock1";
            this.pnlblock1.Size = new System.Drawing.Size(466, 152);
            this.pnlblock1.TabIndex = 3;
            this.pnlblock1.TabStop = false;
            this.pnlblock1.Text = "Fetched Information";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(258, 33);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 13);
            this.lblTelephone.TabIndex = 32;
            this.lblTelephone.Text = "Telephone No. :";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(130, 81);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(97, 13);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "..............................";
            this.lblEmployeeID.Click += new System.EventHandler(this.lblEmployeeID_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "AD ID";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(130, 56);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(97, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "..............................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee ID";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(130, 33);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(97, 13);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "..............................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // lblUsernameDisplay
            // 
            this.lblUsernameDisplay.AutoSize = true;
            this.lblUsernameDisplay.Location = new System.Drawing.Point(130, 106);
            this.lblUsernameDisplay.Name = "lblUsernameDisplay";
            this.lblUsernameDisplay.Size = new System.Drawing.Size(97, 13);
            this.lblUsernameDisplay.TabIndex = 0;
            this.lblUsernameDisplay.Text = "..............................";
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(130, 128);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(97, 13);
            this.lblEmailId.TabIndex = 0;
            this.lblEmailId.Text = "..............................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email Address";
            // 
            // lblTelephon
            // 
            this.lblTelephon.AutoSize = true;
            this.lblTelephon.Location = new System.Drawing.Point(358, 33);
            this.lblTelephon.Name = "lblTelephon";
            this.lblTelephon.Size = new System.Drawing.Size(97, 13);
            this.lblTelephon.TabIndex = 0;
            this.lblTelephon.Text = "..............................";
            // 
            // pnlblock2
            // 
            this.pnlblock2.Location = new System.Drawing.Point(12, 65);
            this.pnlblock2.Name = "pnlblock2";
            this.pnlblock2.Size = new System.Drawing.Size(474, 170);
            this.pnlblock2.TabIndex = 1;
            this.pnlblock2.TabStop = false;
            // 
            // frmAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(509, 243);
            this.Controls.Add(this.pnlblock2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlblock1);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAD";
            this.Text = "LDAP Query";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlblock1.ResumeLayout(false);
            this.pnlblock1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchUserName;
        private System.Windows.Forms.GroupBox pnlblock1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox pnlblock2;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUsernameDisplay;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblTelephon;
    }
}

