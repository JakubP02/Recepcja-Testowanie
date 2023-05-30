namespace Recepcja
{
    partial class UserControlEditVisit
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
            labelday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelday.Location = new Point(7, 5);
            labelday.Name = "labelday";
            labelday.Size = new Size(28, 21);
            labelday.TabIndex = 1;
            labelday.Text = "00";
            // 
            // UserControlEditVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelday);
            Name = "UserControlEditVisit";
            Size = new Size(121, 53);
            Load += UserControlEditVisit_Load;
            Click += UserControlEditVisit_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelday;
    }
}
