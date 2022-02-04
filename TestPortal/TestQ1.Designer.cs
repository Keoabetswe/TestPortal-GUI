namespace TestPortal
{
    partial class TestQ1
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
            this.lblMCT = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.radOptionB = new System.Windows.Forms.RadioButton();
            this.radOptionC = new System.Windows.Forms.RadioButton();
            this.radOptionA = new System.Windows.Forms.RadioButton();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.txtQuestion1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMCT
            // 
            this.lblMCT.AutoSize = true;
            this.lblMCT.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCT.Location = new System.Drawing.Point(94, 41);
            this.lblMCT.Name = "lblMCT";
            this.lblMCT.Size = new System.Drawing.Size(212, 32);
            this.lblMCT.TabIndex = 0;
            this.lblMCT.Text = "Multiple Choice Test";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(168, 285);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 22);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Location = new System.Drawing.Point(83, 153);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(48, 13);
            this.lblOptionA.TabIndex = 16;
            this.lblOptionA.Text = "Option A";
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Location = new System.Drawing.Point(83, 182);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(48, 13);
            this.lblOptionB.TabIndex = 17;
            this.lblOptionB.Text = "Option B";
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Location = new System.Drawing.Point(83, 215);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(48, 13);
            this.lblOptionC.TabIndex = 18;
            this.lblOptionC.Text = "Option C";
            // 
            // txtOptionA
            // 
            this.txtOptionA.Location = new System.Drawing.Point(168, 146);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.ReadOnly = true;
            this.txtOptionA.Size = new System.Drawing.Size(138, 20);
            this.txtOptionA.TabIndex = 19;
            this.txtOptionA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOptionB
            // 
            this.txtOptionB.Location = new System.Drawing.Point(168, 175);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.ReadOnly = true;
            this.txtOptionB.Size = new System.Drawing.Size(138, 20);
            this.txtOptionB.TabIndex = 20;
            this.txtOptionB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOptionC
            // 
            this.txtOptionC.Location = new System.Drawing.Point(168, 208);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.ReadOnly = true;
            this.txtOptionC.Size = new System.Drawing.Size(138, 20);
            this.txtOptionC.TabIndex = 21;
            this.txtOptionC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radOptionB
            // 
            this.radOptionB.AutoSize = true;
            this.radOptionB.Location = new System.Drawing.Point(168, 253);
            this.radOptionB.Name = "radOptionB";
            this.radOptionB.Size = new System.Drawing.Size(66, 17);
            this.radOptionB.TabIndex = 23;
            this.radOptionB.TabStop = true;
            this.radOptionB.Text = "Option B";
            this.radOptionB.UseVisualStyleBackColor = true;
            // 
            // radOptionC
            // 
            this.radOptionC.AutoSize = true;
            this.radOptionC.Location = new System.Drawing.Point(280, 253);
            this.radOptionC.Name = "radOptionC";
            this.radOptionC.Size = new System.Drawing.Size(66, 17);
            this.radOptionC.TabIndex = 24;
            this.radOptionC.TabStop = true;
            this.radOptionC.Text = "Option C";
            this.radOptionC.UseVisualStyleBackColor = true;
            // 
            // radOptionA
            // 
            this.radOptionA.AutoSize = true;
            this.radOptionA.Location = new System.Drawing.Point(53, 253);
            this.radOptionA.Name = "radOptionA";
            this.radOptionA.Size = new System.Drawing.Size(66, 17);
            this.radOptionA.TabIndex = 25;
            this.radOptionA.TabStop = true;
            this.radOptionA.Text = "Option A";
            this.radOptionA.UseVisualStyleBackColor = true;
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Location = new System.Drawing.Point(165, 84);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(58, 13);
            this.lblQuestion1.TabIndex = 27;
            this.lblQuestion1.Text = "Question 1";
            // 
            // txtQuestion1
            // 
            this.txtQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion1.Location = new System.Drawing.Point(25, 100);
            this.txtQuestion1.Name = "txtQuestion1";
            this.txtQuestion1.ReadOnly = true;
            this.txtQuestion1.Size = new System.Drawing.Size(340, 20);
            this.txtQuestion1.TabIndex = 29;
            this.txtQuestion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TestQ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 329);
            this.Controls.Add(this.txtQuestion1);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.radOptionA);
            this.Controls.Add(this.radOptionC);
            this.Controls.Add(this.radOptionB);
            this.Controls.Add(this.txtOptionC);
            this.Controls.Add(this.txtOptionB);
            this.Controls.Add(this.txtOptionA);
            this.Controls.Add(this.lblOptionC);
            this.Controls.Add(this.lblOptionB);
            this.Controls.Add(this.lblOptionA);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblMCT);
            this.Name = "TestQ1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.TestQ1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMCT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.RadioButton radOptionB;
        private System.Windows.Forms.RadioButton radOptionC;
        private System.Windows.Forms.RadioButton radOptionA;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.TextBox txtQuestion1;
    }
}