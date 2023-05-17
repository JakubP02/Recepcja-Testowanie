namespace Administracja.Forms
{
    partial class FormAddOffice
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
            textBoxStatus = new TextBox();
            labelStatus = new Label();
            buttonChangeStatus = new Button();
            textBoxNumber = new TextBox();
            comboBoxSpecialization = new ComboBox();
            checkBoxIsGeneral = new CheckBox();
            labelSpecialties = new Label();
            buttonNext = new Button();
            label1 = new Label();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxStatus);
            groupBox1.Controls.Add(labelStatus);
            groupBox1.Controls.Add(buttonChangeStatus);
            groupBox1.Controls.Add(textBoxNumber);
            groupBox1.Controls.Add(comboBoxSpecialization);
            groupBox1.Controls.Add(checkBoxIsGeneral);
            groupBox1.Controls.Add(labelSpecialties);
            groupBox1.Controls.Add(buttonNext);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Location = new Point(10, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 448);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add office";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(319, 280);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(157, 23);
            textBoxStatus.TabIndex = 21;
            textBoxStatus.Visible = false;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(319, 252);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 20;
            labelStatus.Text = "Status";
            labelStatus.Visible = false;
            // 
            // buttonChangeStatus
            // 
            buttonChangeStatus.Location = new Point(286, 388);
            buttonChangeStatus.Name = "buttonChangeStatus";
            buttonChangeStatus.Size = new Size(219, 45);
            buttonChangeStatus.TabIndex = 19;
            buttonChangeStatus.Text = "Change Status";
            buttonChangeStatus.UseVisualStyleBackColor = true;
            buttonChangeStatus.Visible = false;
            buttonChangeStatus.Click += buttonChangeStatus_Click;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(318, 100);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(158, 23);
            textBoxNumber.TabIndex = 18;
            // 
            // comboBoxSpecialization
            // 
            comboBoxSpecialization.FormattingEnabled = true;
            comboBoxSpecialization.Location = new Point(318, 155);
            comboBoxSpecialization.Name = "comboBoxSpecialization";
            comboBoxSpecialization.Size = new Size(158, 23);
            comboBoxSpecialization.TabIndex = 17;
            // 
            // checkBoxIsGeneral
            // 
            checkBoxIsGeneral.AutoSize = true;
            checkBoxIsGeneral.Location = new Point(319, 203);
            checkBoxIsGeneral.Name = "checkBoxIsGeneral";
            checkBoxIsGeneral.Size = new Size(132, 19);
            checkBoxIsGeneral.TabIndex = 15;
            checkBoxIsGeneral.Text = "For general meeting";
            checkBoxIsGeneral.UseVisualStyleBackColor = true;
            // 
            // labelSpecialties
            // 
            labelSpecialties.AutoSize = true;
            labelSpecialties.Location = new Point(319, 137);
            labelSpecialties.Name = "labelSpecialties";
            labelSpecialties.Size = new Size(65, 15);
            labelSpecialties.TabIndex = 12;
            labelSpecialties.Text = "Specialties:";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(522, 388);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(219, 45);
            buttonNext.TabIndex = 0;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 72);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Number";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(45, 388);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(219, 45);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormAddOffice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormAddOffice";
            Text = "FormAddOffice";
            Load += FormAddOffice_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBoxIsGeneral;
        private Label labelSpecialties;
        private Button buttonNext;
        private Label label1;
        private Button buttonCancel;
        private ComboBox comboBoxSpecialization;
        private TextBox textBoxNumber;
        private TextBox textBoxStatus;
        private Label labelStatus;
        private Button buttonChangeStatus;
    }
}