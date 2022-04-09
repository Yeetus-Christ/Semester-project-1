namespace WindowsFormsApp2
{
    partial class Login
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel2 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel2 = new System.Windows.Forms.Label();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.ReferenceNumberTextBox = new System.Windows.Forms.TextBox();
            this.ReferenceNumberLabel = new System.Windows.Forms.Label();
            this.RegisterButton2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TeacherCheckBox = new System.Windows.Forms.CheckBox();
            this.StudentTextBox = new System.Windows.Forms.CheckBox();
            this.asLabel1 = new System.Windows.Forms.Label();
            this.asLabel2 = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LoginError = new System.Windows.Forms.Label();
            this.EmailError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.RepeatPasswordError = new System.Windows.Forms.Label();
            this.RefNumError = new System.Windows.Forms.Label();
            this.RepeatPasswordError2 = new System.Windows.Forms.Label();
            this.RefNumError2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(310, 102);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(179, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(310, 165);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(179, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(371, 75);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(57, 24);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(353, 138);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(92, 24);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(310, 204);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(90, 35);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginIntoAccount);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(310, 255);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(90, 35);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegistrationWindow);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(23, 61);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.Visible = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(23, 111);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(179, 20);
            this.EmailTextBox.TabIndex = 7;
            this.EmailTextBox.Visible = false;
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.Location = new System.Drawing.Point(23, 161);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.Size = new System.Drawing.Size(179, 20);
            this.PasswordTextBox2.TabIndex = 8;
            this.PasswordTextBox2.Visible = false;
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(23, 211);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(179, 20);
            this.RepeatPasswordTextBox.TabIndex = 9;
            this.RepeatPasswordTextBox.Visible = false;
            // 
            // LoginLabel2
            // 
            this.LoginLabel2.AutoSize = true;
            this.LoginLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel2.Location = new System.Drawing.Point(19, 34);
            this.LoginLabel2.Name = "LoginLabel2";
            this.LoginLabel2.Size = new System.Drawing.Size(57, 24);
            this.LoginLabel2.TabIndex = 10;
            this.LoginLabel2.Text = "Login";
            this.LoginLabel2.Visible = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(19, 84);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(57, 24);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Visible = false;
            // 
            // PasswordLabel2
            // 
            this.PasswordLabel2.AutoSize = true;
            this.PasswordLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel2.Location = new System.Drawing.Point(19, 134);
            this.PasswordLabel2.Name = "PasswordLabel2";
            this.PasswordLabel2.Size = new System.Drawing.Size(92, 24);
            this.PasswordLabel2.TabIndex = 12;
            this.PasswordLabel2.Text = "Password";
            this.PasswordLabel2.Visible = false;
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(19, 184);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(156, 24);
            this.RepeatPasswordLabel.TabIndex = 13;
            this.RepeatPasswordLabel.Text = "Repeat password";
            this.RepeatPasswordLabel.Visible = false;
            // 
            // ReferenceNumberTextBox
            // 
            this.ReferenceNumberTextBox.Location = new System.Drawing.Point(23, 261);
            this.ReferenceNumberTextBox.Name = "ReferenceNumberTextBox";
            this.ReferenceNumberTextBox.Size = new System.Drawing.Size(179, 20);
            this.ReferenceNumberTextBox.TabIndex = 14;
            this.ReferenceNumberTextBox.Visible = false;
            // 
            // ReferenceNumberLabel
            // 
            this.ReferenceNumberLabel.AutoSize = true;
            this.ReferenceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReferenceNumberLabel.Location = new System.Drawing.Point(23, 234);
            this.ReferenceNumberLabel.Name = "ReferenceNumberLabel";
            this.ReferenceNumberLabel.Size = new System.Drawing.Size(169, 24);
            this.ReferenceNumberLabel.TabIndex = 15;
            this.ReferenceNumberLabel.Text = "Reference number";
            this.ReferenceNumberLabel.Visible = false;
            // 
            // RegisterButton2
            // 
            this.RegisterButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton2.Location = new System.Drawing.Point(21, 287);
            this.RegisterButton2.Name = "RegisterButton2";
            this.RegisterButton2.Size = new System.Drawing.Size(90, 35);
            this.RegisterButton2.TabIndex = 16;
            this.RegisterButton2.Text = "Register";
            this.RegisterButton2.UseVisualStyleBackColor = true;
            this.RegisterButton2.Visible = false;
            this.RegisterButton2.Click += new System.EventHandler(this.RegisterNewAccount);
            // 
            // TeacherCheckBox
            // 
            this.TeacherCheckBox.AutoSize = true;
            this.TeacherCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherCheckBox.Location = new System.Drawing.Point(436, 204);
            this.TeacherCheckBox.Name = "TeacherCheckBox";
            this.TeacherCheckBox.Size = new System.Drawing.Size(78, 20);
            this.TeacherCheckBox.TabIndex = 17;
            this.TeacherCheckBox.Text = "Teacher";
            this.TeacherCheckBox.UseVisualStyleBackColor = true;
            this.TeacherCheckBox.CheckedChanged += new System.EventHandler(this.CheckTeacher);
            // 
            // StudentTextBox
            // 
            this.StudentTextBox.AutoSize = true;
            this.StudentTextBox.Checked = true;
            this.StudentTextBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StudentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentTextBox.Location = new System.Drawing.Point(436, 222);
            this.StudentTextBox.Name = "StudentTextBox";
            this.StudentTextBox.Size = new System.Drawing.Size(72, 20);
            this.StudentTextBox.TabIndex = 18;
            this.StudentTextBox.Text = "Student";
            this.StudentTextBox.UseVisualStyleBackColor = true;
            this.StudentTextBox.CheckedChanged += new System.EventHandler(this.CheckStudent);
            // 
            // asLabel1
            // 
            this.asLabel1.AutoSize = true;
            this.asLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asLabel1.Location = new System.Drawing.Point(406, 212);
            this.asLabel1.Name = "asLabel1";
            this.asLabel1.Size = new System.Drawing.Size(24, 18);
            this.asLabel1.TabIndex = 19;
            this.asLabel1.Text = "as";
            // 
            // asLabel2
            // 
            this.asLabel2.AutoSize = true;
            this.asLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asLabel2.Location = new System.Drawing.Point(406, 263);
            this.asLabel2.Name = "asLabel2";
            this.asLabel2.Size = new System.Drawing.Size(24, 18);
            this.asLabel2.TabIndex = 21;
            this.asLabel2.Text = "as";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentLabel.Location = new System.Drawing.Point(441, 263);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(58, 18);
            this.StudentLabel.TabIndex = 22;
            this.StudentLabel.Text = "Student";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(283, 312);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(231, 20);
            this.ErrorLabel.TabIndex = 23;
            this.ErrorLabel.Text = "Password or Login are incorrect";
            this.ErrorLabel.Visible = false;
            // 
            // LoginError
            // 
            this.LoginError.AutoSize = true;
            this.LoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginError.ForeColor = System.Drawing.Color.Red;
            this.LoginError.Location = new System.Drawing.Point(214, 59);
            this.LoginError.Name = "LoginError";
            this.LoginError.Size = new System.Drawing.Size(91, 20);
            this.LoginError.TabIndex = 24;
            this.LoginError.Text = "Enter Login";
            this.LoginError.Visible = false;
            // 
            // EmailError
            // 
            this.EmailError.AutoSize = true;
            this.EmailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailError.ForeColor = System.Drawing.Color.Red;
            this.EmailError.Location = new System.Drawing.Point(214, 109);
            this.EmailError.Name = "EmailError";
            this.EmailError.Size = new System.Drawing.Size(91, 20);
            this.EmailError.TabIndex = 25;
            this.EmailError.Text = "Enter Email";
            this.EmailError.Visible = false;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordError.ForeColor = System.Drawing.Color.Red;
            this.PasswordError.Location = new System.Drawing.Point(214, 159);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(121, 20);
            this.PasswordError.TabIndex = 26;
            this.PasswordError.Text = "Enter Password";
            this.PasswordError.Visible = false;
            // 
            // RepeatPasswordError
            // 
            this.RepeatPasswordError.AutoSize = true;
            this.RepeatPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPasswordError.ForeColor = System.Drawing.Color.Red;
            this.RepeatPasswordError.Location = new System.Drawing.Point(214, 209);
            this.RepeatPasswordError.Name = "RepeatPasswordError";
            this.RepeatPasswordError.Size = new System.Drawing.Size(135, 20);
            this.RepeatPasswordError.TabIndex = 27;
            this.RepeatPasswordError.Text = "Repeat Password";
            this.RepeatPasswordError.Visible = false;
            // 
            // RefNumError
            // 
            this.RefNumError.AutoSize = true;
            this.RefNumError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefNumError.ForeColor = System.Drawing.Color.Red;
            this.RefNumError.Location = new System.Drawing.Point(214, 259);
            this.RefNumError.Name = "RefNumError";
            this.RefNumError.Size = new System.Drawing.Size(174, 20);
            this.RefNumError.TabIndex = 28;
            this.RefNumError.Text = "Enter Reference Nuber";
            this.RefNumError.Visible = false;
            // 
            // RepeatPasswordError2
            // 
            this.RepeatPasswordError2.AutoSize = true;
            this.RepeatPasswordError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPasswordError2.ForeColor = System.Drawing.Color.Red;
            this.RepeatPasswordError2.Location = new System.Drawing.Point(218, 209);
            this.RepeatPasswordError2.Name = "RepeatPasswordError2";
            this.RepeatPasswordError2.Size = new System.Drawing.Size(182, 20);
            this.RepeatPasswordError2.TabIndex = 29;
            this.RepeatPasswordError2.Text = "Password doesn\'t match";
            this.RepeatPasswordError2.Visible = false;
            // 
            // RefNumError2
            // 
            this.RefNumError2.AutoSize = true;
            this.RefNumError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefNumError2.ForeColor = System.Drawing.Color.Red;
            this.RefNumError2.Location = new System.Drawing.Point(218, 261);
            this.RefNumError2.Name = "RefNumError2";
            this.RefNumError2.Size = new System.Drawing.Size(375, 20);
            this.RefNumError2.TabIndex = 30;
            this.RefNumError2.Text = "This number has already been taken or doesn\'t exist";
            this.RefNumError2.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(112, 287);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(90, 35);
            this.BackButton.TabIndex = 31;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.ReturnToLogin);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RefNumError2);
            this.Controls.Add(this.RepeatPasswordError2);
            this.Controls.Add(this.RefNumError);
            this.Controls.Add(this.RepeatPasswordError);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.EmailError);
            this.Controls.Add(this.LoginError);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.asLabel2);
            this.Controls.Add(this.asLabel1);
            this.Controls.Add(this.StudentTextBox);
            this.Controls.Add(this.TeacherCheckBox);
            this.Controls.Add(this.RegisterButton2);
            this.Controls.Add(this.ReferenceNumberLabel);
            this.Controls.Add(this.ReferenceNumberTextBox);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel2);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginLabel2);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox2);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.TextBox RepeatPasswordTextBox;
        private System.Windows.Forms.Label LoginLabel2;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel2;
        private System.Windows.Forms.Label RepeatPasswordLabel;
        private System.Windows.Forms.TextBox ReferenceNumberTextBox;
        private System.Windows.Forms.Label ReferenceNumberLabel;
        private System.Windows.Forms.Button RegisterButton2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox TeacherCheckBox;
        private System.Windows.Forms.CheckBox StudentTextBox;
        private System.Windows.Forms.Label asLabel1;
        private System.Windows.Forms.Label asLabel2;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label LoginError;
        private System.Windows.Forms.Label EmailError;
        private System.Windows.Forms.Label PasswordError;
        private System.Windows.Forms.Label RepeatPasswordError;
        private System.Windows.Forms.Label RefNumError;
        private System.Windows.Forms.Label RepeatPasswordError2;
        private System.Windows.Forms.Label RefNumError2;
        private System.Windows.Forms.Button BackButton;
    }
}

