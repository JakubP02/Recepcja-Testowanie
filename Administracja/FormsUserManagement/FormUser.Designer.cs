namespace Administracja.Forms
{
    partial class FormUser
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerExpirationDate = new DateTimePicker();
            textBoxId = new TextBox();
            textBoxEmpLastName = new TextBox();
            textBoxEmpRole = new TextBox();
            textBoxUsername = new TextBox();
            textBoxEmpFirstName = new TextBox();
            textBoxStatus = new TextBox();
            buttonChangeStatus = new Button();
            buttonEdit = new Button();
            buttonClose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePickerExpirationDate);
            groupBox1.Controls.Add(textBoxId);
            groupBox1.Controls.Add(textBoxEmpLastName);
            groupBox1.Controls.Add(textBoxEmpRole);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(textBoxEmpFirstName);
            groupBox1.Controls.Add(textBoxStatus);
            groupBox1.Controls.Add(buttonChangeStatus);
            groupBox1.Controls.Add(buttonEdit);
            groupBox1.Controls.Add(buttonClose);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 446);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information about User";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 179);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 18;
            label7.Text = "Expiration Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 129);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 17;
            label6.Text = "User Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(558, 129);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 16;
            label5.Text = "Employee Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(558, 84);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 15;
            label4.Text = "Employee Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(558, 31);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 14;
            label3.Text = "Employee First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 84);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 13;
            label2.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 31);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 12;
            label1.Text = "Id";
            // 
            // dateTimePickerExpirationDate
            // 
            dateTimePickerExpirationDate.Location = new Point(68, 197);
            dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            dateTimePickerExpirationDate.Size = new Size(200, 23);
            dateTimePickerExpirationDate.TabIndex = 11;
            dateTimePickerExpirationDate.ValueChanged += dateTimePickerExpirationDate_ValueChanged;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(68, 49);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(150, 23);
            textBoxId.TabIndex = 10;
            // 
            // textBoxEmpLastName
            // 
            textBoxEmpLastName.Location = new Point(558, 102);
            textBoxEmpLastName.Name = "textBoxEmpLastName";
            textBoxEmpLastName.ReadOnly = true;
            textBoxEmpLastName.Size = new Size(150, 23);
            textBoxEmpLastName.TabIndex = 9;
            // 
            // textBoxEmpRole
            // 
            textBoxEmpRole.Location = new Point(558, 147);
            textBoxEmpRole.Name = "textBoxEmpRole";
            textBoxEmpRole.ReadOnly = true;
            textBoxEmpRole.Size = new Size(150, 23);
            textBoxEmpRole.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(68, 102);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.ReadOnly = true;
            textBoxUsername.Size = new Size(150, 23);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxEmpFirstName
            // 
            textBoxEmpFirstName.Location = new Point(558, 49);
            textBoxEmpFirstName.Name = "textBoxEmpFirstName";
            textBoxEmpFirstName.ReadOnly = true;
            textBoxEmpFirstName.Size = new Size(150, 23);
            textBoxEmpFirstName.TabIndex = 5;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(68, 147);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(146, 23);
            textBoxStatus.TabIndex = 4;
            // 
            // buttonChangeStatus
            // 
            buttonChangeStatus.Location = new Point(294, 388);
            buttonChangeStatus.Name = "buttonChangeStatus";
            buttonChangeStatus.Size = new Size(219, 45);
            buttonChangeStatus.TabIndex = 3;
            buttonChangeStatus.Text = "Change User Status";
            buttonChangeStatus.UseVisualStyleBackColor = true;
            buttonChangeStatus.Click += buttonChangeStatus_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(519, 388);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(219, 45);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(51, 388);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(219, 45);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUser";
            Text = "FormUser";
            Load += FormUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonEdit;
        private Button buttonClose;
        private Button buttonChangeStatus;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerExpirationDate;
        private TextBox textBoxId;
        private TextBox textBoxEmpLastName;
        private TextBox textBoxEmpRole;
        private TextBox textBoxUsername;
        private TextBox textBoxEmpFirstName;
        private TextBox textBoxStatus;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
    }
}