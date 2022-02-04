namespace TestPortal
{
    partial class ViewMarks
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
            this.lblLearner = new System.Windows.Forms.Label();
            this.lblLearnerMark = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLearner
            // 
            this.lblLearner.AutoSize = true;
            this.lblLearner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearner.Location = new System.Drawing.Point(51, 125);
            this.lblLearner.Name = "lblLearner";
            this.lblLearner.Size = new System.Drawing.Size(185, 25);
            this.lblLearner.TabIndex = 20;
            this.lblLearner.Text = "Learner Obtained:";
            // 
            // lblLearnerMark
            // 
            this.lblLearnerMark.AutoSize = true;
            this.lblLearnerMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnerMark.Location = new System.Drawing.Point(113, 167);
            this.lblLearnerMark.Name = "lblLearnerMark";
            this.lblLearnerMark.Size = new System.Drawing.Size(24, 25);
            this.lblLearnerMark.TabIndex = 19;
            this.lblLearnerMark.Text = "?";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(131, 167);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 25);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "/ 3";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(98, 27);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(77, 32);
            this.lblMarks.TabIndex = 17;
            this.lblMarks.Text = "Marks";
            // 
            // ViewMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblLearner);
            this.Controls.Add(this.lblLearnerMark);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMarks);
            this.Name = "ViewMarks";
            this.Text = "ViewMarks";
            this.Load += new System.EventHandler(this.ViewMarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLearner;
        private System.Windows.Forms.Label lblLearnerMark;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMarks;
    }
}