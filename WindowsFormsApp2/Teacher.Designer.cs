namespace WindowsFormsApp2
{
    partial class Teacher
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditTestButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EnglishButton = new System.Windows.Forms.Button();
            this.OOPButton = new System.Windows.Forms.Button();
            this.CalculusButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.SNameLabel = new System.Windows.Forms.Label();
            this.SGroupLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SessionAmountLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LectureTextBox = new System.Windows.Forms.TextBox();
            this.ChoseLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LectName = new System.Windows.Forms.Label();
            this.LectNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pathText = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.LectureLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SubjectCB = new System.Windows.Forms.ComboBox();
            this.LectureCB = new System.Windows.Forms.ComboBox();
            this.QuestionCB = new System.Windows.Forms.ComboBox();
            this.QLabel = new System.Windows.Forms.Label();
            this.QTextBox = new System.Windows.Forms.TextBox();
            this.A1Label = new System.Windows.Forms.Label();
            this.A2Label = new System.Windows.Forms.Label();
            this.A3Label = new System.Windows.Forms.Label();
            this.A4Label = new System.Windows.Forms.Label();
            this.A1TextBox = new System.Windows.Forms.TextBox();
            this.A2TextBox = new System.Windows.Forms.TextBox();
            this.A3TextBox = new System.Windows.Forms.TextBox();
            this.A4TextBox = new System.Windows.Forms.TextBox();
            this.RQLabel = new System.Windows.Forms.Label();
            this.RQComboBox = new System.Windows.Forms.ComboBox();
            this.SaveTest = new System.Windows.Forms.Button();
            this.OOPLabel = new System.Windows.Forms.Label();
            this.CalculusLabel = new System.Windows.Forms.Label();
            this.EnglishLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "≡";
            this.label1.Click += new System.EventHandler(this.MiniMenuOn);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditTestButton);
            this.groupBox1.Controls.Add(this.StudentButton);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-2, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 468);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // EditTestButton
            // 
            this.EditTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditTestButton.Location = new System.Drawing.Point(0, 110);
            this.EditTestButton.Name = "EditTestButton";
            this.EditTestButton.Size = new System.Drawing.Size(125, 38);
            this.EditTestButton.TabIndex = 4;
            this.EditTestButton.Text = "Edit Tests";
            this.EditTestButton.UseVisualStyleBackColor = true;
            this.EditTestButton.Click += new System.EventHandler(this.OpenEditTests);
            // 
            // StudentButton
            // 
            this.StudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentButton.Location = new System.Drawing.Point(0, 148);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(125, 59);
            this.StudentButton.TabIndex = 3;
            this.StudentButton.Text = "Search for student";
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.ShowStudentSearch);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(0, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Main Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowMainPage);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowProfile);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(100, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "<";
            this.label2.Click += new System.EventHandler(this.MiniMenuOff);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(38, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(272, 39);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name Lastname";
            this.NameLabel.Visible = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(67, 82);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(74, 29);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Visible = false;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(147, 82);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(74, 29);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            this.Email.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(660, 383);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(128, 55);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit Profile";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitProfile);
            // 
            // EnglishButton
            // 
            this.EnglishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnglishButton.Location = new System.Drawing.Point(401, 94);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(186, 69);
            this.EnglishButton.TabIndex = 6;
            this.EnglishButton.Text = "English";
            this.EnglishButton.UseVisualStyleBackColor = true;
            this.EnglishButton.Click += new System.EventHandler(this.OpenEnglishLections);
            // 
            // OOPButton
            // 
            this.OOPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OOPButton.Location = new System.Drawing.Point(17, 94);
            this.OOPButton.Name = "OOPButton";
            this.OOPButton.Size = new System.Drawing.Size(186, 69);
            this.OOPButton.TabIndex = 7;
            this.OOPButton.Text = "OOP";
            this.OOPButton.UseVisualStyleBackColor = true;
            this.OOPButton.Click += new System.EventHandler(this.OpenOOPLections);
            // 
            // CalculusButton
            // 
            this.CalculusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculusButton.Location = new System.Drawing.Point(209, 94);
            this.CalculusButton.Name = "CalculusButton";
            this.CalculusButton.Size = new System.Drawing.Size(186, 69);
            this.CalculusButton.TabIndex = 8;
            this.CalculusButton.Text = "Calculus";
            this.CalculusButton.UseVisualStyleBackColor = true;
            this.CalculusButton.Click += new System.EventHandler(this.OpenCalculusLections);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available Courses";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentLabel.Location = new System.Drawing.Point(263, 9);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(252, 33);
            this.StudentLabel.TabIndex = 10;
            this.StudentLabel.Text = "Search for student";
            this.StudentLabel.Visible = false;
            // 
            // SNameLabel
            // 
            this.SNameLabel.AutoSize = true;
            this.SNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNameLabel.Location = new System.Drawing.Point(353, 66);
            this.SNameLabel.Name = "SNameLabel";
            this.SNameLabel.Size = new System.Drawing.Size(68, 25);
            this.SNameLabel.TabIndex = 11;
            this.SNameLabel.Text = "Name";
            this.SNameLabel.Visible = false;
            // 
            // SGroupLabel
            // 
            this.SGroupLabel.AutoSize = true;
            this.SGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SGroupLabel.Location = new System.Drawing.Point(350, 121);
            this.SGroupLabel.Name = "SGroupLabel";
            this.SGroupLabel.Size = new System.Drawing.Size(71, 25);
            this.SGroupLabel.TabIndex = 12;
            this.SGroupLabel.Text = "Group";
            this.SGroupLabel.Visible = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(324, 94);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(122, 20);
            this.NameTextBox.TabIndex = 13;
            this.NameTextBox.Visible = false;
            this.NameTextBox.WordWrap = false;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(324, 149);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(122, 20);
            this.GroupTextBox.TabIndex = 14;
            this.GroupTextBox.Visible = false;
            this.GroupTextBox.WordWrap = false;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(242, 244);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(258, 25);
            this.InfoLabel.TabIndex = 15;
            this.InfoLabel.Text = "Total amount of sessions:";
            this.InfoLabel.Visible = false;
            // 
            // SessionAmountLabel
            // 
            this.SessionAmountLabel.AutoSize = true;
            this.SessionAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SessionAmountLabel.Location = new System.Drawing.Point(506, 244);
            this.SessionAmountLabel.Name = "SessionAmountLabel";
            this.SessionAmountLabel.Size = new System.Drawing.Size(24, 25);
            this.SessionAmountLabel.TabIndex = 16;
            this.SessionAmountLabel.Text = "0";
            this.SessionAmountLabel.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(324, 175);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(122, 37);
            this.SearchButton.TabIndex = 40;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Visible = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchStudent);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(264, 215);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(242, 25);
            this.ErrorLabel.TabIndex = 41;
            this.ErrorLabel.Text = "There\'s no such student";
            this.ErrorLabel.Visible = false;
            // 
            // LectureTextBox
            // 
            this.LectureTextBox.Location = new System.Drawing.Point(227, 0);
            this.LectureTextBox.Multiline = true;
            this.LectureTextBox.Name = "LectureTextBox";
            this.LectureTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LectureTextBox.Size = new System.Drawing.Size(575, 397);
            this.LectureTextBox.TabIndex = 43;
            this.LectureTextBox.Visible = false;
            // 
            // ChoseLabel
            // 
            this.ChoseLabel.AutoSize = true;
            this.ChoseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoseLabel.Location = new System.Drawing.Point(12, 40);
            this.ChoseLabel.Name = "ChoseLabel";
            this.ChoseLabel.Size = new System.Drawing.Size(193, 25);
            this.ChoseLabel.TabIndex = 44;
            this.ChoseLabel.Text = "Choose the lecture";
            this.ChoseLabel.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 82);
            this.comboBox1.MaxDropDownItems = 7;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.LoadLecture);
            // 
            // LectName
            // 
            this.LectName.AutoSize = true;
            this.LectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LectName.Location = new System.Drawing.Point(12, 121);
            this.LectName.Name = "LectName";
            this.LectName.Size = new System.Drawing.Size(199, 25);
            this.LectName.TabIndex = 46;
            this.LectName.Text = "Name of the lecture";
            this.LectName.Visible = false;
            // 
            // LectNameTB
            // 
            this.LectNameTB.Location = new System.Drawing.Point(17, 159);
            this.LectNameTB.Name = "LectNameTB";
            this.LectNameTB.Size = new System.Drawing.Size(181, 20);
            this.LectNameTB.TabIndex = 47;
            this.LectNameTB.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Load lecture from txt file";
            this.label4.Visible = false;
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(260, 413);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(394, 20);
            this.pathText.TabIndex = 49;
            this.pathText.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(33, 200);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(151, 47);
            this.SaveButton.TabIndex = 50;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveLection);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 454);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(660, 397);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(142, 53);
            this.LoadButton.TabIndex = 52;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Visible = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadLectureFromFile);
            // 
            // LectureLabel
            // 
            this.LectureLabel.AutoSize = true;
            this.LectureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LectureLabel.Location = new System.Drawing.Point(21, 114);
            this.LectureLabel.Name = "LectureLabel";
            this.LectureLabel.Size = new System.Drawing.Size(157, 25);
            this.LectureLabel.TabIndex = 54;
            this.LectureLabel.Text = "Choose lecture";
            this.LectureLabel.Visible = false;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectLabel.Location = new System.Drawing.Point(23, 40);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(161, 25);
            this.SubjectLabel.TabIndex = 55;
            this.SubjectLabel.Text = "Choose subject";
            this.SubjectLabel.Visible = false;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(21, 186);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(174, 25);
            this.QuestionLabel.TabIndex = 56;
            this.QuestionLabel.Text = "Choose question";
            this.QuestionLabel.Visible = false;
            // 
            // SubjectCB
            // 
            this.SubjectCB.FormattingEnabled = true;
            this.SubjectCB.Location = new System.Drawing.Point(22, 80);
            this.SubjectCB.MaxDropDownItems = 3;
            this.SubjectCB.Name = "SubjectCB";
            this.SubjectCB.Size = new System.Drawing.Size(162, 21);
            this.SubjectCB.TabIndex = 57;
            this.SubjectCB.Text = "OOP";
            this.SubjectCB.Visible = false;
            // 
            // LectureCB
            // 
            this.LectureCB.FormattingEnabled = true;
            this.LectureCB.Location = new System.Drawing.Point(22, 152);
            this.LectureCB.MaxDropDownItems = 7;
            this.LectureCB.Name = "LectureCB";
            this.LectureCB.Size = new System.Drawing.Size(162, 21);
            this.LectureCB.TabIndex = 58;
            this.LectureCB.Text = "1";
            this.LectureCB.Visible = false;
            this.LectureCB.SelectedIndexChanged += new System.EventHandler(this.LectureCB_SelectedIndexChanged);
            // 
            // QuestionCB
            // 
            this.QuestionCB.FormattingEnabled = true;
            this.QuestionCB.Location = new System.Drawing.Point(22, 224);
            this.QuestionCB.MaxDropDownItems = 5;
            this.QuestionCB.Name = "QuestionCB";
            this.QuestionCB.Size = new System.Drawing.Size(162, 21);
            this.QuestionCB.TabIndex = 59;
            this.QuestionCB.Visible = false;
            this.QuestionCB.SelectedIndexChanged += new System.EventHandler(this.LoadTestQ);
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QLabel.Location = new System.Drawing.Point(227, 66);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(98, 25);
            this.QLabel.TabIndex = 60;
            this.QLabel.Text = "Question";
            this.QLabel.Visible = false;
            // 
            // QTextBox
            // 
            this.QTextBox.Location = new System.Drawing.Point(331, 68);
            this.QTextBox.Name = "QTextBox";
            this.QTextBox.Size = new System.Drawing.Size(430, 20);
            this.QTextBox.TabIndex = 61;
            this.QTextBox.Visible = false;
            // 
            // A1Label
            // 
            this.A1Label.AutoSize = true;
            this.A1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A1Label.Location = new System.Drawing.Point(227, 111);
            this.A1Label.Name = "A1Label";
            this.A1Label.Size = new System.Drawing.Size(101, 25);
            this.A1Label.TabIndex = 62;
            this.A1Label.Text = "Answer 1";
            this.A1Label.Visible = false;
            // 
            // A2Label
            // 
            this.A2Label.AutoSize = true;
            this.A2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A2Label.Location = new System.Drawing.Point(227, 156);
            this.A2Label.Name = "A2Label";
            this.A2Label.Size = new System.Drawing.Size(101, 25);
            this.A2Label.TabIndex = 63;
            this.A2Label.Text = "Answer 2";
            this.A2Label.Visible = false;
            // 
            // A3Label
            // 
            this.A3Label.AutoSize = true;
            this.A3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A3Label.Location = new System.Drawing.Point(227, 201);
            this.A3Label.Name = "A3Label";
            this.A3Label.Size = new System.Drawing.Size(101, 25);
            this.A3Label.TabIndex = 64;
            this.A3Label.Text = "Answer 3";
            this.A3Label.Visible = false;
            // 
            // A4Label
            // 
            this.A4Label.AutoSize = true;
            this.A4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A4Label.Location = new System.Drawing.Point(227, 246);
            this.A4Label.Name = "A4Label";
            this.A4Label.Size = new System.Drawing.Size(101, 25);
            this.A4Label.TabIndex = 65;
            this.A4Label.Text = "Answer 4";
            this.A4Label.Visible = false;
            // 
            // A1TextBox
            // 
            this.A1TextBox.Location = new System.Drawing.Point(331, 113);
            this.A1TextBox.Name = "A1TextBox";
            this.A1TextBox.Size = new System.Drawing.Size(430, 20);
            this.A1TextBox.TabIndex = 66;
            this.A1TextBox.Visible = false;
            // 
            // A2TextBox
            // 
            this.A2TextBox.Location = new System.Drawing.Point(331, 158);
            this.A2TextBox.Name = "A2TextBox";
            this.A2TextBox.Size = new System.Drawing.Size(430, 20);
            this.A2TextBox.TabIndex = 67;
            this.A2TextBox.Visible = false;
            // 
            // A3TextBox
            // 
            this.A3TextBox.Location = new System.Drawing.Point(331, 203);
            this.A3TextBox.Name = "A3TextBox";
            this.A3TextBox.Size = new System.Drawing.Size(430, 20);
            this.A3TextBox.TabIndex = 68;
            this.A3TextBox.Visible = false;
            // 
            // A4TextBox
            // 
            this.A4TextBox.Location = new System.Drawing.Point(331, 248);
            this.A4TextBox.Name = "A4TextBox";
            this.A4TextBox.Size = new System.Drawing.Size(430, 20);
            this.A4TextBox.TabIndex = 69;
            this.A4TextBox.Visible = false;
            // 
            // RQLabel
            // 
            this.RQLabel.AutoSize = true;
            this.RQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RQLabel.Location = new System.Drawing.Point(432, 290);
            this.RQLabel.Name = "RQLabel";
            this.RQLabel.Size = new System.Drawing.Size(209, 25);
            this.RQLabel.TabIndex = 70;
            this.RQLabel.Text = "Choose right answer";
            this.RQLabel.Visible = false;
            // 
            // RQComboBox
            // 
            this.RQComboBox.FormattingEnabled = true;
            this.RQComboBox.Location = new System.Drawing.Point(464, 318);
            this.RQComboBox.MaxDropDownItems = 4;
            this.RQComboBox.Name = "RQComboBox";
            this.RQComboBox.Size = new System.Drawing.Size(162, 21);
            this.RQComboBox.TabIndex = 71;
            this.RQComboBox.Visible = false;
            // 
            // SaveTest
            // 
            this.SaveTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTest.Location = new System.Drawing.Point(637, 366);
            this.SaveTest.Name = "SaveTest";
            this.SaveTest.Size = new System.Drawing.Size(151, 67);
            this.SaveTest.TabIndex = 72;
            this.SaveTest.Text = "Save";
            this.SaveTest.UseVisualStyleBackColor = true;
            this.SaveTest.Visible = false;
            this.SaveTest.Click += new System.EventHandler(this.SaveTest_Click);
            // 
            // OOPLabel
            // 
            this.OOPLabel.AutoSize = true;
            this.OOPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OOPLabel.Location = new System.Drawing.Point(303, 281);
            this.OOPLabel.Name = "OOPLabel";
            this.OOPLabel.Size = new System.Drawing.Size(58, 25);
            this.OOPLabel.TabIndex = 73;
            this.OOPLabel.Text = "OOP";
            this.OOPLabel.Visible = false;
            // 
            // CalculusLabel
            // 
            this.CalculusLabel.AutoSize = true;
            this.CalculusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculusLabel.Location = new System.Drawing.Point(303, 323);
            this.CalculusLabel.Name = "CalculusLabel";
            this.CalculusLabel.Size = new System.Drawing.Size(95, 25);
            this.CalculusLabel.TabIndex = 74;
            this.CalculusLabel.Text = "Calculus";
            this.CalculusLabel.Visible = false;
            // 
            // EnglishLabel
            // 
            this.EnglishLabel.AutoSize = true;
            this.EnglishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnglishLabel.Location = new System.Drawing.Point(303, 365);
            this.EnglishLabel.Name = "EnglishLabel";
            this.EnglishLabel.Size = new System.Drawing.Size(83, 25);
            this.EnglishLabel.TabIndex = 75;
            this.EnglishLabel.Text = "English";
            this.EnglishLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(432, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 76;
            this.label5.Text = "0";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(432, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(432, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EnglishLabel);
            this.Controls.Add(this.CalculusLabel);
            this.Controls.Add(this.OOPLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SessionAmountLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.SNameLabel);
            this.Controls.Add(this.SGroupLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalculusButton);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OOPButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.GroupTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.SaveTest);
            this.Controls.Add(this.RQComboBox);
            this.Controls.Add(this.RQLabel);
            this.Controls.Add(this.A4TextBox);
            this.Controls.Add(this.A3TextBox);
            this.Controls.Add(this.A2TextBox);
            this.Controls.Add(this.A1TextBox);
            this.Controls.Add(this.A4Label);
            this.Controls.Add(this.A3Label);
            this.Controls.Add(this.A2Label);
            this.Controls.Add(this.A1Label);
            this.Controls.Add(this.QTextBox);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.LectureTextBox);
            this.Controls.Add(this.QuestionCB);
            this.Controls.Add(this.LectureCB);
            this.Controls.Add(this.SubjectCB);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.LectureLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LectNameTB);
            this.Controls.Add(this.LectName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ChoseLabel);
            this.Name = "Teacher";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button EnglishButton;
        private System.Windows.Forms.Button OOPButton;
        private System.Windows.Forms.Button CalculusButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label SNameLabel;
        private System.Windows.Forms.Label SGroupLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label SessionAmountLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox LectureTextBox;
        private System.Windows.Forms.Label ChoseLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LectName;
        private System.Windows.Forms.TextBox LectNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button EditTestButton;
        private System.Windows.Forms.Label LectureLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.ComboBox SubjectCB;
        private System.Windows.Forms.ComboBox LectureCB;
        private System.Windows.Forms.ComboBox QuestionCB;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.TextBox QTextBox;
        private System.Windows.Forms.Label A1Label;
        private System.Windows.Forms.Label A2Label;
        private System.Windows.Forms.Label A3Label;
        private System.Windows.Forms.Label A4Label;
        private System.Windows.Forms.TextBox A1TextBox;
        private System.Windows.Forms.TextBox A2TextBox;
        private System.Windows.Forms.TextBox A3TextBox;
        private System.Windows.Forms.TextBox A4TextBox;
        private System.Windows.Forms.Label RQLabel;
        private System.Windows.Forms.ComboBox RQComboBox;
        private System.Windows.Forms.Button SaveTest;
        private System.Windows.Forms.Label OOPLabel;
        private System.Windows.Forms.Label CalculusLabel;
        private System.Windows.Forms.Label EnglishLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}