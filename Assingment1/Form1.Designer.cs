namespace Assingment1
{
    partial class Form1
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
            Lbl_Firstname = new Label();
            Lbl_Lastname = new Label();
            Lbl_Hrsworked = new Label();
            Txt_FirstnameInput = new TextBox();
            Txt_LastnameInput = new TextBox();
            Txt_HoursworkedInput = new TextBox();
            Btn_Sum = new Button();
            Btn_Clear = new Button();
            Lbl_Results = new Label();
            SuspendLayout();
            // 
            // Lbl_Firstname
            // 
            Lbl_Firstname.AutoSize = true;
            Lbl_Firstname.Location = new Point(89, 23);
            Lbl_Firstname.Name = "Lbl_Firstname";
            Lbl_Firstname.Size = new Size(64, 15);
            Lbl_Firstname.TabIndex = 0;
            Lbl_Firstname.Text = "&First Name";
            Lbl_Firstname.Click += Lbl_Firstname_Click;
            // 
            // Lbl_Lastname
            // 
            Lbl_Lastname.AutoSize = true;
            Lbl_Lastname.Location = new Point(341, 23);
            Lbl_Lastname.Name = "Lbl_Lastname";
            Lbl_Lastname.Size = new Size(63, 15);
            Lbl_Lastname.TabIndex = 1;
            Lbl_Lastname.Text = "&Last Name";
            Lbl_Lastname.Click += Lbl_Lastname_Click;
            // 
            // Lbl_Hrsworked
            // 
            Lbl_Hrsworked.AutoSize = true;
            Lbl_Hrsworked.Location = new Point(584, 23);
            Lbl_Hrsworked.Name = "Lbl_Hrsworked";
            Lbl_Hrsworked.Size = new Size(83, 15);
            Lbl_Hrsworked.TabIndex = 2;
            Lbl_Hrsworked.Text = "&Hours Worked";
            Lbl_Hrsworked.Click += Lbl_Hrsworked_Click;
            // 
            // Txt_FirstnameInput
            // 
            Txt_FirstnameInput.Location = new Point(58, 41);
            Txt_FirstnameInput.Name = "Txt_FirstnameInput";
            Txt_FirstnameInput.Size = new Size(133, 23);
            Txt_FirstnameInput.TabIndex = 3;
            Txt_FirstnameInput.TextChanged += Txt_FirstnameInput_TextChanged;
            // 
            // Txt_LastnameInput
            // 
            Txt_LastnameInput.Location = new Point(303, 41);
            Txt_LastnameInput.Name = "Txt_LastnameInput";
            Txt_LastnameInput.Size = new Size(140, 23);
            Txt_LastnameInput.TabIndex = 4;
            Txt_LastnameInput.TextChanged += Txt_LastnameInput_TextChanged;
            // 
            // Txt_HoursworkedInput
            // 
            Txt_HoursworkedInput.Location = new Point(551, 41);
            Txt_HoursworkedInput.Name = "Txt_HoursworkedInput";
            Txt_HoursworkedInput.Size = new Size(143, 23);
            Txt_HoursworkedInput.TabIndex = 5;
            Txt_HoursworkedInput.TextChanged += Txt_HoursworkedInput_TextChanged;
            // 
            // Btn_Sum
            // 
            Btn_Sum.Location = new Point(24, 203);
            Btn_Sum.Name = "Btn_Sum";
            Btn_Sum.Size = new Size(75, 23);
            Btn_Sum.TabIndex = 6;
            Btn_Sum.Text = "Summarize";
            Btn_Sum.UseVisualStyleBackColor = true;
            Btn_Sum.Click += Btn_Sum_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.Location = new Point(105, 203);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(75, 23);
            Btn_Clear.TabIndex = 7;
            Btn_Clear.Text = "Clear";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Lbl_Results
            // 
            Lbl_Results.BorderStyle = BorderStyle.FixedSingle;
            Lbl_Results.Location = new Point(12, 267);
            Lbl_Results.Name = "Lbl_Results";
            Lbl_Results.Size = new Size(764, 174);
            Lbl_Results.TabIndex = 8;
            Lbl_Results.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_Results.Click += Lbl_Results_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl_Results);
            Controls.Add(Btn_Clear);
            Controls.Add(Btn_Sum);
            Controls.Add(Txt_HoursworkedInput);
            Controls.Add(Txt_LastnameInput);
            Controls.Add(Txt_FirstnameInput);
            Controls.Add(Lbl_Hrsworked);
            Controls.Add(Lbl_Lastname);
            Controls.Add(Lbl_Firstname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Firstname;
        private Label Lbl_Lastname;
        private Label Lbl_Hrsworked;
        private TextBox Txt_FirstnameInput;
        private TextBox Txt_LastnameInput;
        private TextBox Txt_HoursworkedInput;
        private Button Btn_Sum;
        private Button Btn_Clear;
        private Label Lbl_Results;
    }
}
