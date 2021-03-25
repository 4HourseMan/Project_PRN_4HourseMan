
namespace WinForms
{
    partial class EmpHome
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnViewSup = new System.Windows.Forms.Button();
            this.btnViewCar = new System.Windows.Forms.Button();
            this.lbUID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.Location = new System.Drawing.Point(405, 569);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(257, 57);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(845, 68);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 479);
            this.button5.TabIndex = 12;
            this.button5.Text = "Manage Customer Infor";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageOrder.Location = new System.Drawing.Point(290, 67);
            this.btnManageOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(232, 479);
            this.btnManageOrder.TabIndex = 11;
            this.btnManageOrder.Text = "Manage Order";
            this.btnManageOrder.UseVisualStyleBackColor = true;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnViewSup
            // 
            this.btnViewSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewSup.Location = new System.Drawing.Point(569, 67);
            this.btnViewSup.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSup.Name = "btnViewSup";
            this.btnViewSup.Size = new System.Drawing.Size(232, 479);
            this.btnViewSup.TabIndex = 10;
            this.btnViewSup.Text = "View Supplier";
            this.btnViewSup.UseVisualStyleBackColor = true;
            this.btnViewSup.Click += new System.EventHandler(this.btnViewSup_Click);
            // 
            // btnViewCar
            // 
            this.btnViewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewCar.Location = new System.Drawing.Point(32, 67);
            this.btnViewCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewCar.Name = "btnViewCar";
            this.btnViewCar.Size = new System.Drawing.Size(232, 479);
            this.btnViewCar.TabIndex = 8;
            this.btnViewCar.Text = "View Car";
            this.btnViewCar.UseVisualStyleBackColor = true;
            this.btnViewCar.Click += new System.EventHandler(this.btnViewCar_Click);
            // 
            // lbUID
            // 
            this.lbUID.AutoSize = true;
            this.lbUID.Location = new System.Drawing.Point(129, 9);
            this.lbUID.Name = "lbUID";
            this.lbUID.Size = new System.Drawing.Size(0, 17);
            this.lbUID.TabIndex = 14;
            // 
            // EmpHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1105, 661);
            this.Controls.Add(this.lbUID);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnManageOrder);
            this.Controls.Add(this.btnViewSup);
            this.Controls.Add(this.btnViewCar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmpHome";
            this.Text = "Chain Hang Low - Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpHome_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnManageOrder;
        private System.Windows.Forms.Button btnViewSup;
        private System.Windows.Forms.Button btnViewCar;
        private System.Windows.Forms.Label lbUID;
    }
}