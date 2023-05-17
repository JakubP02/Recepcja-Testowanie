namespace Administracja.FormsCalendar
{
    partial class FormCreateCalendar
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
            label5 = new Label();
            label4 = new Label();
            comboBoxMonth = new ComboBox();
            dateTimePickerYear = new DateTimePicker();
            buttonGenerate = new Button();
            label1 = new Label();
            textBoxCalendarName = new TextBox();
            buttonBack = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxMonth);
            groupBox1.Controls.Add(dateTimePickerYear);
            groupBox1.Controls.Add(buttonGenerate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxCalendarName);
            groupBox1.Location = new Point(26, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 239);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generate Calendar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 113);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 6;
            label5.Text = "Month:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 69);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "Year:";
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(22, 128);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(219, 23);
            comboBoxMonth.TabIndex = 4;
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.Location = new Point(22, 87);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.Size = new Size(219, 23);
            dateTimePickerYear.TabIndex = 3;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(22, 168);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(219, 28);
            buttonGenerate.TabIndex = 2;
            buttonGenerate.Text = "Generate Calendar";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Calendar name:";
            // 
            // textBoxCalendarName
            // 
            textBoxCalendarName.Location = new Point(22, 43);
            textBoxCalendarName.Name = "textBoxCalendarName";
            textBoxCalendarName.Size = new Size(219, 23);
            textBoxCalendarName.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(22, 202);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(219, 28);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormCreateCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormCreateCalendar";
            Text = "FormCreateCalendar";
            Load += FormCreateCalendar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxMonth;
        private DateTimePicker dateTimePickerYear;
        private Button buttonGenerate;
        private Label label1;
        private TextBox textBoxCalendarName;
        private Button buttonBack;
    }
}