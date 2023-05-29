namespace Recepcja
{
    partial class form_visitDetails
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
            textBoxDoctor = new TextBox();
            textBoxpatient = new TextBox();
            textBoxofficess = new TextBox();
            textBoxdate = new TextBox();
            textBoxhour = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxDoctor
            // 
            textBoxDoctor.Location = new Point(37, 74);
            textBoxDoctor.Name = "textBoxDoctor";
            textBoxDoctor.Size = new Size(100, 23);
            textBoxDoctor.TabIndex = 0;
            // 
            // textBoxpatient
            // 
            textBoxpatient.Location = new Point(37, 122);
            textBoxpatient.Name = "textBoxpatient";
            textBoxpatient.Size = new Size(100, 23);
            textBoxpatient.TabIndex = 1;
            // 
            // textBoxofficess
            // 
            textBoxofficess.Location = new Point(37, 169);
            textBoxofficess.Name = "textBoxofficess";
            textBoxofficess.Size = new Size(100, 23);
            textBoxofficess.TabIndex = 2;
            // 
            // textBoxdate
            // 
            textBoxdate.Location = new Point(37, 214);
            textBoxdate.Name = "textBoxdate";
            textBoxdate.Size = new Size(100, 23);
            textBoxdate.TabIndex = 3;
            // 
            // textBoxhour
            // 
            textBoxhour.Location = new Point(37, 256);
            textBoxhour.Name = "textBoxhour";
            textBoxhour.Size = new Size(100, 23);
            textBoxhour.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 56);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 5;
            label1.Text = "Doctor Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 104);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 6;
            label2.Text = "Patient Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 151);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Offices";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 196);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 240);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "Hour";
            // 
            // button1
            // 
            button1.Location = new Point(36, 285);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 10;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // form_visitDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 336);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxhour);
            Controls.Add(textBoxdate);
            Controls.Add(textBoxofficess);
            Controls.Add(textBoxpatient);
            Controls.Add(textBoxDoctor);
            Name = "form_visitDetails";
            Text = "visitDetails";
            Load += form_visitDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        public TextBox textBoxDoctor;
        public TextBox textBoxpatient;
        public TextBox textBoxofficess;
        public TextBox textBoxdate;
        public TextBox textBoxhour;
    }
}