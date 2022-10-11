namespace add_intake
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
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.NameIntake = new System.Windows.Forms.TextBox();
            this.Start_Month = new System.Windows.Forms.TextBox();
            this.End_Month = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Branch_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Create);
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(16, 36);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(197, 34);
            this.ID.TabIndex = 1;
            this.ID.TextChanged += new System.EventHandler(this.Add_Id);
            // 
            // NameIntake
            // 
            this.NameIntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameIntake.Location = new System.Drawing.Point(16, 96);
            this.NameIntake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameIntake.Name = "NameIntake";
            this.NameIntake.Size = new System.Drawing.Size(197, 34);
            this.NameIntake.TabIndex = 2;
            this.NameIntake.TextChanged += new System.EventHandler(this.Add_Name);
            // 
            // Start_Month
            // 
            this.Start_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Month.Location = new System.Drawing.Point(16, 166);
            this.Start_Month.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start_Month.Name = "Start_Month";
            this.Start_Month.Size = new System.Drawing.Size(197, 34);
            this.Start_Month.TabIndex = 3;
            this.Start_Month.TextChanged += new System.EventHandler(this.Add_Start_Month);
            // 
            // End_Month
            // 
            this.End_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Month.Location = new System.Drawing.Point(16, 247);
            this.End_Month.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.End_Month.Name = "End_Month";
            this.End_Month.Size = new System.Drawing.Size(197, 34);
            this.End_Month.TabIndex = 4;
            this.End_Month.TextChanged += new System.EventHandler(this.Add_End_Month);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Intake-ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start-Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "End-Month";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 467);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.update);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 467);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.delete);
            // 
            // Branch_ID
            // 
            this.Branch_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Branch_ID.Location = new System.Drawing.Point(16, 351);
            this.Branch_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Branch_ID.Name = "Branch_ID";
            this.Branch_ID.Size = new System.Drawing.Size(197, 34);
            this.Branch_ID.TabIndex = 11;
            this.Branch_ID.Click += new System.EventHandler(this.BranchID);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Branch_ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Branch_ID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.End_Month);
            this.Controls.Add(this.Start_Month);
            this.Controls.Add(this.NameIntake);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox NameIntake;
        private System.Windows.Forms.TextBox Start_Month;
        private System.Windows.Forms.TextBox End_Month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Branch_ID;
        private System.Windows.Forms.Label label5;
    }
}

