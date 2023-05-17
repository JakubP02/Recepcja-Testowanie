namespace Administracja.Forms
{
    partial class FormPopUpAdd
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
            buttonOk = new Button();
            labelText = new Label();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(157, 277);
            buttonOk.Margin = new Padding(3, 4, 3, 4);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(86, 31);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelText
            // 
            labelText.AutoEllipsis = true;
            labelText.Location = new Point(12, 9);
            labelText.Name = "labelText";
            labelText.Size = new Size(395, 264);
            labelText.TabIndex = 3;
            labelText.Text = "Something wrong!";
            labelText.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormPopUpAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 321);
            Controls.Add(labelText);
            Controls.Add(buttonOk);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPopUpAdd";
            Text = "FormPopUpAdd";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOk;
        private Label labelText;
    }
}