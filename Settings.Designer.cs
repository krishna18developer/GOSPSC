
namespace GOSPSC
{
    partial class Settings
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
            this.Process_label = new System.Windows.Forms.Label();
            this.process_box = new System.Windows.Forms.TextBox();
            this.Set_btn = new System.Windows.Forms.Button();
            this.duration_box = new System.Windows.Forms.TextBox();
            this.duration_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Process_label
            // 
            this.Process_label.AutoSize = true;
            this.Process_label.Location = new System.Drawing.Point(12, 29);
            this.Process_label.Name = "Process_label";
            this.Process_label.Size = new System.Drawing.Size(54, 13);
            this.Process_label.TabIndex = 0;
            this.Process_label.Text = "Process : ";
            // 
            // process_box
            // 
            this.process_box.Location = new System.Drawing.Point(72, 26);
            this.process_box.Name = "process_box";
            this.process_box.Size = new System.Drawing.Size(191, 20);
            this.process_box.TabIndex = 1;
            // 
            // Set_btn
            // 
            this.Set_btn.Location = new System.Drawing.Point(533, 23);
            this.Set_btn.Name = "Set_btn";
            this.Set_btn.Size = new System.Drawing.Size(75, 23);
            this.Set_btn.TabIndex = 2;
            this.Set_btn.Text = "Set";
            this.Set_btn.UseVisualStyleBackColor = true;
            this.Set_btn.Click += new System.EventHandler(this.Set_btn_Click);
            // 
            // duration_box
            // 
            this.duration_box.Location = new System.Drawing.Point(327, 26);
            this.duration_box.Name = "duration_box";
            this.duration_box.Size = new System.Drawing.Size(191, 20);
            this.duration_box.TabIndex = 4;
            // 
            // duration_label
            // 
            this.duration_label.AutoSize = true;
            this.duration_label.Location = new System.Drawing.Point(265, 29);
            this.duration_label.Name = "duration_label";
            this.duration_label.Size = new System.Drawing.Size(56, 13);
            this.duration_label.TabIndex = 3;
            this.duration_label.Text = "Duration : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Do not include .exe in Process Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "In Seconds";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 70);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duration_box);
            this.Controls.Add(this.duration_label);
            this.Controls.Add(this.Set_btn);
            this.Controls.Add(this.process_box);
            this.Controls.Add(this.Process_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Process_label;
        private System.Windows.Forms.TextBox process_box;
        private System.Windows.Forms.Button Set_btn;
        private System.Windows.Forms.TextBox duration_box;
        private System.Windows.Forms.Label duration_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}