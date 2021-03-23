
namespace WinForms
{
    partial class FormViewSup
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
            this.tblSup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblSup)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSup
            // 
            this.tblSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSup.Location = new System.Drawing.Point(82, 39);
            this.tblSup.Name = "tblSup";
            this.tblSup.RowHeadersWidth = 51;
            this.tblSup.RowTemplate.Height = 24;
            this.tblSup.Size = new System.Drawing.Size(608, 325);
            this.tblSup.TabIndex = 0;
            // 
            // FormViewSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblSup);
            this.Name = "FormViewSup";
            this.Text = "FormViewSup";
            this.Load += new System.EventHandler(this.FormViewSup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblSup;
    }
}