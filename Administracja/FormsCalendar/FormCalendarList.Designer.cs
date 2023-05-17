namespace Administracja.FormsCalendar
{
    partial class FormCalendarList
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
            dataGridViewCalendars = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            buttonRemove = new Button();
            buttonGenCalendar = new Button();
            buttonGenerate = new Button();
            buttonShowContent = new Button();
            textBoxFilterName = new TextBox();
            comboBoxStatus = new ComboBox();
            buttonClear = new Button();
            buttonFilter = new Button();
            label2 = new Label();
            label3 = new Label();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendars).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCalendars
            // 
            dataGridViewCalendars.AllowUserToAddRows = false;
            dataGridViewCalendars.AllowUserToDeleteRows = false;
            dataGridViewCalendars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCalendars.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCalendars.Location = new Point(12, 12);
            dataGridViewCalendars.Name = "dataGridViewCalendars";
            dataGridViewCalendars.RowHeadersVisible = false;
            dataGridViewCalendars.RowHeadersWidth = 51;
            dataGridViewCalendars.RowTemplate.Height = 25;
            dataGridViewCalendars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCalendars.Size = new Size(489, 254);
            dataGridViewCalendars.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(558, 318);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(189, 45);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Remove Calendar";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonGenCalendar
            // 
            buttonGenCalendar.Location = new Point(558, 116);
            buttonGenCalendar.Name = "buttonGenCalendar";
            buttonGenCalendar.Size = new Size(189, 47);
            buttonGenCalendar.TabIndex = 7;
            buttonGenCalendar.Text = "Generate a calendar based on another";
            buttonGenCalendar.UseVisualStyleBackColor = true;
            buttonGenCalendar.Click += buttonGenCalendar_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(558, 66);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(189, 44);
            buttonGenerate.TabIndex = 2;
            buttonGenerate.Text = "Generate Calendar";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonShowContent
            // 
            buttonShowContent.Location = new Point(558, 238);
            buttonShowContent.Name = "buttonShowContent";
            buttonShowContent.Size = new Size(189, 45);
            buttonShowContent.TabIndex = 5;
            buttonShowContent.Text = "Show content of calendar";
            buttonShowContent.UseVisualStyleBackColor = true;
            buttonShowContent.Click += buttonShowContent_Click;
            // 
            // textBoxFilterName
            // 
            textBoxFilterName.Location = new Point(91, 315);
            textBoxFilterName.Name = "textBoxFilterName";
            textBoxFilterName.Size = new Size(159, 23);
            textBoxFilterName.TabIndex = 6;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(268, 315);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(159, 23);
            comboBoxStatus.TabIndex = 7;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(91, 344);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(159, 33);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(268, 344);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(159, 36);
            buttonFilter.TabIndex = 9;
            buttonFilter.Text = "Filter";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 297);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 10;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 297);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Status:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(558, 187);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(189, 45);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add contet to the calendar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormCalendarList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGenCalendar);
            Controls.Add(buttonGenerate);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonFilter);
            Controls.Add(buttonClear);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxFilterName);
            Controls.Add(buttonShowContent);
            Controls.Add(buttonRemove);
            Controls.Add(dataGridViewCalendars);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCalendarList";
            Text = "FormCalendarList";
            Load += FormCalendarList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCalendars;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button buttonRemove;
        private Button buttonGenerate;
        private Button buttonShowContent;
        private TextBox textBoxFilterName;
        private ComboBox comboBoxStatus;
        private Button buttonClear;
        private Button buttonFilter;
        private Label label2;
        private Label label3;
        private Button buttonAdd;
        private Button buttonGenCalendar;
    }
}