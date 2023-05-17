namespace Administracja.Forms
{
    partial class FormAddEmployee
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
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            comboBoxSex = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            label8 = new Label();
            textBoxMailingAddress = new TextBox();
            buttonNext = new Button();
            buttonCancel = new Button();
            groupBox2 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            comboBoxSpecialties = new ComboBox();
            labelSpecialties = new Label();
            comboBoxRole = new ComboBox();
            dateTimePickerBirth = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxPESEL = new TextBox();
            label2 = new Label();
            textBoxLastName = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(buttonNext);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 448);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add employee";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxSex);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxPhone);
            groupBox3.Controls.Add(textBoxEmail);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBoxMailingAddress);
            groupBox3.Location = new Point(80, 249);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(624, 125);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Not required";
            // 
            // comboBoxSex
            // 
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(361, 96);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(219, 23);
            comboBoxSex.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(361, 78);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 14;
            label9.Text = "Sex:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 78);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 12;
            label7.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 34);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(361, 52);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(219, 23);
            textBoxPhone.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(38, 96);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(219, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 34);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 7;
            label8.Text = "Mailing address:";
            // 
            // textBoxMailingAddress
            // 
            textBoxMailingAddress.Location = new Point(38, 52);
            textBoxMailingAddress.Name = "textBoxMailingAddress";
            textBoxMailingAddress.Size = new Size(219, 23);
            textBoxMailingAddress.TabIndex = 6;
            // 
            // buttonNext
            // 
            buttonNext.Enabled = false;
            buttonNext.Location = new Point(441, 388);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(219, 45);
            buttonNext.TabIndex = 0;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(117, 388);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(219, 45);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkedListBox1);
            groupBox2.Controls.Add(comboBoxSpecialties);
            groupBox2.Controls.Add(labelSpecialties);
            groupBox2.Controls.Add(comboBoxRole);
            groupBox2.Controls.Add(dateTimePickerBirth);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxPESEL);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxLastName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxName);
            groupBox2.Location = new Point(80, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(624, 231);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Required";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(361, 136);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(219, 58);
            checkedListBox1.TabIndex = 14;
            // 
            // comboBoxSpecialties
            // 
            comboBoxSpecialties.FormattingEnabled = true;
            comboBoxSpecialties.Location = new Point(38, 178);
            comboBoxSpecialties.Name = "comboBoxSpecialties";
            comboBoxSpecialties.Size = new Size(219, 23);
            comboBoxSpecialties.TabIndex = 13;
            comboBoxSpecialties.Visible = false;
            comboBoxSpecialties.SelectedIndexChanged += comboBoxSpecialties_SelectedIndexChanged;
            // 
            // labelSpecialties
            // 
            labelSpecialties.AutoSize = true;
            labelSpecialties.Location = new Point(360, 118);
            labelSpecialties.Name = "labelSpecialties";
            labelSpecialties.Size = new Size(65, 15);
            labelSpecialties.TabIndex = 12;
            labelSpecialties.Text = "Specialties:";
            labelSpecialties.Visible = false;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(361, 92);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(219, 23);
            comboBoxRole.TabIndex = 11;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            comboBoxRole.DropDownClosed += comboBoxRole_DropDownClosed;
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Location = new Point(361, 48);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(219, 23);
            dateTimePickerBirth.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 74);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 30);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 7;
            label4.Text = "Date of birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 118);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "PESEL:";
            // 
            // textBoxPESEL
            // 
            textBoxPESEL.Location = new Point(38, 136);
            textBoxPESEL.Name = "textBoxPESEL";
            textBoxPESEL.Size = new Size(219, 23);
            textBoxPESEL.TabIndex = 4;
            textBoxPESEL.TextChanged += textBoxPESEL_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Last name:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(38, 92);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(219, 23);
            textBoxLastName.TabIndex = 2;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(38, 48);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(219, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddEmployee";
            Text = "FormAddEmployee";
            Load += FormAddEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePickerBirth;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxPESEL;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label1;
        private TextBox textBoxName;
        private Button buttonCancel;
        private Button buttonNext;
        private Label label7;
        private Label label6;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private Label label8;
        private TextBox textBoxMailingAddress;
        private Label label9;
        private ComboBox comboBoxSpecialties;
        private Label labelSpecialties;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxSex;
        private CheckedListBox checkedListBox1;
    }
}