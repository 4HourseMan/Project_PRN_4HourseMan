
namespace WinForms
{
    partial class AdHome
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
            this.btnManagePro = new System.Windows.Forms.Button();
            this.btnManageEmployee = new System.Windows.Forms.Button();
            this.ManageSupplier = new System.Windows.Forms.Button();
            this.ManageOrder = new System.Windows.Forms.Button();
            this.btnManageCus = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagePro
            // 
            this.btnManagePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagePro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManagePro.Location = new System.Drawing.Point(40, 129);
            this.btnManagePro.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagePro.Name = "btnManagePro";
            this.btnManagePro.Size = new System.Drawing.Size(180, 485);
            this.btnManagePro.TabIndex = 0;
            this.btnManagePro.Text = "Manage Car";
            this.btnManagePro.UseVisualStyleBackColor = true;
            this.btnManagePro.Click += new System.EventHandler(this.btnManagePro_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageEmployee.Location = new System.Drawing.Point(267, 129);
            this.btnManageEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(180, 485);
            this.btnManageEmployee.TabIndex = 1;
            this.btnManageEmployee.Text = "Manage Employee";
            this.btnManageEmployee.UseVisualStyleBackColor = true;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // ManageSupplier
            // 
            this.ManageSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ManageSupplier.Location = new System.Drawing.Point(489, 129);
            this.ManageSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.ManageSupplier.Name = "ManageSupplier";
            this.ManageSupplier.Size = new System.Drawing.Size(180, 485);
            this.ManageSupplier.TabIndex = 2;
            this.ManageSupplier.Text = "Manage Supplier";
            this.ManageSupplier.UseVisualStyleBackColor = true;
            this.ManageSupplier.Click += new System.EventHandler(this.ManageSupplier_Click);
            // 
            // ManageOrder
            // 
            this.ManageOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ManageOrder.Location = new System.Drawing.Point(720, 129);
            this.ManageOrder.Margin = new System.Windows.Forms.Padding(4);
            this.ManageOrder.Name = "ManageOrder";
            this.ManageOrder.Size = new System.Drawing.Size(180, 485);
            this.ManageOrder.TabIndex = 3;
            this.ManageOrder.Text = "Manage Order";
            this.ManageOrder.UseVisualStyleBackColor = true;
            this.ManageOrder.Click += new System.EventHandler(this.ManageOrder_Click);
            // 
            // btnManageCus
            // 
            this.btnManageCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageCus.Location = new System.Drawing.Point(948, 129);
            this.btnManageCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageCus.Name = "btnManageCus";
            this.btnManageCus.Size = new System.Drawing.Size(180, 485);
            this.btnManageCus.TabIndex = 4;
            this.btnManageCus.Text = "Manage Customer Infor";
            this.btnManageCus.UseVisualStyleBackColor = true;
            this.btnManageCus.Click += new System.EventHandler(this.btnManageCus_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogout.Location = new System.Drawing.Point(453, 676);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(263, 57);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1192, 746);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageCus);
            this.Controls.Add(this.ManageOrder);
            this.Controls.Add(this.ManageSupplier);
            this.Controls.Add(this.btnManageEmployee);
            this.Controls.Add(this.btnManagePro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdHome";
            this.Text = "Chain Hang Low - Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdHome_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManagePro;
        private System.Windows.Forms.Button btnManageEmployee;
        private System.Windows.Forms.Button ManageSupplier;
        private System.Windows.Forms.Button ManageOrder;
        private System.Windows.Forms.Button btnManageCus;
        private System.Windows.Forms.Button btnLogout;
    }
}