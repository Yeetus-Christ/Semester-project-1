using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{

    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source = DESKTOP-MR9T8DF\\YEET;Initial Catalog=Students;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }
        private void RegistrationWindow(object sender, EventArgs e)
        {
            LoginOff();
            RegisterOn();
        }
        private void RegisterNewAccount(object sender, EventArgs e)
        {
            ErrorOff();
            bool isError = false;
            if (NameTextBox.Text == "")
            {
                LoginError.Visible = true;
                isError = true;
            }
            if (EmailTextBox.Text == "")
            {
                EmailError.Visible = true;
                isError = true;
            }
            if (PasswordTextBox2.Text == "")
            {
                PasswordError.Visible = true;
                isError = true;
            }
            if (RepeatPasswordTextBox.Text == "")
            {
                RepeatPasswordError.Visible = true;
                isError = true;
            }
            if (ReferenceNumberTextBox.Text == "")
            {
                RefNumError.Visible = true;
                isError = true;
            }
            if (PasswordTextBox2.Text != RepeatPasswordTextBox.Text && PasswordTextBox2.Text != "" && RepeatPasswordTextBox.Text != "")
            {
                RepeatPasswordError2.Visible = true;
                isError = true;
            }
            SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-MR9T8DF\\YEET;Initial Catalog=Students;Integrated Security=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Students where [Reference number] = '" + ReferenceNumberTextBox.Text + "';", con1);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (!rd.HasRows && ReferenceNumberTextBox.Text != "")
            {
                RefNumError2.Visible = true;
                isError = true;
            }
            if (!isError)
            {
                string refNum = null;
                SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-MR9T8DF\\YEET;Initial Catalog=Students;Integrated Security=True");
                con2.Open();
                SqlCommand cmd2 = new SqlCommand("update Students set Email = '"+EmailTextBox.Text+"', Password = '"+PasswordTextBox2.Text+"', [Reference number] = '"+refNum+"', Login = '"+NameTextBox.Text+"' where [Reference number] = '"+ReferenceNumberTextBox.Text+"'" , con2);

                int i = cmd2.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Registration successful");
                }
                LoginOn();
                RegisterOff();
            }
        }
        private void LoginIntoAccount(object sender, EventArgs e)
        {            
            Student studentForm = new Student();
            Teacher teacherForm = new Teacher();
            if (StudentTextBox.Checked)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Students where Login = '" + LoginTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "';", con);               
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {                    
                    studentForm.Show();
                    rd.Read();
                    int sessionNum = rd.GetInt32(10) + 1;                    
                    studentForm.SetProfile(rd.GetString(0), rd.GetString(3), rd.GetString(1), rd.GetFloat(5).ToString(), rd.GetString(6));
                    studentForm.SetMarks(rd.GetFloat(7).ToString(), rd.GetFloat(8).ToString(), rd.GetFloat(9).ToString());
                    rd.Close();
                    con.Close();
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("update Students set TotalSessions = '" + sessionNum + "' where Login = '" + LoginTextBox.Text + "';", con);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    con.Close();
                    Hide();
                }
                else
                {
                    ErrorLabel.Visible = true;
                    con.Close();
                }

            }
            else if (TeacherCheckBox.Checked)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Teachers where Login = '" + LoginTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "';", con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    teacherForm.Show();
                    rd.Read();
                    teacherForm.SetName(rd.GetString(0), rd.GetString(1));
                    Hide();
                }
                else
                {
                    ErrorLabel.Visible = true;
                    con.Close();
                }
            }
        }
        private void CheckStudent(object sender, EventArgs e)
        {
            if (StudentTextBox.Checked)
            {
                TeacherCheckBox.Checked = false;
            }
        }
        private void CheckTeacher(object sender, EventArgs e)
        {
            if (TeacherCheckBox.Checked)
            {
                StudentTextBox.Checked = false;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }
        private void LoginOn()
        {
            LoginLabel.Visible = true;
            PasswordLabel.Visible = true;
            LoginTextBox.Visible = true;
            PasswordTextBox.Visible = true;
            LoginButton.Visible = true;
            RegisterButton.Visible = true;
            asLabel1.Visible = true;

            asLabel2.Visible = true;
            StudentLabel.Visible = true;
            TeacherCheckBox.Visible = true;
            StudentTextBox.Visible = true;
        }
        private void LoginOff()
        {
            LoginLabel.Visible = false;
            PasswordLabel.Visible = false;
            LoginTextBox.Visible = false;
            PasswordTextBox.Visible = false;
            LoginButton.Visible = false;
            RegisterButton.Visible = false;
            asLabel1.Visible = false;

            asLabel2.Visible = false;
            StudentLabel.Visible = false;
            TeacherCheckBox.Visible = false;
            StudentTextBox.Visible = false;
        }
        private void RegisterOn()
        {
            this.NameTextBox.Visible = true;
            this.EmailTextBox.Visible = true;
            this.PasswordTextBox2.Visible = true;
            this.RepeatPasswordTextBox.Visible = true;
            this.ReferenceNumberTextBox.Visible = true;

            this.LoginLabel2.Visible = true;
            this.EmailLabel.Visible = true;
            this.PasswordLabel2.Visible = true;
            this.RepeatPasswordLabel.Visible = true;
            this.ReferenceNumberLabel.Visible = true;
            this.RegisterButton2.Visible = true;
            BackButton.Visible = true;
        }
        private void RegisterOff()
        {
            this.NameTextBox.Visible = false;
            this.EmailTextBox.Visible = false;
            this.PasswordTextBox2.Visible = false;
            this.RepeatPasswordTextBox.Visible = false;
            this.ReferenceNumberTextBox.Visible = false;

            this.LoginLabel2.Visible = false;
            this.EmailLabel.Visible = false;
            this.PasswordLabel2.Visible = false;
            this.RepeatPasswordLabel.Visible = false;
            this.ReferenceNumberLabel.Visible = false;
            this.RegisterButton2.Visible = false;
            BackButton.Visible = false;
        }
        private void ErrorOff()
        {
            LoginError.Visible = false;
            EmailError.Visible = false;
            PasswordError.Visible = false;
            RepeatPasswordError.Visible = false;
            RefNumError.Visible = false;
            RepeatPasswordError2.Visible = false;
            RefNumError2.Visible = false;
        }
        private void ReturnToLogin(object sender, EventArgs e)
        {
            LoginOn();
            RegisterOff();
            ErrorOff();
        }
    }
}

