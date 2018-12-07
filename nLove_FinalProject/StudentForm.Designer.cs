namespace nLove_FinalProject
{
    partial class StudentForm
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
            this.major_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.age_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.major_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.freshm_rbtn = new System.Windows.Forms.RadioButton();
            this.sophom_rbtn = new System.Windows.Forms.RadioButton();
            this.junior_rbtn = new System.Windows.Forms.RadioButton();
            this.senior_btn = new System.Windows.Forms.RadioButton();
            this.subm_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.err_box = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_box
            // 
            this.name_box.Enabled = false;
            this.name_box.Location = new System.Drawing.Point(165, 21);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(179, 22);
            this.name_box.TabIndex = 0;
            // 
            // age_box
            // 
            this.age_box.Enabled = false;
            this.age_box.Location = new System.Drawing.Point(165, 49);
            this.age_box.Name = "age_box";
            this.age_box.Size = new System.Drawing.Size(179, 22);
            this.age_box.TabIndex = 1;
            // 
            // major_box
            // 
            this.major_box.Location = new System.Drawing.Point(165, 105);
            this.major_box.Name = "major_box";
            this.major_box.Size = new System.Drawing.Size(179, 22);
            this.major_box.TabIndex = 2;
            // 
            // id_box
            // 
            this.id_box.Enabled = false;
            this.id_box.Location = new System.Drawing.Point(165, 77);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(179, 22);
            this.id_box.TabIndex = 3;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(44, 23);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(115, 20);
            this.name_lbl.TabIndex = 4;
            this.name_lbl.Text = "Student Name";
            // 
            // age_lbl
            // 
            this.age_lbl.AutoSize = true;
            this.age_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_lbl.Location = new System.Drawing.Point(45, 54);
            this.age_lbl.Name = "age_lbl";
            this.age_lbl.Size = new System.Drawing.Size(100, 20);
            this.age_lbl.TabIndex = 5;
            this.age_lbl.Text = "Student Age";
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(45, 82);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(93, 20);
            this.id_lbl.TabIndex = 6;
            this.id_lbl.Text = "Student ID:";
            // 
            // major_lbl
            // 
            this.major_lbl.AutoSize = true;
            this.major_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.major_lbl.Location = new System.Drawing.Point(45, 110);
            this.major_lbl.Name = "major_lbl";
            this.major_lbl.Size = new System.Drawing.Size(56, 20);
            this.major_lbl.TabIndex = 7;
            this.major_lbl.Text = "Major:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.senior_btn);
            this.groupBox1.Controls.Add(this.junior_rbtn);
            this.groupBox1.Controls.Add(this.sophom_rbtn);
            this.groupBox1.Controls.Add(this.freshm_rbtn);
            this.groupBox1.Location = new System.Drawing.Point(49, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 188);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade Level";
            // 
            // freshm_rbtn
            // 
            this.freshm_rbtn.AutoSize = true;
            this.freshm_rbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freshm_rbtn.Location = new System.Drawing.Point(53, 33);
            this.freshm_rbtn.Name = "freshm_rbtn";
            this.freshm_rbtn.Size = new System.Drawing.Size(123, 31);
            this.freshm_rbtn.TabIndex = 0;
            this.freshm_rbtn.TabStop = true;
            this.freshm_rbtn.Text = "Freshman";
            this.freshm_rbtn.UseVisualStyleBackColor = true;
            // 
            // sophom_rbtn
            // 
            this.sophom_rbtn.AutoSize = true;
            this.sophom_rbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sophom_rbtn.Location = new System.Drawing.Point(53, 70);
            this.sophom_rbtn.Name = "sophom_rbtn";
            this.sophom_rbtn.Size = new System.Drawing.Size(137, 31);
            this.sophom_rbtn.TabIndex = 1;
            this.sophom_rbtn.TabStop = true;
            this.sophom_rbtn.Text = "Sophomore";
            this.sophom_rbtn.UseVisualStyleBackColor = true;
            // 
            // junior_rbtn
            // 
            this.junior_rbtn.AutoSize = true;
            this.junior_rbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.junior_rbtn.Location = new System.Drawing.Point(53, 109);
            this.junior_rbtn.Name = "junior_rbtn";
            this.junior_rbtn.Size = new System.Drawing.Size(90, 31);
            this.junior_rbtn.TabIndex = 2;
            this.junior_rbtn.TabStop = true;
            this.junior_rbtn.Text = "Junior";
            this.junior_rbtn.UseVisualStyleBackColor = true;
            // 
            // senior_btn
            // 
            this.senior_btn.AutoSize = true;
            this.senior_btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senior_btn.Location = new System.Drawing.Point(53, 146);
            this.senior_btn.Name = "senior_btn";
            this.senior_btn.Size = new System.Drawing.Size(91, 31);
            this.senior_btn.TabIndex = 3;
            this.senior_btn.TabStop = true;
            this.senior_btn.Text = "Senior";
            this.senior_btn.UseVisualStyleBackColor = true;
            // 
            // subm_btn
            // 
            this.subm_btn.Font = new System.Drawing.Font("MS Office Symbol Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subm_btn.Location = new System.Drawing.Point(48, 348);
            this.subm_btn.Name = "subm_btn";
            this.subm_btn.Size = new System.Drawing.Size(108, 41);
            this.subm_btn.TabIndex = 9;
            this.subm_btn.Text = "Submit";
            this.subm_btn.UseVisualStyleBackColor = true;
            this.subm_btn.Click += new System.EventHandler(this.subm_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("MS Office Symbol Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Location = new System.Drawing.Point(236, 348);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(108, 41);
            this.reset_btn.TabIndex = 10;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // err_box
            // 
            this.err_box.Location = new System.Drawing.Point(48, 395);
            this.err_box.Name = "err_box";
            this.err_box.Size = new System.Drawing.Size(296, 208);
            this.err_box.TabIndex = 11;
            this.err_box.Text = "";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 615);
            this.Controls.Add(this.err_box);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.subm_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.major_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.age_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.major_box);
            this.Controls.Add(this.age_box);
            this.Controls.Add(this.name_box);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox age_box;
        private System.Windows.Forms.TextBox major_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label age_lbl;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label major_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton senior_btn;
        private System.Windows.Forms.RadioButton junior_rbtn;
        private System.Windows.Forms.RadioButton sophom_rbtn;
        private System.Windows.Forms.RadioButton freshm_rbtn;
        private System.Windows.Forms.Button subm_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.RichTextBox err_box;
    }
}