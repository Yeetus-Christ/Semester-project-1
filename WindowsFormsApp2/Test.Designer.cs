namespace WindowsFormsApp2
{
    partial class Test
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
            this.LectionName = new System.Windows.Forms.Label();
            this.LectureContent = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Questions = new System.Windows.Forms.Label();
            this.Q1B = new System.Windows.Forms.Button();
            this.Q5B = new System.Windows.Forms.Button();
            this.Q4B = new System.Windows.Forms.Button();
            this.Q3B = new System.Windows.Forms.Button();
            this.Q2B = new System.Windows.Forms.Button();
            this.QuestionGB = new System.Windows.Forms.GroupBox();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.FinishTest = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.QuestionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // LectionName
            // 
            this.LectionName.AutoSize = true;
            this.LectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LectionName.Location = new System.Drawing.Point(305, 9);
            this.LectionName.Name = "LectionName";
            this.LectionName.Size = new System.Drawing.Size(187, 33);
            this.LectionName.TabIndex = 0;
            this.LectionName.Text = "LectionName";
            // 
            // LectureContent
            // 
            this.LectureContent.Location = new System.Drawing.Point(1, 45);
            this.LectureContent.Multiline = true;
            this.LectureContent.Name = "LectureContent";
            this.LectureContent.ReadOnly = true;
            this.LectureContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LectureContent.Size = new System.Drawing.Size(795, 349);
            this.LectureContent.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(1, 400);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(142, 49);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitLecture);
            // 
            // TestButton
            // 
            this.TestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestButton.Location = new System.Drawing.Point(654, 400);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(142, 49);
            this.TestButton.TabIndex = 3;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.GoToTest);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 453);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Questions
            // 
            this.Questions.AutoSize = true;
            this.Questions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Questions.Location = new System.Drawing.Point(13, 13);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(122, 29);
            this.Questions.TabIndex = 5;
            this.Questions.Text = "Questions";
            this.Questions.Visible = false;
            // 
            // Q1B
            // 
            this.Q1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Q1B.Location = new System.Drawing.Point(13, 46);
            this.Q1B.Name = "Q1B";
            this.Q1B.Size = new System.Drawing.Size(122, 48);
            this.Q1B.TabIndex = 6;
            this.Q1B.Text = "Question 1";
            this.Q1B.UseVisualStyleBackColor = true;
            this.Q1B.Visible = false;
            this.Q1B.Click += new System.EventHandler(this.Q1B_Click);
            // 
            // Q5B
            // 
            this.Q5B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Q5B.Location = new System.Drawing.Point(13, 262);
            this.Q5B.Name = "Q5B";
            this.Q5B.Size = new System.Drawing.Size(122, 48);
            this.Q5B.TabIndex = 7;
            this.Q5B.Text = "Question 5";
            this.Q5B.UseVisualStyleBackColor = true;
            this.Q5B.Visible = false;
            this.Q5B.Click += new System.EventHandler(this.Q5B_Click);
            // 
            // Q4B
            // 
            this.Q4B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Q4B.Location = new System.Drawing.Point(13, 208);
            this.Q4B.Name = "Q4B";
            this.Q4B.Size = new System.Drawing.Size(122, 48);
            this.Q4B.TabIndex = 8;
            this.Q4B.Text = "Question 4";
            this.Q4B.UseVisualStyleBackColor = true;
            this.Q4B.Visible = false;
            this.Q4B.Click += new System.EventHandler(this.Q4B_Click);
            // 
            // Q3B
            // 
            this.Q3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Q3B.Location = new System.Drawing.Point(13, 154);
            this.Q3B.Name = "Q3B";
            this.Q3B.Size = new System.Drawing.Size(122, 48);
            this.Q3B.TabIndex = 9;
            this.Q3B.Text = "Question 3";
            this.Q3B.UseVisualStyleBackColor = true;
            this.Q3B.Visible = false;
            this.Q3B.Click += new System.EventHandler(this.Q3B_Click);
            // 
            // Q2B
            // 
            this.Q2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Q2B.Location = new System.Drawing.Point(13, 100);
            this.Q2B.Name = "Q2B";
            this.Q2B.Size = new System.Drawing.Size(122, 48);
            this.Q2B.TabIndex = 10;
            this.Q2B.Text = "Question 2";
            this.Q2B.UseVisualStyleBackColor = true;
            this.Q2B.Visible = false;
            this.Q2B.Click += new System.EventHandler(this.Q2B_Click);
            // 
            // QuestionGB
            // 
            this.QuestionGB.Controls.Add(this.SaveButton);
            this.QuestionGB.Controls.Add(this.Answer4);
            this.QuestionGB.Controls.Add(this.Answer3);
            this.QuestionGB.Controls.Add(this.Answer2);
            this.QuestionGB.Controls.Add(this.Answer1);
            this.QuestionGB.Controls.Add(this.QuestionLabel);
            this.QuestionGB.Location = new System.Drawing.Point(141, 45);
            this.QuestionGB.Name = "QuestionGB";
            this.QuestionGB.Size = new System.Drawing.Size(655, 312);
            this.QuestionGB.TabIndex = 12;
            this.QuestionGB.TabStop = false;
            this.QuestionGB.Visible = false;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer4.Location = new System.Drawing.Point(28, 193);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(133, 28);
            this.Answer4.TabIndex = 4;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "radioButton4";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Visible = false;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3.Location = new System.Drawing.Point(28, 161);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(133, 28);
            this.Answer3.TabIndex = 3;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "radioButton3";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.Visible = false;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.Location = new System.Drawing.Point(28, 129);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(133, 28);
            this.Answer2.TabIndex = 2;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "radioButton2";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.Visible = false;
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.Location = new System.Drawing.Point(28, 97);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(133, 28);
            this.Answer1.TabIndex = 1;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "radioButton1";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.Visible = false;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(23, 21);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(98, 25);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Question";
            // 
            // FinishTest
            // 
            this.FinishTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishTest.Location = new System.Drawing.Point(622, 378);
            this.FinishTest.Name = "FinishTest";
            this.FinishTest.Size = new System.Drawing.Size(166, 60);
            this.FinishTest.TabIndex = 13;
            this.FinishTest.Text = "Finish";
            this.FinishTest.UseVisualStyleBackColor = true;
            this.FinishTest.Visible = false;
            this.FinishTest.Click += new System.EventHandler(this.FinishTest1);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(525, 258);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 48);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinishTest);
            this.Controls.Add(this.QuestionGB);
            this.Controls.Add(this.Q2B);
            this.Controls.Add(this.Q3B);
            this.Controls.Add(this.Q4B);
            this.Controls.Add(this.Q5B);
            this.Controls.Add(this.Q1B);
            this.Controls.Add(this.Questions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LectureContent);
            this.Controls.Add(this.LectionName);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.QuestionGB.ResumeLayout(false);
            this.QuestionGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LectionName;
        private System.Windows.Forms.TextBox LectureContent;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Questions;
        private System.Windows.Forms.Button Q1B;
        private System.Windows.Forms.Button Q5B;
        private System.Windows.Forms.Button Q4B;
        private System.Windows.Forms.Button Q3B;
        private System.Windows.Forms.Button Q2B;
        private System.Windows.Forms.GroupBox QuestionGB;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button FinishTest;
        private System.Windows.Forms.Button SaveButton;
    }
}