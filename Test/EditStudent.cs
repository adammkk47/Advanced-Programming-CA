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
    public partial class EditStudent : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        public Informations clone = new Informations();

        DataTable dt = new DataTable();
        int studentNumber;
        string level;

        public EditStudent()
        {
            InitializeComponent();
            gbStudentData.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int.TryParse(txtStudentIdSearch.Text, out studentNumber);
            info.studentNumber = studentNumber;
            dt = opr.StudentSearch(info);

            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Successful");
                gbStudentData.Visible = true;
                dt = opr.PopulateStudentDetails(info);
                lblFirstNameReadOnly.Text = info.firstName;
                lblSurnameReadOnly.Text = info.surname;
                txtEmail.Text = info.email;
                txtPhone.Text = info.phone;
                txtAddress1.Text = info.addressLine1;
                txtAddress2.Text = info.addressLine2;
                txtCity.Text = info.city;
                cbCounty.SelectedItem = info.county;
                if (info.level == "Postgraduate")
                {
                    rbPostgrad.Checked = true;
                }
                else
                {
                    rbUndergrad.Checked = true;
                }
                lblCourseReadOnly.Text = info.course;
            }
            else
            {
                MessageBox.Show("Student does not exist");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Student updated successfully");
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

                int rows = opr.UpdateStudentDetails(info);
                //info.operation = "INS";
                //int audit = opr.Audit(info);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Student s = new Student();
            s.Show();
        }

        private void EditStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }
    }
}
