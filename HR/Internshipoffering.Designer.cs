namespace HR
{
    partial class InternshipOffer
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
            IntershipOffer_Box = new GroupBox();
            Internship_length = new GroupBox();
            Month_6 = new RadioButton();
            Months_12 = new RadioButton();
            Month_3 = new RadioButton();
            Month_1 = new RadioButton();
            Send_Offer = new Button();
            Cancel_Offer = new Button();
            IntershipOffer_Box.SuspendLayout();
            Internship_length.SuspendLayout();
            SuspendLayout();
            // 
            // IntershipOffer_Box
            // 
            IntershipOffer_Box.Controls.Add(Internship_length);
            IntershipOffer_Box.Controls.Add(Send_Offer);
            IntershipOffer_Box.Controls.Add(Cancel_Offer);
            IntershipOffer_Box.Location = new Point(49, 28);
            IntershipOffer_Box.Name = "IntershipOffer_Box";
            IntershipOffer_Box.Size = new Size(699, 396);
            IntershipOffer_Box.TabIndex = 0;
            IntershipOffer_Box.TabStop = false;
            IntershipOffer_Box.Text = "What type to offer?";
            // 
            // Internship_length
            // 
            Internship_length.Controls.Add(Month_6);
            Internship_length.Controls.Add(Months_12);
            Internship_length.Controls.Add(Month_3);
            Internship_length.Controls.Add(Month_1);
            Internship_length.Location = new Point(67, 47);
            Internship_length.Name = "Internship_length";
            Internship_length.Size = new Size(554, 180);
            Internship_length.TabIndex = 7;
            Internship_length.TabStop = false;
            // 
            // Month_6
            // 
            Month_6.AutoSize = true;
            Month_6.Location = new Point(335, 39);
            Month_6.Name = "Month_6";
            Month_6.Size = new Size(91, 24);
            Month_6.TabIndex = 9;
            Month_6.TabStop = true;
            Month_6.Text = "6 Months";
            Month_6.UseVisualStyleBackColor = true;
            // 
            // Months_12
            // 
            Months_12.AutoSize = true;
            Months_12.Location = new Point(335, 126);
            Months_12.Name = "Months_12";
            Months_12.Size = new Size(99, 24);
            Months_12.TabIndex = 8;
            Months_12.TabStop = true;
            Months_12.Text = "12 Months";
            Months_12.UseVisualStyleBackColor = true;
            // 
            // Month_3
            // 
            Month_3.AutoSize = true;
            Month_3.Location = new Point(71, 126);
            Month_3.Name = "Month_3";
            Month_3.Size = new Size(91, 24);
            Month_3.TabIndex = 7;
            Month_3.TabStop = true;
            Month_3.Text = "3 Months";
            Month_3.UseVisualStyleBackColor = true;
            // 
            // Month_1
            // 
            Month_1.AutoSize = true;
            Month_1.Location = new Point(71, 39);
            Month_1.Name = "Month_1";
            Month_1.Size = new Size(85, 24);
            Month_1.TabIndex = 6;
            Month_1.TabStop = true;
            Month_1.Text = "1 Month";
            Month_1.UseVisualStyleBackColor = true;
            // 
            // Send_Offer
            // 
            Send_Offer.Location = new Point(498, 321);
            Send_Offer.Name = "Send_Offer";
            Send_Offer.Size = new Size(123, 36);
            Send_Offer.TabIndex = 5;
            Send_Offer.Text = "Offer";
            Send_Offer.UseVisualStyleBackColor = true;
            Send_Offer.Click += Send_Offer_Click;
            // 
            // Cancel_Offer
            // 
            Cancel_Offer.Location = new Point(80, 321);
            Cancel_Offer.Name = "Cancel_Offer";
            Cancel_Offer.Size = new Size(123, 36);
            Cancel_Offer.TabIndex = 4;
            Cancel_Offer.Text = "Cancel";
            Cancel_Offer.UseVisualStyleBackColor = true;
            Cancel_Offer.Click += Cancel_Offer_Click;
            // 
            // InternshipOffer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IntershipOffer_Box);
            Name = "InternshipOffer";
            Text = "InternshipOffer";
            IntershipOffer_Box.ResumeLayout(false);
            Internship_length.ResumeLayout(false);
            Internship_length.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox IntershipOffer_Box;
        private RadioButton Month_1;
        private Button Send_Offer;
        private Button Cancel_Offer;
        private GroupBox Internship_length;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private RadioButton Month_6;
        private RadioButton Months_12;
        private RadioButton Month_3;
    }
}