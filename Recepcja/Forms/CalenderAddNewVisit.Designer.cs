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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            button_next = new Button();
            button_previous = new Button();
            dayContainer = new FlowLayoutPanel();
            label_date = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1139, 94);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 43;
            label8.Text = "Saturday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(974, 94);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 42;
            label7.Text = "Friday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(786, 94);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 41;
            label6.Text = "Thursday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(599, 94);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 40;
            label4.Text = "Wednesday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(430, 94);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 39;
            label3.Text = "Tuesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(251, 94);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 38;
            label5.Text = "Monday";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 94);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 37;
            label2.Text = "Sunday";
            label2.Click += label2_Click;
            // 
            // button_next
            // 
            button_next.Location = new Point(1222, 663);
            button_next.Name = "button_next";
            button_next.Size = new Size(75, 23);
            button_next.TabIndex = 36;
            button_next.Text = "next";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // button_previous
            // 
            button_previous.Location = new Point(1132, 663);
            button_previous.Name = "button_previous";
            button_previous.Size = new Size(75, 23);
            button_previous.TabIndex = 35;
            button_previous.Text = "previous";
            button_previous.UseVisualStyleBackColor = true;
            button_previous.Click += button_previous_Click;
            // 
            // dayContainer
            // 
            dayContainer.Location = new Point(46, 132);
            dayContainer.Name = "dayContainer";
            dayContainer.Size = new Size(1251, 525);
            dayContainer.TabIndex = 34;
            // 
            // label_date
            // 
            label_date.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_date.Location = new Point(397, 23);
            label_date.Name = "label_date";
            label_date.Size = new Size(437, 30);
            label_date.TabIndex = 44;
            label_date.Text = "MONTH YEAR";
            label_date.TextAlign = ContentAlignment.MiddleCenter;
            label_date.Click += label_date_Click;
            // 
            // CalenderAddNewVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 730);
            Controls.Add(label_date);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button_next);
            Controls.Add(button_previous);
            Controls.Add(dayContainer);
            Name = "CalenderAddNewVisit";
            Text = "CalenderAddNewVisit";
            Load += CalenderAddNewVisit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private Button button_next;
        private Button button_previous;
        private FlowLayoutPanel dayContainer;
        private Label label_date;
    }
}