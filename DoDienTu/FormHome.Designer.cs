namespace DoDienTu
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDevice = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoDienTu.Properties.Resources.thiet_bi_dien_tu_la_gi;
            this.pictureBox2.Location = new System.Drawing.Point(219, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(599, 512);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoDienTu.Properties.Resources.icon_home1;
            this.pictureBox1.InitialImage = global::DoDienTu.Properties.Resources.icon_home;
            this.pictureBox1.Location = new System.Drawing.Point(31, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplier.BackgroundImage")));
            this.btnSupplier.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSupplier.Location = new System.Drawing.Point(31, 431);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(124, 88);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.Text = "Supplier Management";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClient.BackgroundImage")));
            this.btnClient.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnClient.Location = new System.Drawing.Point(31, 337);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(124, 88);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "Client Management";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDevice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDevice.BackgroundImage")));
            this.btnDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevice.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDevice.Location = new System.Drawing.Point(31, 243);
            this.btnDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(124, 88);
            this.btnDevice.TabIndex = 1;
            this.btnDevice.Text = "Device Management";
            this.btnDevice.UseVisualStyleBackColor = false;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStaff.BackgroundImage")));
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnStaff.Location = new System.Drawing.Point(31, 149);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(124, 88);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Staff Management";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoDienTu.Properties.Resources.pngtree_2d_illustration_abstract_futuristic_electronic_circuit_technology_background_image_458698;
            this.ClientSize = new System.Drawing.Size(863, 541);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnDevice);
            this.Controls.Add(this.btnStaff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}