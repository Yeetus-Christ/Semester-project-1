using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Test : Form
    {
        int q1Chosen = 1;
        int q2Chosen = 1;
        int q3Chosen = 1;
        int q4Chosen = 1;
        int q5Chosen = 1;
        int rightQ1;
        int rightQ2;
        int rightQ3;
        int rightQ4;
        int rightQ5;
        int choosenQuestion = 1;
        float weightQ1;
        float weightQ2;
        float weightQ3;
        float weightQ4;
        float weightQ5;
        float score = 0f;
        int lectureNumber;
        string resultsString;
        string studentName;

        System.Timers.Timer timer = new System.Timers.Timer();
        static float time = 0;
        string studentLogin;
        SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-MR9T8DF\\YEET;Initial Catalog=Students;Integrated Security=True");
        string lectionString;
        public Test()
        {
            InitializeComponent();
        }
        public void SetLecture(string content, string lectureName, string lectionString, int lNumber, string results)
        {
            LectureContent.Text = content;
            LectionName.Text = lectureName;
            this.lectionString = lectionString;
            lectureNumber = lNumber;
            resultsString = results;
        }
        public void SetStudent(string studentLogin, string name)
        {
            this.studentLogin = studentLogin;
            studentName = name;
        }
        private void ExitLecture(object sender, EventArgs e)
        {

            con1.Open();
            SqlCommand cmd = new SqlCommand("update Students set [Total study time] = '"+time+"' where Login = '"+studentLogin+"'", con1);
            int i = cmd.ExecuteNonQuery();
            timer.Close();
            con1.Close();
            Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from Students where Login = '"+studentLogin+"'", con1);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                time = rd.GetFloat(5);
            }           
            con1.Close();
            timer.Interval = 1000;
            timer.Start();
            timer.Elapsed += OnTimedEvent;

        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            time += 1;
        }
        private void GoToTest(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from "+resultsString+" left outer join Students on Students.Name = "+resultsString+".Name1 where Name = '"+studentName+"'", con1);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            rd1.Read();
            if (!rd1.GetBoolean(lectureNumber))
            {
                con1.Close();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to start a test?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TestOn();
                    LectionOff();
                    con1.Open();
                     
                    SqlCommand cmd = new SqlCommand("select * from Test1 where Test = " + lectureNumber + " and QNumber = 1;", con1);
                    SqlDataReader rd = cmd.ExecuteReader(0);
                    rd.Read();
                    Answer1.Text = rd.GetString(3);
                    Answer2.Text = rd.GetString(4);
                    Answer3.Text = rd.GetString(5);
                    Answer4.Text = rd.GetString(6);
                    QuestionLabel.Text = rd.GetString(2);
                    con1.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    con1.Close();
                }
            }
            else
            {
                MessageBox.Show("You've already passed this test");
                con1.Close();
            }

        }
        private void TestOn()
        {
            QuestionGB.Visible = true;
            Q1B.Visible = true;
            Q2B.Visible = true;
            Q3B.Visible = true;
            Q4B.Visible = true;
            Q5B.Visible = true;
            Questions.Visible = true;
            Answer1.Visible = true;
            Answer2.Visible = true;
            Answer3.Visible = true;
            Answer4.Visible = true;
            FinishTest.Visible = true;
        }
        private void LectionOff()
        {
            LectureContent.Visible = false;
            ExitButton.Visible = false;
            TestButton.Visible = false;
            LectionName.Visible = false;
        }
        private void FinishTest1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to finish a test?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                float marks = 0;
                con1.Open();
                SqlCommand cmd = new SqlCommand("update "+resultsString+" set Test"+lectureNumber+" = 'true' where Name1 = '"+studentName+"'", con1);
                int i = cmd.ExecuteNonQuery();
                con1.Close();
                CheckAnswer();
                MessageBox.Show("Your score is " + score.ToString());
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("select * from Students where Login = '"+studentLogin+"'", con1);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    marks = rd.GetFloat(7) + score;
                }
                con1.Close();
                con1.Open();
                SqlCommand cmd2 = new SqlCommand("update Students set OOP = "+marks+" where Login = '"+studentLogin+"'", con1);
                int i1 = cmd2.ExecuteNonQuery();
                con1.Close();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void Q1B_Click(object sender, EventArgs e)
        {
            choosenQuestion = 1;
            SavedAnswer(q1Chosen);
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from Test1 where QNumber = "+choosenQuestion+"and Test = "+lectureNumber+"", con1);
            SqlDataReader rd = cmd.ExecuteReader(0);
            rd.Read();
            Answer1.Text = rd.GetString(3);
            Answer2.Text = rd.GetString(4);
            Answer3.Text = rd.GetString(5);
            Answer4.Text = rd.GetString(6);
            QuestionLabel.Text = rd.GetString(2);
            rightQ1 = rd.GetInt32(7);
            weightQ1 = rd.GetFloat(8);
            con1.Close();
        }
        private void Q2B_Click(object sender, EventArgs e)
        {
            choosenQuestion = 2;
            int number = lectureNumber * 10 + choosenQuestion;
            SavedAnswer(q2Chosen);
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from Test1 where QNumber = " + choosenQuestion + "and Test = " + lectureNumber + "", con1);
            SqlDataReader rd = cmd.ExecuteReader(0);
            rd.Read();
            Answer1.Text = rd.GetString(3);
            Answer2.Text = rd.GetString(4);
            Answer3.Text = rd.GetString(5);
            Answer4.Text = rd.GetString(6);
            QuestionLabel.Text = rd.GetString(2);
            rightQ2 = rd.GetInt32(7);
            weightQ2 = rd.GetFloat(8);
            con1.Close();
        }
        private void Q3B_Click(object sender, EventArgs e)
        {
            choosenQuestion = 3;
            int number = lectureNumber * 10 + choosenQuestion;
            SavedAnswer(q3Chosen);
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from Test1 where QNumber = " + choosenQuestion + "and Test = " + lectureNumber + "", con1);
            SqlDataReader rd = cmd.ExecuteReader(0);
            rd.Read();
            Answer1.Text = rd.GetString(3);
            Answer2.Text = rd.GetString(4);
            Answer3.Text = rd.GetString(5);
            Answer4.Text = rd.GetString(6);
            QuestionLabel.Text = rd.GetString(2);
            rightQ3 = rd.GetInt32(7);
            weightQ3 = rd.GetFloat(8);
            con1.Close();
        }
        private void Q4B_Click(object sender, EventArgs e)
        {
            choosenQuestion = 4;
            SavedAnswer(q4Chosen);
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from Test1 where QNumber = " + choosenQuestion + "and Test = " + lectureNumber + "", con1);
            SqlDataReader rd = cmd.ExecuteReader(0);
            rd.Read();
            Answer1.Text = rd.GetString(3);
            Answer2.Text = rd.GetString(4);
            Answer3.Text = rd.GetString(5);
            Answer4.Text = rd.GetString(6);
            QuestionLabel.Text = rd.GetString(2);
            rightQ4 = rd.GetInt32(7);
            weightQ4 = rd.GetFloat(8);
            con1.Close();
        }
        private void Q5B_Click(object sender, EventArgs e)
        {
            choosenQuestion = 5;
            SavedAnswer(q5Chosen);
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from Test1 where QNumber = " + choosenQuestion + "and Test = " + lectureNumber + "", con1);
            SqlDataReader rd = cmd.ExecuteReader(0);
            rd.Read();
            Answer1.Text = rd.GetString(3);
            Answer2.Text = rd.GetString(4);
            Answer3.Text = rd.GetString(5);
            Answer4.Text = rd.GetString(6);
            QuestionLabel.Text = rd.GetString(2);
            rightQ5 = rd.GetInt32(7);
            weightQ4 = rd.GetFloat(8);
            con1.Close();
        }
        private void SavedAnswer(int num)
        {
            switch(num){
                case 1:
                    Answer1.Checked = true;
                    break;
                case 2:
                    Answer2.Checked = true;
                    break;
                case 3:
                    Answer3.Checked = true;
                    break;
                case 4:
                    Answer4.Checked = true;
                    break;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            switch (choosenQuestion)
            {
                case 1:
                    if (Answer1.Checked)
                    {
                        q1Chosen = 1;
                    }
                    else if (Answer2.Checked)
                    {
                        q1Chosen = 2;
                    }
                    else if (Answer3.Checked)
                    {
                        q1Chosen = 3;
                    }
                    else if (Answer4.Checked)
                    {
                        q1Chosen = 4;
                    }
                    break;
                case 2:
                    if (Answer1.Checked)
                    {
                        q2Chosen = 1;
                    }
                    else if (Answer2.Checked)
                    {
                        q2Chosen = 2;
                    }
                    else if (Answer3.Checked)
                    {
                        q2Chosen = 3;
                    }
                    else if (Answer4.Checked)
                    {
                        q2Chosen = 4;
                    }
                    break;
                case 3:
                    if (Answer1.Checked)
                    {
                        q3Chosen = 1;
                    }
                    else if (Answer2.Checked)
                    {
                        q3Chosen = 2;
                    }
                    else if (Answer3.Checked)
                    {
                        q3Chosen = 3;
                    }
                    else if (Answer4.Checked)
                    {
                        q3Chosen = 4;
                    }
                    break;
                case 4:
                    if (Answer1.Checked)
                    {
                        q4Chosen = 1;
                    }
                    else if (Answer2.Checked)
                    {
                        q4Chosen = 2;
                    }
                    else if (Answer3.Checked)
                    {
                        q4Chosen = 3;
                    }
                    else if (Answer4.Checked)
                    {
                        q4Chosen = 4;
                    }
                    break;
                case 5:
                    if (Answer1.Checked)
                    {
                        q5Chosen = 1;
                    }
                    else if (Answer2.Checked)
                    {
                        q5Chosen = 2;
                    }
                    else if (Answer3.Checked)
                    {
                        q5Chosen = 3;
                    }
                    else if (Answer4.Checked)
                    {
                        q5Chosen = 4;
                    }
                    break;
            }
        }
        private void CheckAnswer()
        {
            if (q1Chosen == rightQ1)
            {
                score += weightQ1;
            }
            if (q2Chosen == rightQ2)
            {
                score += weightQ2;
            }
            if (q3Chosen == rightQ3)
            {
                score += weightQ3;
            }
            if (q4Chosen == rightQ4)
            {
                score += weightQ4;
            }
            if (q5Chosen == rightQ5)
            {
                score += weightQ5;
            }
        }
    }
}
