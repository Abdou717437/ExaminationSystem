namespace Exam
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
            this.Code_txt = new System.Windows.Forms.TextBox();
            this.ExamType = new System.Windows.Forms.TextBox();
            this.NameExam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.createExam = new System.Windows.Forms.Button();
            this.Course = new System.Windows.Forms.TextBox();
            this.Inst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.update_Exam = new System.Windows.Forms.Button();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Code_txt
            // 
            this.Code_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_txt.Location = new System.Drawing.Point(247, 101);
            this.Code_txt.Name = "Code_txt";
            this.Code_txt.Size = new System.Drawing.Size(398, 34);
            this.Code_txt.TabIndex = 1;
            this.Code_txt.TextChanged += new System.EventHandler(this.Code);
            // 
            // ExamType
            // 
            this.ExamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamType.Location = new System.Drawing.Point(247, 423);
            this.ExamType.Name = "ExamType";
            this.ExamType.Size = new System.Drawing.Size(398, 34);
            this.ExamType.TabIndex = 2;
            this.ExamType.Click += new System.EventHandler(this.end_time);
            this.ExamType.TextChanged += new System.EventHandler(this.Exam_type);
            // 
            // NameExam
            // 
            this.NameExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameExam.Location = new System.Drawing.Point(247, 184);
            this.NameExam.Name = "NameExam";
            this.NameExam.Size = new System.Drawing.Size(398, 34);
            this.NameExam.TabIndex = 3;
            this.NameExam.TextChanged += new System.EventHandler(this.Name_of_Exam);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name_OfExam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exam_Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start_Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "End_Time";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // createExam
            // 
            this.createExam.Location = new System.Drawing.Point(143, 645);
            this.createExam.Name = "createExam";
            this.createExam.Size = new System.Drawing.Size(181, 69);
            this.createExam.TabIndex = 12;
            this.createExam.Text = "Create";
            this.createExam.UseVisualStyleBackColor = true;
            this.createExam.Click += new System.EventHandler(this.Create);
            // 
            // Course
            // 
            this.Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course.Location = new System.Drawing.Point(247, 500);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(398, 34);
            this.Course.TabIndex = 13;
            this.Course.Click += new System.EventHandler(this.CourseID);
            // 
            // Inst
            // 
            this.Inst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inst.Location = new System.Drawing.Point(247, 577);
            this.Inst.Name = "Inst";
            this.Inst.Size = new System.Drawing.Size(398, 34);
            this.Inst.TabIndex = 14;
            this.Inst.Click += new System.EventHandler(this.InstructorID);
            this.Inst.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "InstructorID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "CourseID";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(247, 260);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(398, 34);
            this.start.TabIndex = 17;
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(247, 339);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(398, 34);
            this.end.TabIndex = 18;
            this.end.Click += new System.EventHandler(this.start_time);
            // 
            // update_Exam
            // 
            this.update_Exam.Location = new System.Drawing.Point(464, 641);
            this.update_Exam.Name = "update_Exam";
            this.update_Exam.Size = new System.Drawing.Size(181, 73);
            this.update_Exam.TabIndex = 19;
            this.update_Exam.Text = "Update";
            this.update_Exam.UseVisualStyleBackColor = true;
            this.update_Exam.Click += new System.EventHandler(this.update);
            // 
            // ID_txt
            // 
            this.ID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txt.Location = new System.Drawing.Point(247, 34);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(398, 34);
            this.ID_txt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.update_Exam);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Inst);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.createExam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameExam);
            this.Controls.Add(this.ExamType);
            this.Controls.Add(this.Code_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Code_txt;
        private System.Windows.Forms.TextBox ExamType;
        private System.Windows.Forms.TextBox NameExam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button createExam;
        private System.Windows.Forms.TextBox Course;
        private System.Windows.Forms.TextBox Inst;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Button update_Exam;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label label1;
    }
}

