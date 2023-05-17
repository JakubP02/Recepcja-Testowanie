namespace Administracja.Forms
{
    partial class FormReactivation
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
            label3 = new Label();
            textBox1 = new TextBox();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 50);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 11;
            label3.Text = "Tu pracownik";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 10;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(75, 148);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(356, 148);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 23);
            buttonConfirm.TabIndex = 8;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 84);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 7;
            label2.Text = "Administrator’s password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 21);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 6;
            label1.Text = "Reactivation employee";
            // 
            // FormReactivation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 212);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormReactivation";
            Text = "FormReactivation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private Button buttonCancel;
        private Button buttonConfirm;
        private Label label2;
        private Label label1;
    }
}