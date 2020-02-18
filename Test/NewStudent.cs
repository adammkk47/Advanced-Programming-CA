using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace Test
{
    public partial class NewStudent : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        DataTable dt = new DataTable();
        string level;
        int studentNumber;
        List<bool> validation = new List<bool>();

        public NewStudent()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            validation.Clear();

            info.firstName = txtFirstName.Text.Trim();
            if (!info.firstName.Any(char.IsDigit) || !String.IsNullOrEmpty(info.firstName))
            {
                epStudentId.SetError(txtFirstName, "Must not contain numbers or be blank.");
                validation.Add(false);
            }
            else
            {
                epStudentId.Clear();
                validation.Add(true);
            }
            
            info.surname = txtSurname.Text.Trim();
            info.email = txtEmail.Text.Trim();
            info.phone = txtPhone.Text.Trim();
            info.addressLine1 = txtAddress1.Text.Trim();
            info.addressLine2 = txtAddress2.Text.Trim();
            info.city = txtCity.Text.Trim();
            info.county = cbCounty.Text;
            if (rbPostgrad.Checked == true)
            {
                level = "Postgraduate";
            }
            else
            {
                level = "Undergraduate";
            }
            info.level = level;
            info.course = cbCourse.Text;
            //student id validation
            if(int.TryParse(txtStudentNumber.Text, out studentNumber) && studentNumber < 9)
            {
                epStudentId.Clear();
                validation.Add(true);
            }
            else
            {
                epStudentId.SetError(txtStudentNumber, "Student id must be an integer less than 9 digits.");
                validation.Add(false);
            }         
            info.studentNumber = studentNumber;
            //
            dt = opr.StudentSearch(info);

            /*lblFirstName.Text = validation.ElementAt(0).ToString();
            lblSurname.Text = validation.ElementAt(1).ToString();
            lblEmail.Text = validation.Contains(false).ToString();
            lblPhone.Text = validation.Contains(true).ToString();*/

            if (dt.Rows.Count < 1 && !validation.Contains(false))
            {
                //MessageBox.Show("Student does not exist");
                int rows = opr.insertEmp(info);

                if (rows > 0)
                {
                    MessageBox.Show("Student entered successfully");
                }
            }
    
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Student with id " + studentNumber + " already exists. Please try again.");
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Student s = new Student();
            s.Show();
        }

        private void NewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }
    }
}
