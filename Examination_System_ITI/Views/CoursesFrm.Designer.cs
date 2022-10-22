namespace Examination_System_ITI.Views
{
    partial class Frm_Course
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.grBoxCourseInfo = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.comBox_Instructors = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_minDeg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Txt_Desc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Txt_Maxdeg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddQuestions = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.Btn_Save = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.Btn_Refresh = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.btn_Cancel = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.btn_UpdateCourse = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.btn_DeleteCourse = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.panel2.SuspendLayout();
            this.grBoxCourseInfo.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1243, 750);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCourses);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 375);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1233, 370);
            this.panel3.TabIndex = 1;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AllowUserToResizeRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourses.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.EnableHeadersVisualStyles = false;
            this.dgvCourses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 35;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(1233, 370);
            this.dgvCourses.TabIndex = 6;
            this.dgvCourses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_AddQuestions);
            this.panel2.Controls.Add(this.btnAddCourse);
            this.panel2.Controls.Add(this.grBoxCourseInfo);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 370);
            this.panel2.TabIndex = 0;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Image = global::Examination_System_ITI.Properties.Resources.AddIcon;
            this.btnAddCourse.Location = new System.Drawing.Point(1112, 12);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(60, 49);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // grBoxCourseInfo
            // 
            this.grBoxCourseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxCourseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.grBoxCourseInfo.Controls.Add(this.btn_UpdateCourse);
            this.grBoxCourseInfo.Controls.Add(this.Btn_Save);
            this.grBoxCourseInfo.Controls.Add(this.btn_DeleteCourse);
            this.grBoxCourseInfo.Controls.Add(this.Btn_Refresh);
            this.grBoxCourseInfo.Controls.Add(this.btn_Cancel);
            this.grBoxCourseInfo.Controls.Add(this.panel11);
            this.grBoxCourseInfo.Controls.Add(this.panel10);
            this.grBoxCourseInfo.Controls.Add(this.panel8);
            this.grBoxCourseInfo.Controls.Add(this.panel9);
            this.grBoxCourseInfo.Controls.Add(this.panel6);
            this.grBoxCourseInfo.Controls.Add(this.panel7);
            this.grBoxCourseInfo.Controls.Add(this.panel5);
            this.grBoxCourseInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCourseInfo.ForeColor = System.Drawing.Color.White;
            this.grBoxCourseInfo.Location = new System.Drawing.Point(63, 82);
            this.grBoxCourseInfo.Name = "grBoxCourseInfo";
            this.grBoxCourseInfo.Size = new System.Drawing.Size(1114, 282);
            this.grBoxCourseInfo.TabIndex = 2;
            this.grBoxCourseInfo.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel11.Controls.Add(this.comBox_Instructors);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(421, 164);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(390, 52);
            this.panel11.TabIndex = 0;
            // 
            // comBox_Instructors
            // 
            this.comBox_Instructors.FormattingEnabled = true;
            this.comBox_Instructors.Location = new System.Drawing.Point(123, 10);
            this.comBox_Instructors.Name = "comBox_Instructors";
            this.comBox_Instructors.Size = new System.Drawing.Size(253, 31);
            this.comBox_Instructors.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Instructor";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel10.Controls.Add(this.txt_minDeg);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(421, 93);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(390, 52);
            this.panel10.TabIndex = 0;
            // 
            // txt_minDeg
            // 
            this.txt_minDeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_minDeg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_minDeg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_minDeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.txt_minDeg.Location = new System.Drawing.Point(123, 13);
            this.txt_minDeg.Name = "txt_minDeg";
            this.txt_minDeg.Size = new System.Drawing.Size(254, 29);
            this.txt_minDeg.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Min Deg:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(421, 93);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(390, 52);
            this.panel8.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Min Deg:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel9.Controls.Add(this.Txt_Desc);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(25, 161);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(390, 105);
            this.panel9.TabIndex = 0;
            // 
            // Txt_Desc
            // 
            this.Txt_Desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Desc.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.Txt_Desc.Location = new System.Drawing.Point(88, 3);
            this.Txt_Desc.Multiline = true;
            this.Txt_Desc.Name = "Txt_Desc";
            this.Txt_Desc.Size = new System.Drawing.Size(288, 82);
            this.Txt_Desc.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Desc:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.Txt_Name);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(25, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 52);
            this.panel6.TabIndex = 0;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.Txt_Name.Location = new System.Drawing.Point(93, 13);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(284, 29);
            this.Txt_Name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel7.Controls.Add(this.Txt_Maxdeg);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(421, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(390, 52);
            this.panel7.TabIndex = 0;
            // 
            // Txt_Maxdeg
            // 
            this.Txt_Maxdeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Maxdeg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Maxdeg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Maxdeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.Txt_Maxdeg.Location = new System.Drawing.Point(121, 13);
            this.Txt_Maxdeg.Name = "Txt_Maxdeg";
            this.Txt_Maxdeg.Size = new System.Drawing.Size(254, 29);
            this.Txt_Maxdeg.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max Deg:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.Txt_Id);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(25, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 52);
            this.panel5.TabIndex = 0;
            // 
            // Txt_Id
            // 
            this.Txt_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Id.Enabled = false;
            this.Txt_Id.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.Txt_Id.Location = new System.Drawing.Point(92, 13);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.ReadOnly = true;
            this.Txt_Id.Size = new System.Drawing.Size(284, 29);
            this.Txt_Id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id: ";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Txt_Search);
            this.panel4.Controls.Add(this.BtnSearch);
            this.panel4.Location = new System.Drawing.Point(384, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 50);
            this.panel4.TabIndex = 1;
            // 
            // Txt_Search
            // 
            this.Txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Search.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.Txt_Search.Location = new System.Drawing.Point(66, 11);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(432, 29);
            this.Txt_Search.TabIndex = 3;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Image = global::Examination_System_ITI.Properties.Resources.icons8_search_24px_2;
            this.BtnSearch.Location = new System.Drawing.Point(9, 7);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(37, 34);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Courses";
            // 
            // btn_AddQuestions
            // 
            this.btn_AddQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddQuestions.BackColor = System.Drawing.Color.White;
            this.btn_AddQuestions.BackgroundColor = System.Drawing.Color.White;
            this.btn_AddQuestions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_AddQuestions.BorderRadius = 20;
            this.btn_AddQuestions.BorderSize = 1;
            this.btn_AddQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddQuestions.FlatAppearance.BorderSize = 0;
            this.btn_AddQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddQuestions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_AddQuestions.Location = new System.Drawing.Point(954, 12);
            this.btn_AddQuestions.Name = "btn_AddQuestions";
            this.btn_AddQuestions.Size = new System.Drawing.Size(152, 57);
            this.btn_AddQuestions.TabIndex = 3;
            this.btn_AddQuestions.Text = "Add Qustions";
            this.btn_AddQuestions.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_AddQuestions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_AddQuestions.UseVisualStyleBackColor = false;
            this.btn_AddQuestions.Click += new System.EventHandler(this.btn_AddQuestions_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Save.BackColor = System.Drawing.Color.White;
            this.Btn_Save.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.Btn_Save.BorderRadius = 20;
            this.Btn_Save.BorderSize = 0;
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.Btn_Save.Location = new System.Drawing.Point(971, 83);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(127, 57);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Refresh.BackColor = System.Drawing.Color.White;
            this.Btn_Refresh.BackgroundColor = System.Drawing.Color.White;
            this.Btn_Refresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.Btn_Refresh.BorderRadius = 20;
            this.Btn_Refresh.BorderSize = 0;
            this.Btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Refresh.FlatAppearance.BorderSize = 0;
            this.Btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.Btn_Refresh.Location = new System.Drawing.Point(971, 146);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(127, 57);
            this.Btn_Refresh.TabIndex = 3;
            this.Btn_Refresh.Text = "Refresh";
            this.Btn_Refresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.Btn_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.White;
            this.btn_Cancel.BackgroundColor = System.Drawing.Color.White;
            this.btn_Cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_Cancel.BorderRadius = 20;
            this.btn_Cancel.BorderSize = 0;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_Cancel.Location = new System.Drawing.Point(971, 209);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 57);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_UpdateCourse
            // 
            this.btn_UpdateCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateCourse.BackColor = System.Drawing.Color.White;
            this.btn_UpdateCourse.BackgroundColor = System.Drawing.Color.White;
            this.btn_UpdateCourse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_UpdateCourse.BorderRadius = 20;
            this.btn_UpdateCourse.BorderSize = 0;
            this.btn_UpdateCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateCourse.FlatAppearance.BorderSize = 0;
            this.btn_UpdateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_UpdateCourse.Location = new System.Drawing.Point(971, 83);
            this.btn_UpdateCourse.Name = "btn_UpdateCourse";
            this.btn_UpdateCourse.Size = new System.Drawing.Size(127, 57);
            this.btn_UpdateCourse.TabIndex = 3;
            this.btn_UpdateCourse.Text = "Update";
            this.btn_UpdateCourse.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_UpdateCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_UpdateCourse.UseVisualStyleBackColor = false;
            this.btn_UpdateCourse.Click += new System.EventHandler(this.btn_UpdateCourse_Click);
            // 
            // btn_DeleteCourse
            // 
            this.btn_DeleteCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteCourse.BackColor = System.Drawing.Color.White;
            this.btn_DeleteCourse.BackgroundColor = System.Drawing.Color.White;
            this.btn_DeleteCourse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_DeleteCourse.BorderRadius = 20;
            this.btn_DeleteCourse.BorderSize = 0;
            this.btn_DeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteCourse.FlatAppearance.BorderSize = 0;
            this.btn_DeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteCourse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_DeleteCourse.Location = new System.Drawing.Point(971, 146);
            this.btn_DeleteCourse.Name = "btn_DeleteCourse";
            this.btn_DeleteCourse.Size = new System.Drawing.Size(127, 57);
            this.btn_DeleteCourse.TabIndex = 3;
            this.btn_DeleteCourse.Text = "Delete";
            this.btn_DeleteCourse.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_DeleteCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_DeleteCourse.UseVisualStyleBackColor = false;
            this.btn_DeleteCourse.Click += new System.EventHandler(this.btn_DeleteCourse_Click);
            // 
            // Frm_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 750);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoursesFrm";
            this.Load += new System.EventHandler(this.Frm_Course_Load);
            this.Shown += new System.EventHandler(this.Frm_Course_Shown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grBoxCourseInfo.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.GroupBox grBoxCourseInfo;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox Txt_Desc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox Txt_Maxdeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label label2;
        private Responsive_Design.Anmh_Controls.AnmhButton btn_Cancel;
        private System.Windows.Forms.DataGridView dgvCourses;
        private Responsive_Design.Anmh_Controls.AnmhButton Btn_Save;
        private Responsive_Design.Anmh_Controls.AnmhButton Btn_Refresh;
        private Responsive_Design.Anmh_Controls.AnmhButton btn_AddQuestions;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox comBox_Instructors;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_minDeg;
        private Responsive_Design.Anmh_Controls.AnmhButton btn_UpdateCourse;
        private Responsive_Design.Anmh_Controls.AnmhButton btn_DeleteCourse;
    }
}