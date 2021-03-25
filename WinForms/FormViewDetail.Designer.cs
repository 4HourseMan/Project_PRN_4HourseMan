
namespace WinForms
{
    partial class FormViewDetail
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
            this.tblOrderDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tblOrderDetail
            // 
            this.tblOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrderDetail.Location = new System.Drawing.Point(23, 25);
            this.tblOrderDetail.Name = "tblOrderDetail";
            this.tblOrderDetail.RowHeadersWidth = 51;
            this.tblOrderDetail.RowTemplate.Height = 24;
            this.tblOrderDetail.Size = new System.Drawing.Size(760, 395);
            this.tblOrderDetail.TabIndex = 0;
            // 
            // FormViewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.tblOrderDetail);
            this.Name = "FormViewDetail";
            this.Text = "DetailView";
            this.Load += new System.EventHandler(this.FormViewDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblOrderDetail;
    }
}