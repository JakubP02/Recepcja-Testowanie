namespace Patient_handling
{
    partial class UserControlday
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            labelday = new Label();
            SuspendLayout();
            // 
            // labelday
            // 
            labelday.AutoSize = true;
            labelday.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelday.Location = new Point(16, 16);
            labelday.Name = "labelday";
            labelday.Size = new Size(32, 24);
            labelday.TabIndex = 0;
            labelday.Text = "00";
            // 
            // UserControlday
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelday);
            Name = "UserControlday";
            Size = new Size(170, 81);
            Load += UserControlday_Load;
            Click += UserControlday_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelday;
    }
}
