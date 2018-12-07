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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void clearFields()
        {

            //char answer = 'n';
            // MessageBox.Show("Do you want to clear the form? (y/n)");

            //before clearing - a confirmation message first:
            //if user clicks - yes
            if (MessageBox.Show("Are you sure you want to clear?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                name_box.Text = "";
                age_box.Text = "";

            }
            else
            {
                MessageBox.Show("I will not clear the fields.");
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            err_box.Text = "";
            int age;

            try
            {
                if (String.IsNullOrWhiteSpace(age_box.Text))
                {
                    err_box.Text += "Age can't be blank.\n";
                }
                // if it's a digit- "out" - saves the value as reference in memory
                else if (Int32.TryParse(age_box.Text, out age))
                {
                    Student s = new Student(name_box.Text, Convert.ToInt32(age_box.Text));
                    StudentForm sf = new StudentForm(s);
                    sf.ShowDialog();

                }
                else {

                    err_box.Text += "Invalid number.\n";
                }
            }
            catch (AgeBelowZeroException ex)
            {
                err_box.Text += ex.Message + "\n";

            }
            catch (EmptyNameException ex)
            {
                err_box.Text += ex.Message + "\n";
            }
            catch (Exception ex)
            {
                err_box.Text += ex.Message + "\n";
            }
        }
    }
}
