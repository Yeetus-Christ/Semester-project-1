using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class Student : Form
    {              
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MR9T8DF\\YEET;Initial Catalog=Students;Integrated Security=True");
        bool oop = false;
        bool calculus = false;
        bool english = false;   
        string studentLogin;
        string lectionString;
        string resultsString;
        public void SetProfile(string name, string group, string email, string time, string login)
        {
            NameLabel.Text = name;
            GroupLabel.Text = group;
            EmailLabel.Text = email;
            StudyTime.Text = time + " hours";
            studentLogin = login;
        }
        public void SetMarks(string oop, string calculus, string english)
        {
            OOPMarks.Text = oop;
            CalculusMarks.Text = calculus;
            EnglishMarks.Text = english;
        }       
        public Student()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.StudentInfo' table. You can move, or remove it, as needed.       
        }
        private void OpenMiniMenu(object sender, EventArgs e)
        {
            label4.Visible = false;
            groupBox1.Visible = true;
        }
        private void CloseMiniMenu(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            label4.Visible = true;
        }
        private void ShowProfile(object sender, EventArgs e)
        {
            MainPageOff();
            MarksOff();
            ProfileOn();
            LectionsOff();
        }
        private void ShowMainPage(object sender, EventArgs e)
        {
            MainPageOn();
            ProfileOff();
            MarksOff();
            LectionsOff();
        }
        private void ShowOOPLections(object sender, EventArgs e)
        {
            LectionsOn();
            MarksOff();
            ProfileOff();
            MainPageOff();
            oop = true;
            english = false;
            calculus = false;
        }
        private void ShowCalculusLections(object sender, EventArgs e)
        {
            LectionsOn();
            MarksOff();
            ProfileOff();
            MainPageOff();
            oop = false;
            english = false;
            calculus = true;
        }
        private void ShowEnglishLections(object sender, EventArgs e)
        {
            LectionsOn();
            MarksOff();
            ProfileOff();
            MainPageOff();
            oop = false;
            english = true;
            calculus = false;
        }
        private void ShowMarks(object sender, EventArgs e)
        {
            MarksOn();
            ProfileOff();
            MainPageOff();
            LectionsOff();
        }
        private void ExitProfile(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }       
        private void MarksOn()
        {
            subjectLabel.Visible = true;
            OOPLabel.Visible = true;
            OOPMarks.Visible = true;
            MarksLabel.Visible = true;
            CalculusLabel.Visible = true;
            CalculusMarks.Visible = true;
            EnglishLabel.Visible = true;
            EnglishMarks.Visible = true;
        }
        private void MarksOff()
        {
            subjectLabel.Visible = false;
            OOPLabel.Visible = false;
            OOPMarks.Visible = false;
            MarksLabel.Visible = false;
            CalculusLabel.Visible = false;
            CalculusMarks.Visible = false;
            EnglishLabel.Visible = false;
            EnglishMarks.Visible = false;
        }
        private void MainPageOn()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label1.Visible = true;
        }
        private void MainPageOff()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
        }
        private void ProfileOn()
        {
            NameLabel.Visible = true;
            GroupLabel.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            EmailLabel.Visible = true;
            button9.Visible = true;
            TotalStudyTimeLabel.Visible = true;
            StudyTime.Visible = true;
        }
        private void ProfileOff()
        {
            NameLabel.Visible = false;
            GroupLabel.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            EmailLabel.Visible = false;
            button9.Visible = false;
            TotalStudyTimeLabel.Visible = false;
            StudyTime.Visible = false;
        }
        private void LectionsOn()
        {
            Lection1.Visible = true;
            Lection2.Visible = true;
            Lection3.Visible = true;
            Lection4.Visible = true;
            Lection5.Visible = true;
            Lection6.Visible = true;
            Lection7.Visible = true;
            LectionsLabel.Visible = true;
        }
        private void LectionsOff()
        {
            Lection1.Visible = false;
            Lection2.Visible = false;
            Lection3.Visible = false;
            Lection4.Visible = false;
            Lection5.Visible = false;
            Lection6.Visible = false;
            Lection7.Visible = false;
            LectionsLabel.Visible = false;
        }
        private void OpenLection1(object sender, EventArgs e)
        {           
            Test lectionForm = new Test();
            CheckSubject(lectionForm, Lection1.Text);

            CheckLectionWindow(lectionForm);
        }      
        private void OpenLection2(object sender, EventArgs e)
        {
            Test lectionForm = new Test();
            CheckSubject(lectionForm, Lection2.Text);
            CheckLectionWindow(lectionForm);
        }
        private void OpenLection3(object sender, EventArgs e)
        {
            Test lectionForm = new Test();
            CheckSubject(lectionForm, Lection3.Text);
            CheckLectionWindow(lectionForm);
        }
        private void OpenLection4(object sender, EventArgs e)
        {
            Test lectionForm = new Test();
            CheckSubject(lectionForm, Lection4.Text);
            CheckLectionWindow(lectionForm);
        }
        private void OpenLection5(object sender, EventArgs e)
        {
            Test lectionForm = new Test();
            CheckSubject(lectionForm, Lection5.Text);
            CheckLectionWindow(lectionForm);
        }
        private void OpenLection6(object sender, EventArgs e)
        {
            Test lectionForm = new Test();
            CheckSubject(lectionForm, Lection6.Text);
            CheckLectionWindow(lectionForm);
        }
        private void OpenLection7(object sender, EventArgs e)
        {
            Test lectionForm = new Test();
            CheckSubject(lectionForm, Lection7.Text);
            CheckLectionWindow(lectionForm);
        }
        private void CheckLectionWindow(Test lectionForm)
        {
            if (Application.OpenForms.OfType<Test>().Count() == 1)
            {
                MessageBox.Show("You've already opened a lecture");
            }
            else
            {                
                lectionForm.Show();
                lectionForm.SetStudent(studentLogin, NameLabel.Text);
            }
        }
        private void CheckSubject(Test lectionForm, string buttonText)
        {
            if (oop)
            {
                resultsString = "OOPResults";
                lectionString = "OOPLections";
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from OOPLections where LectionNumber = '" + buttonText + "';", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                lectionForm.SetLecture(rd.GetString(1), rd.GetString(2), lectionString, rd.GetInt32(3), resultsString);
                con.Close();
            }
            else if (calculus)
            {
                resultsString = "CalculusResults";
                lectionString = "CalculusLections";
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from CalculusLections where LectionNumber = '" + buttonText + "';", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                lectionForm.SetLecture(rd.GetString(1), rd.GetString(2), lectionString, rd.GetInt32(3), resultsString);                
                con.Close();
            }
            else if (english)
            {
                resultsString = "EnglishResults";
                lectionString = "EnglishLections";
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from EnglishLections where LectionNumber = '" + buttonText + "';", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                lectionForm.SetLecture(rd.GetString(1), rd.GetString(2), lectionString, rd.GetInt32(3), resultsString);
                con.Close();
            }
        }      
    }
}
