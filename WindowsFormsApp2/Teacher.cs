using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp2
{
    public partial class Teacher : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MR9T8DF\\YEET;Initial Catalog=Students;Integrated Security=True");
        bool oop = false;
        bool calculus = false;
        bool english = false;
        string lectionString;
        public Teacher()
        {
            InitializeComponent();
        }
        public void SetName(string name, string email)
        {
            NameLabel.Text = name;
            Email.Text = email;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }
        private void MiniMenuOn(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label1.Visible = false;
        }
        private void MiniMenuOff(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            label1.Visible = true;
        }
        private void ShowProfile(object sender, EventArgs e)
        {
            ProfileOn();
            MainPageOff();
            EditTestsOff();
            StudentSearchOff();
            LectionsOff();
        }
        private void ShowMainPage(object sender, EventArgs e)
        {
            ProfileOff();
            EditTestsOff();
            MainPageOn();
            StudentSearchOff();
            LectionsOff();
        }
        private void ExitProfile(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
        private void SearchStudent(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Students where Name = '" + NameTextBox.Text + "' and [Group] = '" + GroupTextBox.Text + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                SessionAmountLabel.Text = rd.GetInt32(10).ToString();
                label5.Text = rd.GetFloat(7).ToString();
                label6.Text = rd.GetFloat(8).ToString();
                label7.Text = rd.GetFloat(9).ToString();
                con.Close();
            }
            else
            {
                ErrorLabel.Visible = true;
                con.Close();
            }
        }
        private void ShowStudentSearch(object sender, EventArgs e)
        {
            ProfileOff();
            MainPageOff();
            EditTestsOff();
            StudentSearchOn();
            LectionsOff();
        }
        private void StudentSearchOn()
        {
            SNameLabel.Visible = true;
            SGroupLabel.Visible = true;
            GroupTextBox.Visible = true;
            NameTextBox.Visible = true;
            StudentLabel.Visible = true;
            InfoLabel.Visible = true;
            SessionAmountLabel.Visible = true;
            SearchButton.Visible = true;
            OOPLabel.Visible = true;
            CalculusLabel.Visible = true;
            EnglishLabel.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }
        private void StudentSearchOff()
        {
            SNameLabel.Visible = false;
            SGroupLabel.Visible = false;
            GroupTextBox.Visible = false;
            NameTextBox.Visible = false;
            StudentLabel.Visible = false;
            InfoLabel.Visible = false;
            SessionAmountLabel.Visible = false;
            ErrorLabel.Visible = false;
            SearchButton.Visible = false; 
            OOPLabel.Visible = false;
            CalculusLabel.Visible = false;
            EnglishLabel.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }
        private void ProfileOn()
        {
            NameLabel.Visible = true;
            EmailLabel.Visible = true;
            Email.Visible = true;
            ExitButton.Visible = true;
        }
        private void ProfileOff()
        {
            NameLabel.Visible = false;
            EmailLabel.Visible = false;
            Email.Visible = false;
            ExitButton.Visible = false;
        }
        private void MainPageOn()
        {
            label3.Visible = true;
            OOPButton.Visible = true;
            CalculusButton.Visible = true;
            EnglishButton.Visible = true;
        }
        private void MainPageOff()
        {
            label3.Visible = false;
            OOPButton.Visible = false;
            CalculusButton.Visible = false;
            EnglishButton.Visible = false;
        }
        private void LectionsOn()
        {
            ChoseLabel.Visible = true;
            LectureTextBox.Visible = true;
            comboBox1.Visible = true;
            SaveButton.Visible = true;
            LectName.Visible = true;
            LectNameTB.Visible = true;
            label4.Visible = true;
            pathText.Visible = true;
            LoadButton.Visible = true;
        }
        private void LectionsOff()
        {
            ChoseLabel.Visible = false;
            LectureTextBox.Visible = false;
            comboBox1.Visible = false;
            SaveButton.Visible = false;
            LectName.Visible = false;
            LectNameTB.Visible = false;
            label4.Visible = false;
            pathText.Visible = false;
            LoadButton.Visible = false;
        }
        private void EditTestsOn()
        {
            SubjectLabel.Visible = true;
            LectureLabel.Visible = true;
            QuestionLabel.Visible = true;
            SubjectCB.Visible = true;
            LectureCB.Visible = true;
            QuestionCB.Visible = true;
            QuestionLabel.Visible = true;
            A1Label.Visible = true;
            A2Label.Visible = true;
            A3Label.Visible = true;
            A4Label.Visible = true;
            A1TextBox.Visible = true;
            A2TextBox.Visible = true;
            A3TextBox.Visible = true;
            A4TextBox.Visible = true;
            QTextBox.Visible = true;
            RQComboBox.Visible = true;
            RQLabel.Visible = true;
            SaveTest.Visible = true;
            QLabel.Visible = true;
        }
        private void EditTestsOff()
        {
            SubjectLabel.Visible = false;
            LectureLabel.Visible = false;
            QuestionLabel.Visible = false;
            SubjectCB.Visible = false;
            LectureCB.Visible = false;
            QuestionCB.Visible = false;
            QuestionLabel.Visible = false;
            A1Label.Visible = false;
            A2Label.Visible = false;
            A3Label.Visible = false;
            A4Label.Visible = false;
            A1TextBox.Visible = false;
            A2TextBox.Visible = false;
            A3TextBox.Visible = false;
            A4TextBox.Visible = false;
            QTextBox.Visible = false;
            RQComboBox.Visible = false;
            RQLabel.Visible = false;
            SaveTest.Visible = false;
            QLabel.Visible = false;
        }
        private void OpenOOPLections(object sender, EventArgs e)
        {
            LectionsOn();
            MainPageOff();
            EditTestsOff();
            ProfileOff();
            StudentSearchOff();
            oop = true;
            english = false;
            calculus = false;
        }
        private void OpenCalculusLections(object sender, EventArgs e)
        {
            LectionsOn();
            MainPageOff();
            EditTestsOff();
            ProfileOff();
            StudentSearchOff();
            oop = false;
            english = false;
            calculus = true;
        }
        private void OpenEnglishLections(object sender, EventArgs e)
        {
            LectionsOn();
            EditTestsOff();
            MainPageOff();
            ProfileOff();
            StudentSearchOff();
            oop = false;        
            english = true;
            calculus = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 8; i++)
            {
                comboBox1.Items.Add("Lection" + i.ToString());
            }
            SubjectCB.Items.Add("OOP");
            SubjectCB.Items.Add("English");
            SubjectCB.Items.Add("Calculus");
            for (int i = 1; i < 8; i++)
            {
                LectureCB.Items.Add(i.ToString());
            }
            for (int i = 1; i < 6; i++)
            {
                QuestionCB.Items.Add(i.ToString());
            }
            for (int i = 1; i < 5; i++)
            {
                RQComboBox.Items.Add(i);
            }
        }
        private void SaveLection(object sender, EventArgs e)
        {
            con.Open();
            CheckSubject();
            SqlCommand cmd = new SqlCommand("update "+lectionString+" set LectionContent = '"+LectureTextBox.Text+"', LectionName = '"+LectNameTB.Text+"' where LectionNumber = '"+comboBox1.Text+"'", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
        private void CheckSubject()
        {
            if (oop)
            {
                lectionString = "OOPLections";
            }
            else if (calculus)
            {
                lectionString = "CalculusLections";
            }
            else if (english)
            {
                lectionString = "EnglishLections";
            }
        }
        private void LoadLecture(object sender, EventArgs e)
        {
            con.Open();
            CheckSubject();
            string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            SqlCommand cmd = new SqlCommand("select * from "+lectionString+" where LectionNumber = '"+selected+"';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            LectNameTB.Text = rd.GetString(2);
            LectureTextBox.Text = rd.GetString(1);
            con.Close();
        }
        private void LoadLectureFromFile(object sender, EventArgs e)
        {            
            LectureTextBox.Text = System.IO.File.ReadAllText(@pathText.Text);
        }
        private void OpenEditTests(object sender, EventArgs e)
        {
            EditTestsOn();
            LectionsOff();
            MainPageOff();
            ProfileOff();
            StudentSearchOff();            
        }
        private void LoadTestQ(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Test1 where Test = '"+LectureCB.Text+"' and QNumber = '"+QuestionCB.Text+"';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            QTextBox.Text = rd.GetString(2);
            A1TextBox.Text = rd.GetString(3);
            A2TextBox.Text = rd.GetString(4);
            A3TextBox.Text = rd.GetString(5);
            A4TextBox.Text = rd.GetString(6);
            con.Close();
        }
        private void LectureCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Test1 where Test = '" + LectureCB.Text + "' and QNumber = '" + QuestionCB.Text + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            QTextBox.Text = rd.GetString(2);
            A1TextBox.Text = rd.GetString(3);
            A2TextBox.Text = rd.GetString(4);
            A3TextBox.Text = rd.GetString(5);
            A4TextBox.Text = rd.GetString(6);
            con.Close();
        }
        private void SaveTest_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Test1 set Answer1 = '"+A1TextBox.Text+"', Answer2 = '"+A2TextBox.Text+"', Answer3 = '"+A3TextBox.Text+"', Answer4 = '"+A4TextBox.Text+"', Question = '"+QTextBox.Text+"', RightQuestion = "+RQComboBox.Text+ " where Test = '" + LectureCB.Text + "' and QNumber = '" + QuestionCB.Text + "';", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
