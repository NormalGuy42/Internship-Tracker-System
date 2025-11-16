namespace HR
{
    partial class HR
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Student_Application = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            INTERNSHIP_ID = new TextBox();
            Status = new TextBox();
            Submission_Date = new TextBox();
            RESUME = new TextBox();
            ID = new TextBox();
            STUDENT_ID = new TextBox();
            PREVIOUS = new Button();
            NEXT = new Button();
            DECLINE = new Button();
            ACCEPT = new Button();
            Student_Application.SuspendLayout();
            SuspendLayout();
            // 
            // Student_Application
            // 
            Student_Application.Controls.Add(label6);
            Student_Application.Controls.Add(label5);
            Student_Application.Controls.Add(label4);
            Student_Application.Controls.Add(label3);
            Student_Application.Controls.Add(label2);
            Student_Application.Controls.Add(label1);
            Student_Application.Controls.Add(INTERNSHIP_ID);
            Student_Application.Controls.Add(Status);
            Student_Application.Controls.Add(Submission_Date);
            Student_Application.Controls.Add(RESUME);
            Student_Application.Controls.Add(ID);
            Student_Application.Controls.Add(STUDENT_ID);
            Student_Application.Controls.Add(PREVIOUS);
            Student_Application.Controls.Add(NEXT);
            Student_Application.Controls.Add(DECLINE);
            Student_Application.Controls.Add(ACCEPT);
            Student_Application.Location = new Point(12, 12);
            Student_Application.Name = "Student_Application";
            Student_Application.Size = new Size(778, 426);
            Student_Application.TabIndex = 0;
            Student_Application.TabStop = false;
            Student_Application.Text = "Student Application";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 110);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 15;
            label6.Text = "RESUME";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 240);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 14;
            label5.Text = "SUBMISSION DATE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 240);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 13;
            label4.Text = "STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 23);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 12;
            label3.Text = "INTERNSHIP ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 23);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 11;
            label2.Text = "STUDENT ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 23);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // INTERNSHIP_ID
            // 
            INTERNSHIP_ID.Location = new Point(568, 51);
            INTERNSHIP_ID.Name = "INTERNSHIP_ID";
            INTERNSHIP_ID.ReadOnly = true;
            INTERNSHIP_ID.Size = new Size(125, 27);
            INTERNSHIP_ID.TabIndex = 9;
            // 
            // Status
            // 
            Status.Location = new Point(48, 263);
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Size = new Size(125, 27);
            Status.TabIndex = 8;
            // 
            // Submission_Date
            // 
            Submission_Date.Location = new Point(583, 263);
            Submission_Date.Name = "Submission_Date";
            Submission_Date.ReadOnly = true;
            Submission_Date.Size = new Size(125, 27);
            Submission_Date.TabIndex = 7;
            // 
            // RESUME
            // 
            RESUME.Location = new Point(48, 133);
            RESUME.Name = "RESUME";
            RESUME.ReadOnly = true;
            RESUME.Size = new Size(645, 27);
            RESUME.TabIndex = 6;
            // 
            // ID
            // 
            ID.Location = new Point(48, 51);
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Size = new Size(125, 27);
            ID.TabIndex = 5;
            // 
            // STUDENT_ID
            // 
            STUDENT_ID.Location = new Point(293, 51);
            STUDENT_ID.Name = "STUDENT_ID";
            STUDENT_ID.ReadOnly = true;
            STUDENT_ID.Size = new Size(125, 27);
            STUDENT_ID.TabIndex = 4;
            // 
            // PREVIOUS
            // 
            PREVIOUS.Location = new Point(0, 391);
            PREVIOUS.Name = "PREVIOUS";
            PREVIOUS.Size = new Size(94, 29);
            PREVIOUS.TabIndex = 3;
            PREVIOUS.Text = "<PREVIOUS";
            PREVIOUS.UseVisualStyleBackColor = true;
            PREVIOUS.Click += PREVIOUS_Click;
            // 
            // NEXT
            // 
            NEXT.Location = new Point(678, 391);
            NEXT.Name = "NEXT";
            NEXT.Size = new Size(94, 29);
            NEXT.TabIndex = 2;
            NEXT.Text = "NEXT>";
            NEXT.UseVisualStyleBackColor = true;
            NEXT.Click += NEXT_Click;
            // 
            // DECLINE
            // 
            DECLINE.Location = new Point(131, 353);
            DECLINE.Name = "DECLINE";
            DECLINE.Size = new Size(121, 39);
            DECLINE.TabIndex = 1;
            DECLINE.Text = "DECLINE";
            DECLINE.UseVisualStyleBackColor = true;
            DECLINE.Click += DECLINE_Click;
            // 
            // ACCEPT
            // 
            ACCEPT.Location = new Point(510, 353);
            ACCEPT.Name = "ACCEPT";
            ACCEPT.Size = new Size(121, 39);
            ACCEPT.TabIndex = 0;
            ACCEPT.Text = "ACCEPT";
            ACCEPT.UseVisualStyleBackColor = true;
            ACCEPT.Click += ACCEPT_Click;
            // 
            // HR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Student_Application);
            Name = "HR";
            Text = "HR";
            Student_Application.ResumeLayout(false);
            Student_Application.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Student_Application;
        private Button DECLINE;
        private Button ACCEPT;
        private Button NEXT;
        private Button PREVIOUS;
        private TextBox INTERNSHIP_ID;
        private TextBox Status;
        private TextBox Submission_Date;
        private TextBox RESUME;
        private TextBox ID;
        private TextBox STUDENT_ID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}
