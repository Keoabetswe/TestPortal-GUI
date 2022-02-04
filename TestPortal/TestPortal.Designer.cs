namespace TestPortal
{
    partial class TestPortal
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
            this.btnLecturer = new System.Windows.Forms.Button();
            this.btnLearner = new System.Windows.Forms.Button();
            this.menuStrip1_File_About = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTestPortal = new System.Windows.Forms.Label();
            this.menuStrip1_File_About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLecturer
            // 
            this.btnLecturer.Location = new System.Drawing.Point(67, 236);
            this.btnLecturer.Name = "btnLecturer";
            this.btnLecturer.Size = new System.Drawing.Size(75, 23);
            this.btnLecturer.TabIndex = 3;
            this.btnLecturer.Text = "Lecturer";
            this.btnLecturer.UseVisualStyleBackColor = true;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // btnLearner
            // 
            this.btnLearner.Location = new System.Drawing.Point(148, 236);
            this.btnLearner.Name = "btnLearner";
            this.btnLearner.Size = new System.Drawing.Size(75, 23);
            this.btnLearner.TabIndex = 4;
            this.btnLearner.Text = "Learner";
            this.btnLearner.UseVisualStyleBackColor = true;
            this.btnLearner.Click += new System.EventHandler(this.btnLearner_Click);
            // 
            // menuStrip1_File_About
            // 
            this.menuStrip1_File_About.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1_File_About.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1_File_About.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1_File_About.Name = "menuStrip1_File_About";
            this.menuStrip1_File_About.Size = new System.Drawing.Size(288, 24);
            this.menuStrip1_File_About.TabIndex = 5;
            this.menuStrip1_File_About.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestPortal.Properties.Resources.img1;
            this.pictureBox1.Location = new System.Drawing.Point(67, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblTestPortal
            // 
            this.lblTestPortal.AutoSize = true;
            this.lblTestPortal.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestPortal.Location = new System.Drawing.Point(80, 34);
            this.lblTestPortal.Name = "lblTestPortal";
            this.lblTestPortal.Size = new System.Drawing.Size(134, 32);
            this.lblTestPortal.TabIndex = 2;
            this.lblTestPortal.Text = "Welcome To";
            // 
            // TestPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(288, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLearner);
            this.Controls.Add(this.btnLecturer);
            this.Controls.Add(this.lblTestPortal);
            this.Controls.Add(this.menuStrip1_File_About);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1_File_About;
            this.Name = "TestPortal";
            this.Text = "TestPortal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1_File_About.ResumeLayout(false);
            this.menuStrip1_File_About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLecturer;
        private System.Windows.Forms.Button btnLearner;
        private System.Windows.Forms.MenuStrip menuStrip1_File_About;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTestPortal;
    }
}

