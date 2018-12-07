namespace nLove_FinalProject
{
    partial class Form1
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
            this.name_box = new System.Windows.Forms.TextBox();
            this.age_box = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.age_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.student_rbtn = new System.Windows.Forms.RadioButton();
            this.employee_rbtn = new System.Windows.Forms.RadioButton();
            this.submit_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.err_box = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(84, 32);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(175, 22);
            this.name_box.TabIndex = 0;
            this.name_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // age_box
            // 
            this.age_box.Location = new System.Drawing.Point(84, 71);
            this.age_box.Name = "age_box";
            this.age_box.Size = new System.Drawing.Size(175, 22);
            this.age_box.TabIndex = 1;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(12, 32);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(61, 25);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "name";
            this.name_lbl.Click += new System.EventHandler(this.name_lbl_Click);
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_lbl.Location = new System.Drawing.Point(28, 67);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(45, 25);
            this.age_lbl.TabIndex = 3;
            this.age_lbl.Text = "age";
            this.age_lbl.Click += new System.EventHandler(this.age_lbl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employee_rbtn);
            this.groupBox1.Controls.Add(this.student_rbtn);
            this.groupBox1.Location = new System.Drawing.Point(84, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role:";
            // 
            // student_rbtn
            // 
            this.student_rbtn.AutoSize = true;
            this.student_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_rbtn.Location = new System.Drawing.Point(6, 33);
            this.student_rbtn.Name = "student_rbtn";
            this.student_rbtn.Size = new System.Drawing.Size(85, 21);
            this.student_rbtn.TabIndex = 0;
            this.student_rbtn.TabStop = true;
            this.student_rbtn.Text = "Student";
            this.student_rbtn.UseVisualStyleBackColor = true;
            // 
            // employee_rbtn
            // 
            this.employee_rbtn.AutoSize = true;
            this.employee_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_rbtn.Location = new System.Drawing.Point(6, 71);
            this.employee_rbtn.Name = "employee_rbtn";
            this.employee_rbtn.Size = new System.Drawing.Size(99, 21);
            this.employee_rbtn.TabIndex = 1;
            this.employee_rbtn.TabStop = true;
            this.employee_rbtn.Text = "Employee";
            this.employee_rbtn.UseVisualStyleBackColor = true;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("MS Office Symbol Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(17, 212);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(101, 38);
            this.submit_btn.TabIndex = 5;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("MS Office Symbol Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(161, 212);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(98, 38);
            this.reset_btn.TabIndex = 6;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            // 
            // err_box
            // 
            this.err_box.Location = new System.Drawing.Point(17, 267);
            this.err_box.Name = "err_box";
            this.err_box.Size = new System.Drawing.Size(242, 167);
            this.err_box.TabIndex = 7;
            this.err_box.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 450);
            this.Controls.Add(this.err_box);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.age_box);
            this.Controls.Add(this.name_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox age_box;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton employee_rbtn;
        private System.Windows.Forms.RadioButton student_rbtn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.RichTextBox err_box;
    }
}

