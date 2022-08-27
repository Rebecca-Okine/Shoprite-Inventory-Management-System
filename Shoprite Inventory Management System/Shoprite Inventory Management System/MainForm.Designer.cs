namespace Shoprite_Inventory_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customerButton1 = new Shoprite_Inventory_Management_System.CustomerButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerButton2 = new Shoprite_Inventory_Management_System.CustomerButton();
            this.customerButton3 = new Shoprite_Inventory_Management_System.CustomerButton();
            this.customerButton4 = new Shoprite_Inventory_Management_System.CustomerButton();
            this.customerButton5 = new Shoprite_Inventory_Management_System.CustomerButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.customerButton5);
            this.panel1.Controls.Add(this.customerButton4);
            this.panel1.Controls.Add(this.customerButton3);
            this.panel1.Controls.Add(this.customerButton2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customerButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 113);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Shoprite Inventory Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 327);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // customerButton1
            // 
            this.customerButton1.Image = ((System.Drawing.Image)(resources.GetObject("customerButton1.Image")));
            this.customerButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageHover")));
            this.customerButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageNormal")));
            this.customerButton1.Location = new System.Drawing.Point(67, 51);
            this.customerButton1.Name = "customerButton1";
            this.customerButton1.Size = new System.Drawing.Size(57, 56);
            this.customerButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton1.TabIndex = 14;
            this.customerButton1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "PRODUCT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(191, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "CATEGORIES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(351, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ORDERS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(491, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "CUSTOMERS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(652, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "USERS";
            // 
            // customerButton2
            // 
            this.customerButton2.Image = ((System.Drawing.Image)(resources.GetObject("customerButton2.Image")));
            this.customerButton2.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton2.ImageHover")));
            this.customerButton2.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton2.ImageNormal")));
            this.customerButton2.Location = new System.Drawing.Point(347, 51);
            this.customerButton2.Name = "customerButton2";
            this.customerButton2.Size = new System.Drawing.Size(57, 56);
            this.customerButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton2.TabIndex = 24;
            this.customerButton2.TabStop = false;
            // 
            // customerButton3
            // 
            this.customerButton3.Image = ((System.Drawing.Image)(resources.GetObject("customerButton3.Image")));
            this.customerButton3.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton3.ImageHover")));
            this.customerButton3.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton3.ImageNormal")));
            this.customerButton3.Location = new System.Drawing.Point(655, 51);
            this.customerButton3.Name = "customerButton3";
            this.customerButton3.Size = new System.Drawing.Size(57, 56);
            this.customerButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton3.TabIndex = 25;
            this.customerButton3.TabStop = false;
            // 
            // customerButton4
            // 
            this.customerButton4.Image = ((System.Drawing.Image)(resources.GetObject("customerButton4.Image")));
            this.customerButton4.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton4.ImageHover")));
            this.customerButton4.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton4.ImageNormal")));
            this.customerButton4.Location = new System.Drawing.Point(494, 51);
            this.customerButton4.Name = "customerButton4";
            this.customerButton4.Size = new System.Drawing.Size(57, 56);
            this.customerButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton4.TabIndex = 26;
            this.customerButton4.TabStop = false;
            // 
            // customerButton5
            // 
            this.customerButton5.Image = ((System.Drawing.Image)(resources.GetObject("customerButton5.Image")));
            this.customerButton5.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton5.ImageHover")));
            this.customerButton5.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton5.ImageNormal")));
            this.customerButton5.Location = new System.Drawing.Point(194, 51);
            this.customerButton5.Name = "customerButton5";
            this.customerButton5.Size = new System.Drawing.Size(57, 56);
            this.customerButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton5.TabIndex = 27;
            this.customerButton5.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private CustomerButton customerButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomerButton customerButton5;
        private CustomerButton customerButton4;
        private CustomerButton customerButton3;
        private CustomerButton customerButton2;
    }
}