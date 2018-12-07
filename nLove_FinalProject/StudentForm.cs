using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nLove_FinalProject
{
    public partial class StudentForm : Form
    {
        private Student _student;

        private void DisplayStudent() {

            //names of text boxes (name_box.Text), etc:
            name_box.Text = _student.Name;
            age_box.Text = _student.Age.ToString();
            id_box.Text = _student.StudentID;
            major_box.Text = _student.Major;

            //switch - checks the necessary level- in the displayed form
            switch (_student.Level) {
                case "Freshman":
                    freshm_rbtn.Checked = true;
                    break;
                case "Sophomore":
                    sophom_rbtn.Checked = true;
                    break;
                case "Junior":
                    junior_rbtn.Checked = true;
                    break;
                case "Senior":
                    senior_btn.Checked = true;
                    break;
                default:
                    freshm_rbtn.Checked = true;
                    break;
                   
            }



        }

        public StudentForm()
        {
            InitializeComponent();
        }
        public StudentForm(Student s) {

            _student = s;
            InitializeComponent();// builds the form
            DisplayStudent();
        }


        private void subm_btn_Click(object sender, EventArgs e)
        {
            if (freshm_rbtn.Checked)
            {
                _student.Level = "Freshman";
            }
            else if (sophom_rbtn.Checked)
            {
                _student.Level = "Sophomore";

            }
            else if (junior_rbtn.Checked)
            {
                _student.Level = "Junior";

            }
            else if (senior_btn.Checked)
            {
                _student.Level = "Senior";
            }
            else
            {
                _student.Level = "Freshman";
            }

            _student.Major = major_box.Text;

            MessageBox.Show(String.Format("{0}\n\n{1}", _student.Talk(), _student.DisplayInformation()));
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            major_box.Text = "";
            freshm_rbtn.Checked = true;
        }
    }
}
