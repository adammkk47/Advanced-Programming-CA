﻿using System;
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
    public partial class DeleteStudent : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();

        DataTable dt = new DataTable();
        int studentNumber;

        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(txtStudentId.Text, out studentNumber);
            info.studentNumber = studentNumber;
            dt = opr.StudentSearch(info);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Student deleted successfully");
                int rows = opr.DeleteStudent(info);
            }
            else
            {
                MessageBox.Show("Student not found");
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Student s = new Student();
            s.Show();
        }

        private void DeleteStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f.Show();
        }
    }
}
