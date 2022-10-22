namespace Examination_System_ITI.Views
{
    partial class Frm_Tracks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.grBoxTrackInfo = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_RemoveCourse = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AddCourse = new System.Windows.Forms.Button();
            this.coursesList = new System.Windows.Forms.ListBox();
            this.listBox_AddedCoursesList = new System.Windows.Forms.ListBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Desc = new System.Windows.Forms.TextBox();
            this.Btn_Save = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.Btn_Refresh = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.btn_Cancel = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toggleBtnActivateTrack = new Responsive_Design.Anmh_Controls.AnmhToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBox_Manager = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.panel2.SuspendLayout();
            this.grBoxTrackInfo.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTracks
            // 
            this.dgvTracks.AllowUserToAddRows = false;
            this.dgvTracks.AllowUserToDeleteRows = false;
            this.dgvTracks.AllowUserToResizeRows = false;
            this.dgvTracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTracks.BackgroundColor = System.Drawing.Color.White;
            this.dgvTracks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTracks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTracks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTracks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTracks.EnableHeadersVisualStyles = false;
            this.dgvTracks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvTracks.Location = new System.Drawing.Point(0, 389);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.ReadOnly = true;
            this.dgvTracks.RowHeadersVisible = false;
            this.dgvTracks.RowHeadersWidth = 51;
            this.dgvTracks.RowTemplate.Height = 35;
            this.dgvTracks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTracks.Size = new System.Drawing.Size(1251, 388);
            this.dgvTracks.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAddTrack);
            this.panel2.Controls.Add(this.grBoxTrackInfo);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 389);
            this.panel2.TabIndex = 9;
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrack.FlatAppearance.BorderSize = 0;
            this.btnAddTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrack.Image = global::Examination_System_ITI.Properties.Resources.AddIcon;
            this.btnAddTrack.Location = new System.Drawing.Point(1130, 12);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(60, 49);
            this.btnAddTrack.TabIndex = 3;
            this.btnAddTrack.UseVisualStyleBackColor = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // grBoxTrackInfo
            // 
            this.grBoxTrackInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxTrackInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.grBoxTrackInfo.Controls.Add(this.panel7);
            this.grBoxTrackInfo.Controls.Add(this.panel9);
            this.grBoxTrackInfo.Controls.Add(this.Btn_Save);
            this.grBoxTrackInfo.Controls.Add(this.Btn_Refresh);
            this.grBoxTrackInfo.Controls.Add(this.btn_Cancel);
            this.grBoxTrackInfo.Controls.Add(this.panel3);
            this.grBoxTrackInfo.Controls.Add(this.panel1);
            this.grBoxTrackInfo.Controls.Add(this.panel6);
            this.grBoxTrackInfo.Controls.Add(this.panel5);
            this.grBoxTrackInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxTrackInfo.ForeColor = System.Drawing.Color.White;
            this.grBoxTrackInfo.Location = new System.Drawing.Point(63, 84);
            this.grBoxTrackInfo.Name = "grBoxTrackInfo";
            this.grBoxTrackInfo.Size = new System.Drawing.Size(1132, 286);
            this.grBoxTrackInfo.TabIndex = 2;
            this.grBoxTrackInfo.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel7.Controls.Add(this.btn_RemoveCourse);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.btn_AddCourse);
            this.panel7.Controls.Add(this.coursesList);
            this.panel7.Controls.Add(this.listBox_AddedCoursesList);
            this.panel7.Location = new System.Drawing.Point(522, 118);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(444, 153);
            this.panel7.TabIndex = 4;
            // 
            // btn_RemoveCourse
            // 
            this.btn_RemoveCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_RemoveCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveCourse.FlatAppearance.BorderSize = 0;
            this.btn_RemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveCourse.Image = global::Examination_System_ITI.Properties.Resources.RemoveCourseIcon;
            this.btn_RemoveCourse.Location = new System.Drawing.Point(199, 68);
            this.btn_RemoveCourse.Name = "btn_RemoveCourse";
            this.btn_RemoveCourse.Size = new System.Drawing.Size(45, 57);
            this.btn_RemoveCourse.TabIndex = 3;
            this.btn_RemoveCourse.UseVisualStyleBackColor = true;
            this.btn_RemoveCourse.Click += new System.EventHandler(this.btn_RemoveCourse_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(269, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Track Courses";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(37, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "All Courses";
            // 
            // btn_AddCourse
            // 
            this.btn_AddCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCourse.FlatAppearance.BorderSize = 0;
            this.btn_AddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCourse.Image = global::Examination_System_ITI.Properties.Resources.AddCourseIcon;
            this.btn_AddCourse.Location = new System.Drawing.Point(199, 8);
            this.btn_AddCourse.Name = "btn_AddCourse";
            this.btn_AddCourse.Size = new System.Drawing.Size(45, 57);
            this.btn_AddCourse.TabIndex = 3;
            this.btn_AddCourse.UseVisualStyleBackColor = true;
            this.btn_AddCourse.Click += new System.EventHandler(this.btn_AddCourse_Click);
            // 
            // coursesList
            // 
            this.coursesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.coursesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursesList.FormattingEnabled = true;
            this.coursesList.ItemHeight = 23;
            this.coursesList.Location = new System.Drawing.Point(16, 3);
            this.coursesList.Name = "coursesList";
            this.coursesList.Size = new System.Drawing.Size(171, 115);
            this.coursesList.TabIndex = 0;
            // 
            // listBox_AddedCoursesList
            // 
            this.listBox_AddedCoursesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_AddedCoursesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_AddedCoursesList.FormattingEnabled = true;
            this.listBox_AddedCoursesList.ItemHeight = 23;
            this.listBox_AddedCoursesList.Location = new System.Drawing.Point(256, 3);
            this.listBox_AddedCoursesList.Name = "listBox_AddedCoursesList";
            this.listBox_AddedCoursesList.Size = new System.Drawing.Size(171, 115);
            this.listBox_AddedCoursesList.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.Txt_Desc);
            this.panel9.Location = new System.Drawing.Point(522, 31);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(444, 81);
            this.panel9.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desc:";
            // 
            // Txt_Desc
            // 
            this.Txt_Desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Desc.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.Txt_Desc.Location = new System.Drawing.Point(83, 10);
            this.Txt_Desc.Multiline = true;
            this.Txt_Desc.Name = "Txt_Desc";
            this.Txt_Desc.Size = new System.Drawing.Size(344, 58);
            this.Txt_Desc.TabIndex = 4;
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
            this.Btn_Save.Location = new System.Drawing.Point(989, 87);
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
            this.Btn_Refresh.Location = new System.Drawing.Point(989, 150);
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
            this.btn_Cancel.Location = new System.Drawing.Point(989, 213);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 57);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.toggleBtnActivateTrack);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(25, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 52);
            this.panel3.TabIndex = 0;
            // 
            // toggleBtnActivateTrack
            // 
            this.toggleBtnActivateTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toggleBtnActivateTrack.Location = new System.Drawing.Point(169, 9);
            this.toggleBtnActivateTrack.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleBtnActivateTrack.Name = "toggleBtnActivateTrack";
            this.toggleBtnActivateTrack.OffBackColor = System.Drawing.Color.White;
            this.toggleBtnActivateTrack.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleBtnActivateTrack.OnBackColor = System.Drawing.Color.White;
            this.toggleBtnActivateTrack.OnToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.toggleBtnActivateTrack.Size = new System.Drawing.Size(108, 32);
            this.toggleBtnActivateTrack.TabIndex = 1;
            this.toggleBtnActivateTrack.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Activate Track";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.comBox_Manager);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(25, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 52);
            this.panel1.TabIndex = 0;
            // 
            // comBox_Manager
            // 
            this.comBox_Manager.FormattingEnabled = true;
            this.comBox_Manager.Location = new System.Drawing.Point(169, 13);
            this.comBox_Manager.Name = "comBox_Manager";
            this.comBox_Manager.Size = new System.Drawing.Size(308, 31);
            this.comBox_Manager.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Manager";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.Txt_Name);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(25, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(491, 52);
            this.panel6.TabIndex = 0;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.Txt_Name.Location = new System.Drawing.Point(169, 13);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(309, 29);
            this.Txt_Name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.Txt_Id);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(25, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 52);
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
            this.Txt_Id.Location = new System.Drawing.Point(169, 13);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.ReadOnly = true;
            this.Txt_Id.Size = new System.Drawing.Size(308, 29);
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
            this.panel4.Size = new System.Drawing.Size(533, 50);
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
            this.Txt_Search.Size = new System.Drawing.Size(450, 29);
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
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Tracks";
            // 
            // Frm_Tracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 777);
            this.Controls.Add(this.dgvTracks);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_Tracks";
            this.Text = "Frm_Tracks";
            this.Load += new System.EventHandler(this.Frm_Tracks_Load);
            this.Shown += new System.EventHandler(this.Frm_Tracks_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grBoxTrackInfo.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.GroupBox grBoxTrackInfo;
        private Responsive_Design.Anmh_Controls.AnmhButton Btn_Save;
        private Responsive_Design.Anmh_Controls.AnmhButton Btn_Refresh;
        private Responsive_Design.Anmh_Controls.AnmhButton btn_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comBox_Manager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Desc;
        private System.Windows.Forms.Panel panel3;
        private Responsive_Design.Anmh_Controls.AnmhToggleButton toggleBtnActivateTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_AddCourse;
        private System.Windows.Forms.ListBox coursesList;
        private System.Windows.Forms.ListBox listBox_AddedCoursesList;
        private System.Windows.Forms.Button btn_RemoveCourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}