namespace Recepcja
{
    partial class CalendarEditVisit
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
            btnCancel = new Button();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            dayContainer = new FlowLayoutPanel();
            label_date = new Label();
            button_next = new Button();
            button_previous = new Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(810, 537);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 23);
            btnCancel.TabIndex = 65;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 87);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 64;
            label1.Text = "Sunday";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(861, 87);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 63;
            label9.Text = "Saturday";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(742, 87);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 62;
            label10.Text = "Friday";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(599, 87);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 61;
            label11.Text = "Thursday";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(471, 87);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 60;
            label12.Text = "Wednesday";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(350, 87);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 59;
            label13.Text = "Tuesday";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(236, 87);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 58;
            label14.Text = "Monday";
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(72, 121);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(906, 381);
            dayContainer.TabIndex = 57;
            // 
            // label_date
            // 
            label_date.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_date.Location = new Point(250, 35);
            label_date.Name = "label_date";
            label_date.Size = new Size(437, 30);
            label_date.TabIndex = 56;
            label_date.Text = "MONTH YEAR";
            label_date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_next
            // 
            button_next.Location = new Point(900, 508);
            button_next.Name = "button_next";
            button_next.Size = new Size(75, 23);
            button_next.TabIndex = 55;
            button_next.Text = "next";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // button_previous
            // 
            button_previous.Location = new Point(810, 508);
            button_previous.Name = "button_previous";
            button_previous.Size = new Size(75, 23);
            button_previous.TabIndex = 54;
            button_previous.Text = "previous";
            button_previous.UseVisualStyleBackColor = true;
            button_previous.Click += button_previous_Click;
            // 
            // CalendarEditVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 596);
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
            Name = "CalendarEditVisit";
            Text = "CalendarEditVisit";
            Load += CalendarEditVisit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private FlowLayoutPanel dayContainer;
        private Label label_date;
        private Button button_next;
        private Button button_previous;
    }
}