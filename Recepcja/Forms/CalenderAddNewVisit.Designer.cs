namespace Patient_handling
{
    partial class CalenderAddNewVisit
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
            button_next = new Button();
            button_previous = new Button();
            label_date = new Label();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            dayContainer = new FlowLayoutPanel();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // button_next
            // 
            button_next.Location = new Point(849, 492);
            button_next.Name = "button_next";
            button_next.Size = new Size(75, 23);
            button_next.TabIndex = 36;
            button_next.Text = "next";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // button_previous
            // 
            button_previous.Location = new Point(759, 492);
            button_previous.Name = "button_previous";
            button_previous.Size = new Size(75, 23);
            button_previous.TabIndex = 35;
            button_previous.Text = "previous";
            button_previous.UseVisualStyleBackColor = true;
            button_previous.Click += button_previous_Click;
            // 
            // label_date
            // 
            label_date.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_date.Location = new Point(199, 19);
            label_date.Name = "label_date";
            label_date.Size = new Size(437, 30);
            label_date.TabIndex = 44;
            label_date.Text = "MONTH YEAR";
            label_date.TextAlign = ContentAlignment.MiddleCenter;
            label_date.Click += label_date_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 71);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 52;
            label1.Text = "Sunday";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(810, 71);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 51;
            label9.Text = "Saturday";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(691, 71);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 50;
            label10.Text = "Friday";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(548, 71);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 49;
            label11.Text = "Thursday";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(420, 71);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 48;
            label12.Text = "Wednesday";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(299, 71);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 47;
            label13.Text = "Tuesday";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(185, 71);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 46;
            label14.Text = "Monday";
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(21, 105);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(906, 381);
            dayContainer.TabIndex = 45;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(759, 521);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 23);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CalenderAddNewVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 573);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(dayContainer);
            Controls.Add(label_date);
            Controls.Add(button_next);
            Controls.Add(button_previous);
            Name = "CalenderAddNewVisit";
            Text = "CalenderAddNewVisit";
            Load += CalenderAddNewVisit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_next;
        private Button button_previous;
        private Label label_date;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private FlowLayoutPanel dayContainer;
        private Button btnCancel;
    }
}