namespace WindowsFormsApp2
{
    partial class Student
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MarksButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.MarksLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.OOPLabel = new System.Windows.Forms.Label();
            this.CalculusLabel = new System.Windows.Forms.Label();
            this.EnglishLabel = new System.Windows.Forms.Label();
            this.OOPMarks = new System.Windows.Forms.Label();
            this.CalculusMarks = new System.Windows.Forms.Label();
            this.EnglishMarks = new System.Windows.Forms.Label();
            this.LectionsLabel = new System.Windows.Forms.Label();
            this.Lection1 = new System.Windows.Forms.Button();
            this.Lection2 = new System.Windows.Forms.Button();
            this.Lection3 = new System.Windows.Forms.Button();
            this.Lection4 = new System.Windows.Forms.Button();
            this.Lection5 = new System.Windows.Forms.Button();
            this.Lection6 = new System.Windows.Forms.Button();
            this.Lection7 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TotalStudyTimeLabel = new System.Windows.Forms.Label();
            this.StudyTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Courses";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(13, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "OOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowOOPLections);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(205, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calculus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowCalculusLections);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(397, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 69);
            this.button3.TabIndex = 3;
            this.button3.Text = "English";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowEnglishLections);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "≡";
            this.label4.Click += new System.EventHandler(this.OpenMiniMenu);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Enabled = false;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(37, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(272, 39);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name Lastname";
            this.NameLabel.Visible = false;
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Enabled = false;
            this.GroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLabel.Location = new System.Drawing.Point(160, 80);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(91, 29);
            this.GroupLabel.TabIndex = 8;
            this.GroupLabel.Text = "AS-193";
            this.GroupLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(74, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Group";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(80, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email";
            this.label8.Visible = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Enabled = false;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(160, 109);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(74, 29);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(0, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "Profile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ShowProfile);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(0, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 43);
            this.button5.TabIndex = 1;
            this.button5.Text = "Main page";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ShowMainPage);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(116, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "<";
            this.label3.Click += new System.EventHandler(this.CloseMiniMenu);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MarksButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(-2, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 459);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // MarksButton
            // 
            this.MarksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarksButton.Location = new System.Drawing.Point(0, 117);
            this.MarksButton.Name = "MarksButton";
            this.MarksButton.Size = new System.Drawing.Size(141, 43);
            this.MarksButton.TabIndex = 7;
            this.MarksButton.Text = "Marks";
            this.MarksButton.UseVisualStyleBackColor = true;
            this.MarksButton.Click += new System.EventHandler(this.ShowMarks);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(667, 387);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 51);
            this.button9.TabIndex = 13;
            this.button9.Text = "Exit profile";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.ExitProfile);
            // 
            // MarksLabel
            // 
            this.MarksLabel.AutoSize = true;
            this.MarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarksLabel.Location = new System.Drawing.Point(223, 15);
            this.MarksLabel.Name = "MarksLabel";
            this.MarksLabel.Size = new System.Drawing.Size(88, 31);
            this.MarksLabel.TabIndex = 15;
            this.MarksLabel.Text = "Marks";
            this.MarksLabel.Visible = false;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectLabel.Location = new System.Drawing.Point(53, 15);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(105, 31);
            this.subjectLabel.TabIndex = 16;
            this.subjectLabel.Text = "Subject";
            this.subjectLabel.Visible = false;
            // 
            // OOPLabel
            // 
            this.OOPLabel.AutoSize = true;
            this.OOPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OOPLabel.Location = new System.Drawing.Point(53, 54);
            this.OOPLabel.Name = "OOPLabel";
            this.OOPLabel.Size = new System.Drawing.Size(67, 29);
            this.OOPLabel.TabIndex = 17;
            this.OOPLabel.Text = "OOP";
            this.OOPLabel.Visible = false;
            // 
            // CalculusLabel
            // 
            this.CalculusLabel.AutoSize = true;
            this.CalculusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculusLabel.Location = new System.Drawing.Point(53, 105);
            this.CalculusLabel.Name = "CalculusLabel";
            this.CalculusLabel.Size = new System.Drawing.Size(105, 29);
            this.CalculusLabel.TabIndex = 18;
            this.CalculusLabel.Text = "Calculus";
            this.CalculusLabel.Visible = false;
            // 
            // EnglishLabel
            // 
            this.EnglishLabel.AutoSize = true;
            this.EnglishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnglishLabel.Location = new System.Drawing.Point(53, 156);
            this.EnglishLabel.Name = "EnglishLabel";
            this.EnglishLabel.Size = new System.Drawing.Size(93, 29);
            this.EnglishLabel.TabIndex = 19;
            this.EnglishLabel.Text = "English";
            this.EnglishLabel.Visible = false;
            // 
            // OOPMarks
            // 
            this.OOPMarks.AutoSize = true;
            this.OOPMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OOPMarks.Location = new System.Drawing.Point(257, 54);
            this.OOPMarks.Name = "OOPMarks";
            this.OOPMarks.Size = new System.Drawing.Size(21, 29);
            this.OOPMarks.TabIndex = 20;
            this.OOPMarks.Text = "-";
            this.OOPMarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OOPMarks.Visible = false;
            // 
            // CalculusMarks
            // 
            this.CalculusMarks.AutoSize = true;
            this.CalculusMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculusMarks.Location = new System.Drawing.Point(257, 105);
            this.CalculusMarks.Name = "CalculusMarks";
            this.CalculusMarks.Size = new System.Drawing.Size(21, 29);
            this.CalculusMarks.TabIndex = 21;
            this.CalculusMarks.Text = "-";
            this.CalculusMarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CalculusMarks.Visible = false;
            // 
            // EnglishMarks
            // 
            this.EnglishMarks.AutoSize = true;
            this.EnglishMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnglishMarks.Location = new System.Drawing.Point(257, 156);
            this.EnglishMarks.Name = "EnglishMarks";
            this.EnglishMarks.Size = new System.Drawing.Size(21, 29);
            this.EnglishMarks.TabIndex = 22;
            this.EnglishMarks.Text = "-";
            this.EnglishMarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnglishMarks.Visible = false;
            // 
            // LectionsLabel
            // 
            this.LectionsLabel.AutoSize = true;
            this.LectionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LectionsLabel.Location = new System.Drawing.Point(345, 13);
            this.LectionsLabel.Name = "LectionsLabel";
            this.LectionsLabel.Size = new System.Drawing.Size(124, 33);
            this.LectionsLabel.TabIndex = 24;
            this.LectionsLabel.Text = "Lections";
            this.LectionsLabel.Visible = false;
            // 
            // Lection1
            // 
            this.Lection1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lection1.Location = new System.Drawing.Point(59, 66);
            this.Lection1.Name = "Lection1";
            this.Lection1.Size = new System.Drawing.Size(151, 53);
            this.Lection1.TabIndex = 25;
            this.Lection1.Text = "Lection1";
            this.Lection1.UseVisualStyleBackColor = true;
            this.Lection1.Visible = false;
            this.Lection1.Click += new System.EventHandler(this.OpenLection1);
            // 
            // Lection2
            // 
            this.Lection2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lection2.Location = new System.Drawing.Point(318, 68);
            this.Lection2.Name = "Lection2";
            this.Lection2.Size = new System.Drawing.Size(151, 53);
            this.Lection2.TabIndex = 26;
            this.Lection2.Text = "Lection2";
            this.Lection2.UseVisualStyleBackColor = true;
            this.Lection2.Visible = false;
            this.Lection2.Click += new System.EventHandler(this.OpenLection2);
            // 
            // Lection3
            // 
            this.Lection3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lection3.Location = new System.Drawing.Point(589, 68);
            this.Lection3.Name = "Lection3";
            this.Lection3.Size = new System.Drawing.Size(151, 53);
            this.Lection3.TabIndex = 27;
            this.Lection3.Text = "Lection3";
            this.Lection3.UseVisualStyleBackColor = true;
            this.Lection3.Visible = false;
            this.Lection3.Click += new System.EventHandler(this.OpenLection3);
            // 
            // Lection4
            // 
            this.Lection4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lection4.Location = new System.Drawing.Point(59, 148);
            this.Lection4.Name = "Lection4";
            this.Lection4.Size = new System.Drawing.Size(151, 53);
            this.Lection4.TabIndex = 28;
            this.Lection4.Text = "Lection4";
            this.Lection4.UseVisualStyleBackColor = true;
            this.Lection4.Visible = false;
            this.Lection4.Click += new System.EventHandler(this.OpenLection4);
            // 
            // Lection5
            // 
            this.Lection5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lection5.Location = new System.Drawing.Point(318, 148);
            this.Lection5.Name = "Lection5";
            this.Lection5.Size = new System.Drawing.Size(151, 53);
            this.Lection5.TabIndex = 29;
            this.Lection5.Text = "Lection5";
            this.Lection5.UseVisualStyleBackColor = true;
            this.Lection5.Visible = false;
            this.Lection5.Click += new System.EventHandler(this.OpenLection5);
            // 
            // Lection6
            // 
            this.Lection6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lection6.Location = new System.Drawing.Point(589, 148);
            this.Lection6.Name = "Lection6";
            this.Lection6.Size = new System.Drawing.Size(151, 53);
            this.Lection6.TabIndex = 30;
            this.Lection6.Text = "Lection6";
            this.Lection6.UseVisualStyleBackColor = true;
            this.Lection6.Visible = false;
            this.Lection6.Click += new System.EventHandler(this.OpenLection6);
            // 
            // Lection7
            // 
            this.Lection7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lection7.Location = new System.Drawing.Point(59, 234);
            this.Lection7.Name = "Lection7";
            this.Lection7.Size = new System.Drawing.Size(151, 53);
            this.Lection7.TabIndex = 31;
            this.Lection7.Text = "Lection7";
            this.Lection7.UseVisualStyleBackColor = true;
            this.Lection7.Visible = false;
            this.Lection7.Click += new System.EventHandler(this.OpenLection7);
            // 
            // TotalStudyTimeLabel
            // 
            this.TotalStudyTimeLabel.AutoSize = true;
            this.TotalStudyTimeLabel.Enabled = false;
            this.TotalStudyTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalStudyTimeLabel.Location = new System.Drawing.Point(53, 138);
            this.TotalStudyTimeLabel.Name = "TotalStudyTimeLabel";
            this.TotalStudyTimeLabel.Size = new System.Drawing.Size(202, 29);
            this.TotalStudyTimeLabel.TabIndex = 32;
            this.TotalStudyTimeLabel.Text = "Total Study Time:";
            this.TotalStudyTimeLabel.Visible = false;
            // 
            // StudyTime
            // 
            this.StudyTime.AutoSize = true;
            this.StudyTime.Enabled = false;
            this.StudyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudyTime.Location = new System.Drawing.Point(54, 172);
            this.StudyTime.Name = "StudyTime";
            this.StudyTime.Size = new System.Drawing.Size(21, 29);
            this.StudyTime.TabIndex = 33;
            this.StudyTime.Text = "-";
            this.StudyTime.Visible = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StudyTime);
            this.Controls.Add(this.TotalStudyTimeLabel);
            this.Controls.Add(this.LectionsLabel);
            this.Controls.Add(this.EnglishMarks);
            this.Controls.Add(this.CalculusMarks);
            this.Controls.Add(this.OOPMarks);
            this.Controls.Add(this.EnglishLabel);
            this.Controls.Add(this.CalculusLabel);
            this.Controls.Add(this.OOPLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.MarksLabel);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lection6);
            this.Controls.Add(this.Lection5);
            this.Controls.Add(this.Lection4);
            this.Controls.Add(this.Lection3);
            this.Controls.Add(this.Lection2);
            this.Controls.Add(this.Lection1);
            this.Controls.Add(this.Lection7);
            this.Name = "Student";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button MarksButton;
        private System.Windows.Forms.Label MarksLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label OOPLabel;
        private System.Windows.Forms.Label CalculusLabel;
        private System.Windows.Forms.Label EnglishLabel;
        private System.Windows.Forms.Label OOPMarks;
        private System.Windows.Forms.Label CalculusMarks;
        private System.Windows.Forms.Label EnglishMarks;
        private System.Windows.Forms.Label LectionsLabel;
        private System.Windows.Forms.Button Lection1;
        private System.Windows.Forms.Button Lection2;
        private System.Windows.Forms.Button Lection3;
        private System.Windows.Forms.Button Lection4;
        private System.Windows.Forms.Button Lection5;
        private System.Windows.Forms.Button Lection6;
        private System.Windows.Forms.Button Lection7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label TotalStudyTimeLabel;
        private System.Windows.Forms.Label StudyTime;
    }
}