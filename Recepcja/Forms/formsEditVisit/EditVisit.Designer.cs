namespace Recepcja
{
    partial class EditVisit
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
            dataGridViewEditVisit = new DataGridView();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditVisit).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 660);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(494, 39);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridViewEditVisit
            // 
            dataGridViewEditVisit.AllowUserToAddRows = false;
            dataGridViewEditVisit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditVisit.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewEditVisit.Location = new Point(12, 12);
            dataGridViewEditVisit.MultiSelect = false;
            dataGridViewEditVisit.Name = "dataGridViewEditVisit";
            dataGridViewEditVisit.RowHeadersVisible = false;
            dataGridViewEditVisit.RowHeadersWidth = 51;
            dataGridViewEditVisit.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewEditVisit.RowTemplate.Height = 25;
            dataGridViewEditVisit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEditVisit.Size = new Size(494, 597);
            dataGridViewEditVisit.TabIndex = 24;
            dataGridViewEditVisit.VirtualMode = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 615);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(494, 39);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditVisit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 724);
            Controls.Add(btnCancel);
            Controls.Add(dataGridViewEditVisit);
            Controls.Add(btnEdit);
            Name = "EditVisit";
            Text = "EditVisit";
            Load += EditVisit_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditVisit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private DataGridView dataGridViewEditVisit;
        private Button btnEdit;
    }
}