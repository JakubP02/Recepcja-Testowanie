namespace Administracja.FormsCalendar
{
    partial class FormCalendarEntityUpdate
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
            listBoxOffice = new ListBox();
            label7 = new Label();
            buttonCancel = new Button();
            buttonAdd = new Button();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dateTimePickerTo = new DateTimePicker();
            dateTimePickerFrom = new DateTimePicker();
            comboBoxDoctor = new ComboBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            dateTimePickerYear = new DateTimePicker();
            comboBoxDay = new ComboBox();
            comboBoxMonth = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxOffice);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(buttonCancel);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 448);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generate Calendar";
            // 
            // listBoxOffice
            // 
            listBoxOffice.FormattingEnabled = true;
            listBoxOffice.ItemHeight = 15;
            listBoxOffice.Location = new Point(568, 63);
            listBoxOffice.Name = "listBoxOffice";
            listBoxOffice.Size = new Size(162, 214);
            listBoxOffice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(568, 45);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 10;
            label7.Text = "Office:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(117, 388);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(219, 45);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(441, 388);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(219, 45);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Edit";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTimePickerTo);
            groupBox3.Controls.Add(dateTimePickerFrom);
            groupBox3.Controls.Add(comboBoxDoctor);
            groupBox3.Location = new Point(288, 43);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(252, 234);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Doctor:";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 156);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 7;
            label6.Text = "To";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 117);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 6;
            label5.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 80);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 5;
            label4.Text = "Working hours:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 25);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Choose Doctor:";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(80, 151);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(80, 23);
            dateTimePickerTo.TabIndex = 2;
            dateTimePickerTo.ValueChanged += dateTimePickerTo_ValueChanged;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(80, 112);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(79, 23);
            dateTimePickerFrom.TabIndex = 1;
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged;
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(22, 43);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(207, 23);
            comboBoxDoctor.TabIndex = 0;
            comboBoxDoctor.SelectedIndexChanged += comboBoxDoctor_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dateTimePickerYear);
            groupBox2.Controls.Add(comboBoxDay);
            groupBox2.Controls.Add(comboBoxMonth);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(20, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(237, 234);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 25);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 6;
            label8.Text = "Choose Year:";
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.Enabled = false;
            dateTimePickerYear.Location = new Point(36, 43);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.Size = new Size(159, 23);
            dateTimePickerYear.TabIndex = 5;
            // 
            // comboBoxDay
            // 
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Location = new Point(36, 150);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(159, 23);
            comboBoxDay.TabIndex = 4;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.Enabled = false;
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(36, 97);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(159, 23);
            comboBoxMonth.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 79);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Choose Month:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 132);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Choose Day:";
            // 
            // FormCalendarEntityUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalendarEntityUpdate";
            Text = "FormCalendarEntityUpdate";
            Load += FormCalendarEntityUpdate_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonCancel;
        private Button buttonAdd;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private ComboBox comboBoxDoctor;
        private GroupBox groupBox2;
        private Label label8;
        private DateTimePicker dateTimePickerYear;
        private ComboBox comboBoxDay;
        private ComboBox comboBoxMonth;
        private Label label1;
        private Label label2;
        private ListBox listBoxOffice;
        private Label label7;
    }
}