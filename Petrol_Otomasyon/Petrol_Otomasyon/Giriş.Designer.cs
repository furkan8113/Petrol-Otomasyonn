﻿namespace PETROL_OTOMASYON_8_ARALIIK
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kASAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOMPALARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şUBELERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERSONELToolStripMenuItem,
            this.kASAToolStripMenuItem,
            this.pOMPALARToolStripMenuItem,
            this.üRÜNToolStripMenuItem,
            this.şUBELERToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pERSONELToolStripMenuItem
            // 
            this.pERSONELToolStripMenuItem.Name = "pERSONELToolStripMenuItem";
            this.pERSONELToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.pERSONELToolStripMenuItem.Text = "PERSONEL";
            this.pERSONELToolStripMenuItem.Click += new System.EventHandler(this.pERSONELToolStripMenuItem_Click);
            // 
            // kASAToolStripMenuItem
            // 
            this.kASAToolStripMenuItem.Name = "kASAToolStripMenuItem";
            this.kASAToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.kASAToolStripMenuItem.Text = "KASA";
            // 
            // pOMPALARToolStripMenuItem
            // 
            this.pOMPALARToolStripMenuItem.Name = "pOMPALARToolStripMenuItem";
            this.pOMPALARToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.pOMPALARToolStripMenuItem.Text = "POMPALAR";
            // 
            // üRÜNToolStripMenuItem
            // 
            this.üRÜNToolStripMenuItem.Name = "üRÜNToolStripMenuItem";
            this.üRÜNToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.üRÜNToolStripMenuItem.Text = "ÜRÜN";
            // 
            // şUBELERToolStripMenuItem
            // 
            this.şUBELERToolStripMenuItem.Name = "şUBELERToolStripMenuItem";
            this.şUBELERToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.şUBELERToolStripMenuItem.Text = "ŞUBELER";
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Giriş";
            this.Text = "P";
            this.Load += new System.EventHandler(this.Giriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kASAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOMPALARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şUBELERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}