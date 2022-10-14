namespace Examination_System_ITI.Views
{
    partial class Frm_Intakes
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
            this.dgvIntakes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intake_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddIntake = new System.Windows.Forms.Button();
            this.grBoxIntakeInfo = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_RemoveTrack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_AddTrack = new System.Windows.Forms.Button();
            this.tracksList = new System.Windows.Forms.ListBox();
            this.listBox_AddedTracksList = new System.Windows.Forms.ListBox();
            this.Btn_Save = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.Btn_Refresh = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.btn_Cancel = new Responsive_Design.Anmh_Controls.AnmhButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTimePicker_SDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBox_Branch = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntakes)).BeginInit();
            this.panel2.SuspendLayout();
            this.grBoxIntakeInfo.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIntakes
            // 
            this.dgvIntakes.AllowUserToAddRows = false;
            this.dgvIntakes.AllowUserToDeleteRows = false;
            this.dgvIntakes.AllowUserToResizeRows = false;
            this.dgvIntakes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntakes.BackgroundColor = System.Drawing.Color.White;
            this.dgvIntakes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIntakes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIntakes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntakes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIntakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntakes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Intake_Name,
            this.Branch,
            this.St_Date,
            this.End_Date});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(84)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntakes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIntakes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIntakes.EnableHeadersVisualStyles = false;
            this.dgvIntakes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvIntakes.Location = new System.Drawing.Point(0, 361);
            this.dgvIntakes.Name = "dgvIntakes";
            this.dgvIntakes.ReadOnly = true;
            this.dgvIntakes.RowHeadersVisible = false;
            this.dgvIntakes.RowHeadersWidth = 51;
            this.dgvIntakes.RowTemplate.Height = 35;
            this.dgvIntakes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntakes.Size = new System.Drawing.Size(1210, 305);
            this.dgvIntakes.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Intake_Name
            // 
            this.Intake_Name.HeaderText = "Name";
            this.Intake_Name.MinimumWidth = 6;
            this.Intake_Name.Name = "Intake_Name";
            this.Intake_Name.ReadOnly = true;
            // 
            // Branch
            // 
            this.Branch.HeaderText = "Branch";
            this.Branch.MinimumWidth = 6;
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            // 
            // St_Date
            // 
            this.St_Date.HeaderText = "Start Date";
            this.St_Date.MinimumWidth = 6;
            this.St_Date.Name = "St_Date";
            this.St_Date.ReadOnly = true;
            // 
            // End_Date
            // 
            this.End_Date.HeaderText = "End Date";
            this.End_Date.MinimumWidth = 6;
            this.End_Date.Name = "End_Date";
            this.End_Date.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnAddIntake);
            this.panel2.Controls.Add(this.grBoxIntakeInfo);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1210, 361);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Date:";
            // 
            // btnAddIntake
            // 
            this.btnAddIntake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddIntake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIntake.FlatAppearance.BorderSize = 0;
            this.btnAddIntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIntake.Image = global::Examination_System_ITI.Properties.Resources.AddIcon;
            this.btnAddIntake.Location = new System.Drawing.Point(1089, 12);
            this.btnAddIntake.Name = "btnAddIntake";
            this.btnAddIntake.Size = new System.Drawing.Size(60, 49);
            this.btnAddIntake.TabIndex = 3;
            this.btnAddIntake.UseVisualStyleBackColor = true;
            this.btnAddIntake.Click += new System.EventHandler(this.btnAddIntake_Click);
            // 
            // grBoxIntakeInfo
            // 
            this.grBoxIntakeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxIntakeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.grBoxIntakeInfo.Controls.Add(this.panel8);
            this.grBoxIntakeInfo.Controls.Add(this.Btn_Save);
            this.grBoxIntakeInfo.Controls.Add(this.Btn_Refresh);
            this.grBoxIntakeInfo.Controls.Add(this.btn_Cancel);
            this.grBoxIntakeInfo.Controls.Add(this.panel3);
            this.grBoxIntakeInfo.Controls.Add(this.panel7);
            this.grBoxIntakeInfo.Controls.Add(this.panel1);
            this.grBoxIntakeInfo.Controls.Add(this.panel6);
            this.grBoxIntakeInfo.Controls.Add(this.panel5);
            this.grBoxIntakeInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxIntakeInfo.ForeColor = System.Drawing.Color.White;
            this.grBoxIntakeInfo.Location = new System.Drawing.Point(63, 79);
            this.grBoxIntakeInfo.Name = "grBoxIntakeInfo";
            this.grBoxIntakeInfo.Size = new System.Drawing.Size(1091, 276);
            this.grBoxIntakeInfo.TabIndex = 2;
            this.grBoxIntakeInfo.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel8.Controls.Add(this.btn_RemoveTrack);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.btn_AddTrack);
            this.panel8.Controls.Add(this.tracksList);
            this.panel8.Controls.Add(this.listBox_AddedTracksList);
            this.panel8.Location = new System.Drawing.Point(402, 93);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(444, 172);
            this.panel8.TabIndex = 5;
            // 
            // btn_RemoveTrack
            // 
            this.btn_RemoveTrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_RemoveTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveTrack.FlatAppearance.BorderSize = 0;
            this.btn_RemoveTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveTrack.Image = global::Examination_System_ITI.Properties.Resources.RemoveCourseIcon;
            this.btn_RemoveTrack.Location = new System.Drawing.Point(199, 78);
            this.btn_RemoveTrack.Name = "btn_RemoveTrack";
            this.btn_RemoveTrack.Size = new System.Drawing.Size(45, 46);
            this.btn_RemoveTrack.TabIndex = 3;
            this.btn_RemoveTrack.UseVisualStyleBackColor = true;
            this.btn_RemoveTrack.Click += new System.EventHandler(this.btn_RemoveTrack_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(273, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Track Courses";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(37, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "All Courses";
            // 
            // btn_AddTrack
            // 
            this.btn_AddTrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddTrack.FlatAppearance.BorderSize = 0;
            this.btn_AddTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTrack.Image = global::Examination_System_ITI.Properties.Resources.AddCourseIcon;
            this.btn_AddTrack.Location = new System.Drawing.Point(199, 18);
            this.btn_AddTrack.Name = "btn_AddTrack";
            this.btn_AddTrack.Size = new System.Drawing.Size(45, 54);
            this.btn_AddTrack.TabIndex = 3;
            this.btn_AddTrack.UseVisualStyleBackColor = true;
            this.btn_AddTrack.Click += new System.EventHandler(this.btn_AddTrack_Click);
            // 
            // tracksList
            // 
            this.tracksList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tracksList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tracksList.FormattingEnabled = true;
            this.tracksList.ItemHeight = 23;
            this.tracksList.Location = new System.Drawing.Point(16, 9);
            this.tracksList.Name = "tracksList";
            this.tracksList.Size = new System.Drawing.Size(171, 115);
            this.tracksList.TabIndex = 0;
            // 
            // listBox_AddedTracksList
            // 
            this.listBox_AddedTracksList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_AddedTracksList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_AddedTracksList.FormattingEnabled = true;
            this.listBox_AddedTracksList.ItemHeight = 23;
            this.listBox_AddedTracksList.Location = new System.Drawing.Point(260, 9);
            this.listBox_AddedTracksList.Name = "listBox_AddedTracksList";
            this.listBox_AddedTracksList.Size = new System.Drawing.Size(171, 115);
            this.listBox_AddedTracksList.TabIndex = 0;
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
            this.Btn_Save.Location = new System.Drawing.Point(948, 77);
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
            this.Btn_Refresh.Location = new System.Drawing.Point(948, 140);
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
            this.btn_Cancel.Location = new System.Drawing.Point(948, 203);
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
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dateTimePicker_EndDate);
            this.panel3.Location = new System.Drawing.Point(402, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 52);
            this.panel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "End Date";
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(125, 10);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(306, 32);
            this.dateTimePicker_EndDate.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel7.Controls.Add(this.dateTimePicker_SDate);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(25, 218);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(362, 52);
            this.panel7.TabIndex = 0;
            // 
            // dateTimePicker_SDate
            // 
            this.dateTimePicker_SDate.Location = new System.Drawing.Point(93, 11);
            this.dateTimePicker_SDate.Name = "dateTimePicker_SDate";
            this.dateTimePicker_SDate.Size = new System.Drawing.Size(253, 32);
            this.dateTimePicker_SDate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "St Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.comBox_Branch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(25, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 52);
            this.panel1.TabIndex = 0;
            // 
            // comBox_Branch
            // 
            this.comBox_Branch.FormattingEnabled = true;
            this.comBox_Branch.Location = new System.Drawing.Point(93, 13);
            this.comBox_Branch.Name = "comBox_Branch";
            this.comBox_Branch.Size = new System.Drawing.Size(256, 31);
            this.comBox_Branch.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Branch:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel6.Controls.Add(this.Txt_Name);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(25, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(362, 52);
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
            this.Txt_Name.Size = new System.Drawing.Size(256, 29);
            this.Txt_Name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 13);
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
            this.panel5.Size = new System.Drawing.Size(362, 52);
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
            this.Txt_Id.Location = new System.Drawing.Point(93, 13);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.ReadOnly = true;
            this.Txt_Id.Size = new System.Drawing.Size(255, 29);
            this.Txt_Id.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 13);
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
            this.panel4.Size = new System.Drawing.Size(492, 50);
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
            this.Txt_Search.Size = new System.Drawing.Size(409, 29);
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
            this.label1.Location = new System.Drawing.Point(163, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Intakes";
            // 
            // Frm_Intakes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 666);
            this.Controls.Add(this.dgvIntakes);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_Intakes";
            this.Text = "Frm_Intakes";
            this.Load += new System.EventHandler(this.Frm_Intakes_Load);
            this.Shown += new System.EventHandler(this.Frm_Intakes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntakes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grBoxIntakeInfo.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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

        private System.Windows.Forms.DataGridView dgvIntakes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddIntake;
        private System.Windows.Forms.GroupBox grBoxIntakeInfo;
        private Responsive_Design.Anmh_Controls.AnmhButton Btn_Save;
        private Responsive_Design.Anmh_Controls.AnmhButton Btn_Refresh;
        private Responsive_Design.Anmh_Controls.AnmhButton btn_Cancel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comBox_Branch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intake_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Date;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_RemoveTrack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_AddTrack;
        private System.Windows.Forms.ListBox tracksList;
        private System.Windows.Forms.ListBox listBox_AddedTracksList;
    }
}